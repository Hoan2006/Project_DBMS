using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions; // Đừng quên include namespace này

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }

        string ConnStr = "Data Source=LAPTOP-3EVRR5L8;Initial Catalog=ManageLibrary;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        // Phương thức khởi tạo là private để ngăn tạo đối tượng từ bên ngoài
        private DataProvider()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }

        public DataTable ExecuteQuery(string query, params object[] parameter)
        {
            DataTable data = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                comm.CommandText = query;
                comm.CommandType = CommandType.Text;

                // Sử dụng Regex để trích xuất tên các tham số trong query
                Regex rx = new Regex(@"@\w+");
                var matches = rx.Matches(query)
                                .Cast<Match>()
                                .Select(m => m.Value)
                                .Distinct()
                                .ToArray();

                // Nếu có tham số truyền vào và tìm được tên tham số trong query
                if (parameter != null && parameter.Length > 0 && matches.Length > 0)
                {
                    comm.Parameters.Clear();
                    if (matches.Length != parameter.Length)
                    {
                        throw new Exception("Số lượng tham số trong query không khớp với số lượng tham số được truyền vào.");
                    }
                    for (int i = 0; i < matches.Length; i++)
                    {
                        comm.Parameters.AddWithValue(matches[i], parameter[i]);
                    }
                }
                da = new SqlDataAdapter(comm);
                da.Fill(data);
            }
            catch (Exception ex)
            {
                // Bạn có thể xử lý hoặc ghi log lỗi tại đây.
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        // Nếu cần, bạn có thể cập nhật tương tự cho ExecuteNonQuery và ExecuteScalar
        public int ExecuteNonQuery(string query, params object[] parameter)
        {
            int result = 0;
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                comm.CommandText = query;
                comm.CommandType = CommandType.Text;
                if (parameter != null && parameter.Length > 0)
                {
                    comm.Parameters.Clear();

                    // Dùng cùng cách xử lý như ở ExecuteQuery
                    Regex rx = new Regex(@"@\w+");
                    var matches = rx.Matches(query)
                                    .Cast<Match>()
                                    .Select(m => m.Value)
                                    .Distinct()
                                    .ToArray();
                    if (matches.Length != parameter.Length)
                    {
                        throw new Exception("Số lượng tham số trong query không khớp với số lượng tham số được truyền vào.");
                    }
                    for (int i = 0; i < matches.Length; i++)
                    {
                        comm.Parameters.AddWithValue(matches[i], parameter[i]);
                    }
                }
                result = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public object ExecuteScalar(string query, params object[] parameter)
        {
            object data = null;
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                comm.CommandText = query;
                comm.CommandType = CommandType.Text;
                if (parameter != null && parameter.Length > 0)
                {
                    comm.Parameters.Clear();
                    Regex rx = new Regex(@"@\w+");
                    var matches = rx.Matches(query)
                                    .Cast<Match>()
                                    .Select(m => m.Value)
                                    .Distinct()
                                    .ToArray();
                    if (matches.Length != parameter.Length)
                    {
                        throw new Exception("Số lượng tham số trong query không khớp với số lượng tham số được truyền vào.");
                    }
                    for (int i = 0; i < matches.Length; i++)
                    {
                        comm.Parameters.AddWithValue(matches[i], parameter[i]);
                    }
                }
                data = comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return data;
        }
    }
}
