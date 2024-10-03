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
    public partial class fadd_nhacungcap : Form
    {
        BusinessLogic logic = new BusinessLogic();
        public fadd_nhacungcap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            string email = txt_email.Text;
            string name = txt_name.Text;
            string sdt = txt_sdt.Text;
            string diaChi = txt_diaChi.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                return;
            }

            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải có định dạng @gmail.com!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                return;
            }

            if (sdt.Length != 10 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                return;
            }

            bool isSuccess = logic.InsertAddNhaCungCap(email, name, sdt, diaChi);

            if (isSuccess)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logic.GetNhaCungCap();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button1.Enabled = true;


        }
    }
    
}
