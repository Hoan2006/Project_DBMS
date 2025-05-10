using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MuonSachDAO
    {
       
        private static MuonSachDAO instance;
        public static MuonSachDAO Instance
        {
            get { if (instance == null) instance = new MuonSachDAO(); return instance; }
            private set { instance = value; }
        }
        private MuonSachDAO() { }


        public DataTable LoadLichSuMuonSachByTaiKhoan(int maTaiKhoan)
        {
            string query = "exec SP_GetLichSuMuonSachByMaTaiKhoan @MaTaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTaiKhoan });
            return data;
        }

    }
}
