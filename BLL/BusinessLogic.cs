using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BusinessLogic
    {
        DataAccess dal = new DataAccess();

        //public DataTable GetAllUsers()
        //{
        //    string query = "SELECT * FROM Users";
        //    return dal.GetData(query);
        //}
        public DataTable GetLuong()
        {
            return dal.GetLuongData();
        }
        public bool CheckConnection()
        {
            return dal.TestConnection();
        }
        public bool Login(string username, string password)
        {
            return dal.CheckLogin(username, password);
        }
        public string GetTenNhanVien(string username, string password)
        {
            return dal.GetTenNhanVien(username, password);
        }

        public DataTable GetNhanVien()
        {
            return dal.GetNhanVienData();
        }

        public DataTable GetNhaCungCap()
        {
            return dal.GetNhaCungCap();
        }

        public bool InsertNhanVien(string userName, string matKhau, string hoTen, string email, string diaChi, string sdt, string role)
        {
            return dal.InsertAddNhanVien(userName, matKhau, hoTen, email, diaChi, sdt, role);
        }


        public bool InsertAddNhaCungCap(string email, string name, string sdt, string diaChi)
        {
            return dal.InsertNhaCungCap(email, name, sdt, diaChi);
        }

        public DataTable SearchNhanVien(string searchTerm)
        {
            return dal.SearchNhanVien(searchTerm);
        }
        public DataTable SearchItemNhaCungCap(string searchTerm1)
        {
            return dal.SearchNhaCungCap(searchTerm1);
        }

    }
}
