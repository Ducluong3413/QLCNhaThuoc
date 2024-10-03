using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace DAL
{
    public class DataAccess
    {
        //private string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
        string connectionString = "Server=127.0.0.1;Database=k;User ID=root;Password='';SslMode=none;";
        //public DataTable GetData(string query)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //    }
        //}
        public bool TestConnection()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool CheckLogin(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM nhanvien WHERE sdt_nhan_vien = @Username AND mat_khau = @Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                //if (username == null || password == null) return false;
                try
                {
                    connection.Open();
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result == 1;  // Nếu có 1 bản ghi khớp, đăng nhập thành công
                }
                catch
                {
                    return false;  // Đăng nhập thất bại do lỗi
                }
            }
        }
        public string GetTenNhanVien(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Truy vấn để lấy tên nhân viên dựa trên username và password
                string query = "SELECT ten_nhan_vien FROM nhanvien WHERE sdt_nhan_vien = @Username AND mat_khau = @Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    // Nếu kết quả không null, trả về tên nhân viên
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null;  // Trả về null nếu không tìm thấy bản ghi
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    Console.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        // Phương thức lấy dữ liệu từ bảng luong
        public DataTable GetLuongData()
        {
            // Tạo DataTable để chứa dữ liệu
            DataTable dt = new DataTable();

            // Chuỗi truy vấn để lấy các cột cần thiết từ bảng luong
            //string query = "SELECT * FROM luong";
            string query = "SELECT luong.*, nhanvien.ten_nhan_vien FROM luong JOIN nhanvien ON luong.nhanvien_id = nhanvien.nhanvien_id; ";
            
            //string query = "SELECT luong_id,nhanvien_id, luongcoban, he_so_luong, tong_luong FROM luong";

            // Kết nối với cơ sở dữ liệu
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Tạo MySqlCommand với truy vấn và kết nối
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Sử dụng MySqlDataAdapter để đổ dữ liệu vào DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);  // Đổ dữ liệu vào DataTable
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi xảy ra
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            // Trả về DataTable chứa dữ liệu từ bảng luong
            return dt;
        }

        public DataTable GetNhanVienData()
        {
            DataTable dt = new DataTable();
            String nhanvien = "Select * From nhanvien";
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                MySqlCommand cmm = new MySqlCommand(nhanvien, connect);
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmm);
                    da.Fill(dt);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e.Message);
                }
            }
            return dt; 
        }

        public DataTable GetNhaCungCap()
        {
            DataTable dt = new DataTable();
            String ncc = "Select * From nhacungcap";
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                MySqlCommand cmm = new MySqlCommand(ncc, connect);
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmm);
                    da.Fill(dt);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e.Message);
                }
                return dt;
                }
         }



        public bool InsertAddNhanVien(string userName, string matKhau, string hoTen, string email, string diaChi, string sdt, string role)
        {
            string query = "INSERT INTO nhanvien (user_name, mat_khau, ten_nhan_vien, email_nhan_vien, dia_chi_nhan_vien, sdt_nhan_vien, role) " +
                           "VALUES ('" + userName + "', '" + matKhau + "', N'" + hoTen + "', '" + email + "', N'" + diaChi + "', '" + sdt + "', '" + role + "')";

            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);
                try
                {
                    connect.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }


       public bool InsertNhaCungCap(string email, string name, string sdt, string diaChi)
{
    string query = "INSERT INTO nhacungcap (email_ncc, ten_ncc, sdt_ncc, dia_chi_ncc) VALUES ('" + email + "', N'" + name + "', '" + sdt + "', N'" + diaChi + "')";
    
    using (MySqlConnection connect = new MySqlConnection(connectionString))
    {
        MySqlCommand cmd = new MySqlCommand(query, connect);
        try
        {
            connect.Open();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        catch
        {
            return false;
        }
    }
}

        public DataTable SearchNhanVien(string searchTerm)
        {
            string query = "SELECT * FROM nhanvien WHERE nhanvien_id = @id OR ten_nhan_vien LIKE N'%" + searchTerm + "%'";

            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id", searchTerm); 
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    connect.Open();
                    da.Fill(dt);
                }
                catch (Exception ex) 
                {
                    return null;
                }
                return dt; 
            }
        }


        public DataTable SearchNhaCungCap(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return null;
            }

            string query = "SELECT * FROM nhacungcap WHERE ncc_id = '" + searchTerm + "' OR ten_ncc LIKE N'%" + searchTerm + "%'";

            DataTable dt = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                try
                {
                    connect.Open();
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

            return dt;
        }



    }
}
