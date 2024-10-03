using BLL;
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
    public partial class fadd_nhanvien : Form
    {
        private BusinessLogic logic = new BusinessLogic();
        public fadd_nhanvien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;

            string userName = txt_userName.Text;
            string matKhau = txt_matKhau.Text;
            string hoTen = txt_hoTen.Text;
            string email = txt_email.Text;
            string diaChi = txt_diaChi.Text;
            string sdt = txt_SDT.Text;

            if (cb_role.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                return;
            }

            string role = cb_role.SelectedItem.ToString();

            if (!System.Text.RegularExpressions.Regex.IsMatch(userName, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$"))
            {
                MessageBox.Show("Username phải có ít nhất 1 ký tự in hoa, chữ cái, số và 1 ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                return;
            }

            if (matKhau.Length < 4 || matKhau.Length > 12)
            {
                MessageBox.Show("Mật khẩu phải có độ dài từ 4 đến 12 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                return;
            }

            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải có đuôi '@gmail.com'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải là 10 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                return;
            }

            bool isSuccess = logic.InsertNhanVien(userName, matKhau, hoTen, email, diaChi, sdt, role);

            if (isSuccess)
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logic.GetNhanVien();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button1.Enabled = true;

        }

        private void fadd_nhanvien_Load(object sender, EventArgs e)
        {
            cb_role.Items.Add("NV");
            cb_role.Items.Add("DS");
            cb_role.Items.Add("admin");
        }
    }
}
