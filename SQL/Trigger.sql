-- Trigger không cho trùng phone
CREATE TRIGGER TR_Not_Duplicate_Phone_Number
ON dbo.TaiKhoan
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS
	(
		SELECT * FROM inserted i
		WHERE EXISTS(	SELECT * FROM dbo.TaiKhoan TK 
						WHERE	(TK.SoDienThoai = i.SoDienThoai) 
						AND		(TK.MaTaiKhoan <> i.MaTaiKhoan)
					)
	) 
    BEGIN
		RAISERROR ('Duplicate phone number is not allowed', 16, 1);
        ROLLBACK TRANSACTION;
	END
END;

GO
-- Trigger cập nhật số lượng sách khi mượn
CREATE TRIGGER TR_Not_Update_Books_Quantity_After_Borrowed
ON dbo.CuonSach
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaPhieuMuon INT;

    SELECT @MaPhieuMuon = MaPhieuMuon FROM inserted;

    UPDATE S
    SET S.SoLuong = S.SoLuong - 1
    FROM dbo.CuonSach CS
    JOIN dbo.Sach S ON CS.MaSach = S.MaSach
    WHERE CS.MaPhieuMuon = @MaPhieuMuon;
END;

GO

-- Trigger không cho xóa thể loại nếu có sách thuộc thể loại đó
CREATE TRIGGER TR_Prevent_Delete_TheLoai
ON TheLoai
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM Sach s
        INNER JOIN deleted d ON s.MaTheLoai = d.MaTheLoai
        WHERE s.MaTheLoai IS NOT NULL
    )
    BEGIN
        RAISERROR('Không thể xóa thể loại vì còn tồn tại sách thuộc thể loại này.', 16, 1);
        RETURN;
    END
    ELSE
    BEGIN
        DELETE FROM TheLoai
        WHERE MaTheLoai IN (SELECT MaTheLoai FROM deleted);
    END
END;
GO

-- Trigger không cho xóa tác giả nếu có sách thuộc tác giả đó
CREATE TRIGGER TR_Prevent_Delete_TacGia
ON TacGia
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM Sach s
        INNER JOIN deleted d ON s.MaTacGia = d.MaTacGia
        WHERE s.MaTacGia IS NOT NULL
    )
    BEGIN
        RAISERROR('Không thể xóa tác giả vì còn tồn tại sách thuộc tác giả này.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
GO

-- Trigger không cho xóa nxb nếu có sách thuộc nxb đó
CREATE TRIGGER TR_Prevent_Delete_NXB
ON NhaXuatBan
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM Sach s
        INNER JOIN deleted d ON s.MaNhaXuatBan = d.MaNhaXuatBan
        WHERE s.MaNhaXuatBan IS NOT NULL
    )
    BEGIN
        RAISERROR('Không thể xóa nhà xuất bản vì còn tồn tại sách thuộc nhà xuất bản này.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
GO

-- Trigger không cho tạo thể loại trùng
CREATE TRIGGER TR_Prevent_duplicate_category 
ON TheLoai
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM TheLoai t
        JOIN INSERTED i ON t.TenTheLoai = i.TenTheLoai WHERE t.MaTheLoai<>i.MaTheLoai
    )
    BEGIN
        RAISERROR('Không được tạo thể loại trùng với thể loại có sẵn.', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END; 

GO
-- Trigger không cho tạo sách trùng
CREATE TRIGGER TR_Prevent_duplicate_Book
ON dbo.Sach
AFTER INSERT
AS
BEGIN
	IF EXISTS (
	SELECT 1 
	FROM Sach S 
	JOIN inserted i 
	ON S.MaTacGia = i.MaTacGia 
	WHERE	S.TenSach = i.TenSach AND
			S.MaTacGia = i.MaTacGia AND
			S.MaTheLoai = i.MaTheLoai AND
			S.MaNhaXuatBan = i.MaNhaXuatBan AND
			S.LoaiTaiLieu = i.LoaiTaiLieu AND
			S.NamXuatBan = i.NamXuatBan AND
			S.GiaSach = i.GiaSach AND
			S.MaSach<>i.MaSach)
	BEGIN
		RAISERROR('Không được tạo sách trùng với sách có sẵn.', 16, 1);
		ROLLBACK TRANSACTION;
	END;
END;

GO
-- Trigger không cho tạo tác giả trùng
CREATE TRIGGER TR_Prevent_duplicate_Author
ON dbo.TacGia
AFTER INSERT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM TacGia TG JOIN inserted i ON TG.TenTacGia = i.TenTacGia AND TG.MaTacGia <> i.MaTacGia)
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR('Không được tạo tác giả trùng tên với tác giả có sẵn.', 16, 1);
    END
END

