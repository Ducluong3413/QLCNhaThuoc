using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fTrangChu : Form
    {
        private string tenNhanVien;
        public fTrangChu(string tenNhanVien)
        {
            InitializeComponent();
            this.tenNhanVien = tenNhanVien;
            lblTenNhanVien.Text = tenNhanVien;
        }
        private void fTrangChu_Load(object sender, EventArgs e)
        {
            
            // Hiển thị tên nhân viên lên Label khi form được load
            //lblTenNhanVien.Text = tenNhanVien;
        }
        public fTrangChu()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fNhanVien nv = new fNhanVien();
            if(this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0);
            }
            nv.TopLevel = false;
            panel4.Controls.Add(nv);
            nv.Dock = DockStyle.Fill;
            nv.FormBorderStyle = FormBorderStyle.None;
            nv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fDangNhap dn = new fDangNhap();
            if (this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0); // Xóa form con trước đó (nếu có)
            }
            dn.TopLevel = false;
            panel4.Controls.Add(dn);
            dn.Dock = DockStyle.Fill;
            dn.FormBorderStyle = FormBorderStyle.None;
            dn.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fTienLuong tl = new fTienLuong();
            if (this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0); // Xóa form con trước đó (nếu có)
            }
            tl.TopLevel = false;
            panel4.Controls.Add(tl);
            tl.Dock = DockStyle.Fill;
            tl.FormBorderStyle = FormBorderStyle.None;
            tl.Show();
        }

        private void fTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Utils.ConfirmExit())
            {
                e.Cancel = true; // Hủy đóng form nếu người dùng chọn "No"
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            fDangNhap loginForm = new fDangNhap();
            loginForm.Show();

            // Ẩn form hiện tại (fTrangChu)
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fNhaCungCap ncc = new fNhaCungCap();
            if(this.panel4.Controls.Count > 0)
            {
                this.panel4.Controls.RemoveAt(0);
            }
            ncc.TopLevel = false;
            panel4.Controls.Add(ncc );
            ncc.Dock = DockStyle.Fill;
            ncc.FormBorderStyle = FormBorderStyle.None;
            ncc.Show();
        }
    }
}
