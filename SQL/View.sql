-- Get account list
CREATE VIEW VW_Account_List AS
SELECT
	*
FROM dbo.TaiKhoan 

GO

-- Get Sách list
CREATE VIEW VW_Book_List AS
SELECT 
    S.MaSach, 
    TG.TenTacGia, 
    TL.TenTheLoai, 
    NXB.TenNhaXuatBan, 
    S.TenSach, 
    S.LoaiTaiLieu, 
    S.NamXuatBan, 
    S.GiaSach, 
    S.SoLuong
FROM 
    Sach S
INNER JOIN 
    TacGia TG ON S.MaTacGia = TG.MaTacGia
INNER JOIN 
    TheLoai TL ON S.MaTheLoai = TL.MaTheLoai
INNER JOIN 
    NhaXuatBan NXB ON S.MaNhaXuatBan = NXB.MaNhaXuatBan;

GO

-- Get Nhà Xuất Bản list
CREATE VIEW VW_NhaXuatBan_List AS
SELECT *
FROM dbo.NhaXuatBan

GO
-- Get Thể Loại list
CREATE VIEW VW_TheLoai_List AS
SELECT *
FROM dbo.TheLoai

GO
-- Get Tác Giả list
CREATE VIEW VW_TacGia_List AS
SELECT *
FROM dbo.TacGia

GO

-- Get Phiếu Mượn list
Create VIEW VW_Book_Loan_Coupon_List AS
SELECT 
	*
FROM dbo.PhieuMuonSach 