GO
-- Trigger không cho tạo NXB trùng
CREATE OR ALTER TRIGGER TR_Prevent_Publisher_Duplicate
ON dbo.NhaXuatBan
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
         SELECT i.TenNhaXuatBan
         FROM inserted i
         WHERE (SELECT COUNT(*) FROM dbo.NhaXuatBan p 
                WHERE p.TenNhaXuatBan = i.TenNhaXuatBan) > 1
    )
    BEGIN
        RAISERROR('Không được tạo nhà xuất bản trùng với nhà xuất bản có sẵn.', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;

GO
/***	Create SQL Server account (Phat)		***/
CREATE TRIGGER TR_Create_SQL_Server_Account
ON dbo.TaiKhoan
AFTER INSERT
AS
BEGIN
    DECLARE @Email NVARCHAR(255), 
            @MatKhau NVARCHAR(255), 
            @VaiTro NVARCHAR(255), 
            @MaTaiKhoan NVARCHAR(255),
            @Query NVARCHAR(MAX);

    SELECT @Email = Email, 
           @MatKhau = MatKhau, 
           @VaiTro = VaiTro, 
           @MaTaiKhoan = MaTaiKhoan 
    FROM inserted;

    SET @Query = 'CREATE LOGIN [' + @Email + '] WITH PASSWORD = N''' + @MatKhau + ''', DEFAULT_DATABASE=[Library], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;';
    BEGIN TRY
        EXEC sp_executesql @Query;
    END TRY
    BEGIN CATCH
        PRINT 'Error creating LOGIN: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;

    SET @Query = 'CREATE USER [' + @Email + '] FOR LOGIN [' + @Email + '];';
    BEGIN TRY
        EXEC sp_executesql @Query;
    END TRY
    BEGIN CATCH
        PRINT 'Error creating USER: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;

    IF (@VaiTro = N'Quản trị viên')
    BEGIN
        SET @Query = 'ALTER SERVER ROLE sysadmin ADD MEMBER [' + @Email + '];';
    END
    ELSE IF (@VaiTro = N'Thủ thư')
    BEGIN
        SET @Query = 'ALTER ROLE ThuThu ADD MEMBER [' + @Email + '];';
    END
    ELSE
    BEGIN
        SET @Query = 'ALTER ROLE DocGia ADD MEMBER [' + @Email + '];';
    END

    BEGIN TRY
        EXEC sp_executesql @Query;
    END TRY
    BEGIN CATCH
        PRINT 'Error assigning role: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;

END;

GO
/***	Update SQL Server account (Phat)		***/
CREATE TRIGGER TR_Update_SQL_Server_Account
ON dbo.TaiKhoan
AFTER UPDATE
AS
BEGIN
    DECLARE @Email NVARCHAR(255), 
            @MatKhau NVARCHAR(255), 
            @VaiTro NVARCHAR(255), 
            @MaTaiKhoan NVARCHAR(255),
            @OldEmail NVARCHAR(255),
            @OldMatKhau NVARCHAR(255),
            @Query NVARCHAR(MAX);

    SELECT @Email = Email, 
           @MatKhau = MatKhau, 
           @VaiTro = VaiTro, 
           @MaTaiKhoan = MaTaiKhoan 
    FROM inserted;

    SELECT @OldEmail = Email, 
           @OldMatKhau = MatKhau
    FROM deleted;

    IF (@Email <> @OldEmail OR @MatKhau <> @OldMatKhau)
    BEGIN
        SET @Query = 'ALTER LOGIN [' + @OldEmail + '] WITH PASSWORD = N''' + @MatKhau + ''', NAME = [' + @Email + '];';
        BEGIN TRY
            EXEC sp_executesql @Query;
        END TRY
        BEGIN CATCH
            PRINT 'Error updating LOGIN: ' + ERROR_MESSAGE();
            ROLLBACK TRANSACTION;
        END CATCH;

        SET @Query = 'ALTER USER [' + @OldEmail + '] WITH NAME = [' + @Email + '];';
        BEGIN TRY
            EXEC sp_executesql @Query;
        END TRY
        BEGIN CATCH
            PRINT 'Error updating USER: ' + ERROR_MESSAGE();
            ROLLBACK TRANSACTION;
        END CATCH;
    END

    IF (@VaiTro = N'Quản trị viên')
    BEGIN
        SET @Query = 'ALTER SERVER ROLE sysadmin ADD MEMBER [' + @Email + '];';
    END
    ELSE IF (@VaiTro = N'Thủ thư')
    BEGIN
        SET @Query = 'ALTER ROLE ThuThu ADD MEMBER [' + @Email + '];';
    END
    ELSE
    BEGIN
        SET @Query = 'ALTER ROLE DocGia ADD MEMBER [' + @Email + '];';
    END

    BEGIN TRY
        EXEC sp_executesql @Query;
    END TRY
    BEGIN CATCH
        PRINT 'Error assigning role: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH;

END;

GO
/***	Delete SQL Server account (Phat)		***/
CREATE TRIGGER TR_Delete_SQL_Server_Account
ON dbo.TaiKhoan
AFTER DELETE
AS
BEGIN
    DECLARE @Email NVARCHAR(255),
            @Query NVARCHAR(MAX),
            @SessionID INT;

    SELECT @Email = Email 
    FROM deleted;

    SELECT @SessionID = session_id 
    FROM sys.dm_exec_sessions
    WHERE login_name = @Email;

    IF @SessionID IS NOT NULL
    BEGIN
        SET @Query = 'KILL ' + CONVERT(nvarchar(20), @SessionID);
        EXEC (@Query);
    END

    SET @Query = 'DROP USER [' + @Email + '];';
    EXEC (@Query);

    SET @Query = 'DROP LOGIN [' + @Email + '];';
    EXEC (@Query);
END;


