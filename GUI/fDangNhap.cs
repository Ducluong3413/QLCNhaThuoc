using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class fDangNhap : Form
    {
        private BusinessLogic dbManager = new BusinessLogic();
        
        public fDangNhap()
        {
            InitializeComponent();
            tb_Sdt.Text = string.Empty;
            tb_Matkhau.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_Sdt.Text;
            string password = tb_Matkhau.Text;
            // Kiểm tra nếu bất kỳ TextBox nào trống
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sớm nếu username trống
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kết thúc sớm nếu password trống
            }
            bool isAuthenticated = dbManager.Login(username, password);
            string tenNhanVien = dbManager.GetTenNhanVien(username, password);
            if (isAuthenticated && tenNhanVien != null)
            {
                //MessageBox.Show("Đăng nhập thành công!");
                // Chuyển sang form khác sau khi đăng nhập thành công
                fTrangChu mainForm = new fTrangChu(tenNhanVien);
                

                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại.");
            }
        }

        private void tb_Sdt_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím nhấn là Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn chặn âm thanh "ding" khi nhấn Enter
                tb_Matkhau.Focus(); // Chuyển đến TextBox mật khẩu
            }
        }

        private void tb_Matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn chặn âm thanh "ding" khi nhấn Enter
                button1.Focus(); // Chuyển đến TextBox mật khẩu
            }
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Utils.ConfirmExit())
            {
                e.Cancel = true; // Hủy đóng form nếu người dùng chọn "No"
            }
        }

    }
}
