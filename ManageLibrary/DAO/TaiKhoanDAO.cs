using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO()
        {
        }

        public bool Register(TaiKhoan taiKhoan)
        {
            string query = "SP_Register_Account_New @MaTaiKhoan, @Email, @MatKhau, @VaiTro, @HoTen, @SoDienThoai, @NgaySinh, @DiaChi, @GioiTinh";

            try
            {
                // Execute the stored procedure with all required parameters
                DataProvider.Instance.ExecuteNonQuery(query, new object[]
                {
                    taiKhoan.MaTaiKhoan,
                    taiKhoan.Email,
                    taiKhoan.MatKhau,
                    taiKhoan.VaiTro,
                    taiKhoan.HoTen,
                    taiKhoan.SoDienThoai,
                    taiKhoan.NgaySinh,
                    taiKhoan.DiaChi,
                    taiKhoan.GioiTinh
                });
                Console.WriteLine($"Email: {taiKhoan.Email}, MatKhau: {taiKhoan.MatKhau}, VaiTro: {taiKhoan.VaiTro}, HoTen: {taiKhoan.HoTen}, SoDienThoai: {taiKhoan.SoDienThoai}, NgaySinh: {taiKhoan.NgaySinh}, DiaChi: {taiKhoan.DiaChi}, GioiTinh: {taiKhoan.GioiTinh}");

                string CreateLoginQuery = $"CREATE LOGIN [{taiKhoan.Email}] WITH PASSWORD = '{taiKhoan.MatKhau}'";
                string CreateUserQuery = $"CREATE USER [{taiKhoan.Email}] FOR LOGIN [{taiKhoan.Email}]";
                string GrantRoleQuery = $"EXEC sp_addrolemember '{taiKhoan.VaiTro}', [{taiKhoan.Email}]";

                DataProvider.Instance.ExecuteNonQuery(CreateLoginQuery);
                DataProvider.Instance.ExecuteNonQuery(CreateUserQuery);
                DataProvider.Instance.ExecuteNonQuery(GrantRoleQuery);

                Session.loginAccount = taiKhoan; // Store the account in the session


                return true; // Registration successful
            }
            catch (Exception ex)
            {
                Console.WriteLine("Registration failed: " + ex.Message);
                return false;
            }
        }
        public TaiKhoan GetTaiKhoanByEmail(string email)
        {
            string query = "exec SP_Get_Account_Profile @Email";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email });
            if (data.Rows.Count > 0)
            {
                return new TaiKhoan(data.Rows[0]);
            }
            return null;
        }




        public bool UpdateProfile(TaiKhoan tk)
        {
            string query = "SP_Account_Profile @MaTaiKhoan , @HoTen , @DiaChi , @NgaySinh , @SoDienThoai , @GioiTinh ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tk.MaTaiKhoan, tk.HoTen, tk.DiaChi, tk.NgaySinh, tk.SoDienThoai, tk.GioiTinh });

            return result > 0;
        }


        public bool CheckLogin(string email, string password)
        {
            string query = "exec SP_Login @Email , @MatKhau";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email, password });
            if (data.Rows.Count > 0)
            {
                return true;
                
            }
            return false;
        }
    }
}