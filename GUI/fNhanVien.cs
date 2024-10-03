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
    public partial class fNhanVien : Form
    {
        private BusinessLogic logic = new BusinessLogic();
        private DataTable dtnhanvien;
        public fNhanVien()
        {
            InitializeComponent();
        }


        private void fNhanVien_Load(object sender, EventArgs e)
        {
            dtnhanvien = logic.GetNhanVien();

            if (dtnhanvien != null && dtnhanvien.Rows.Count > 0)
            {
                dataGridView_nhanvien.DataSource = dtnhanvien;
                dataGridView_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_nhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView_nhanvien.DefaultCellStyle.Font = new Font("Arial", 12);
                dataGridView_nhanvien.DefaultCellStyle.Padding = new Padding(6);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_addNhanVien_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fadd_nhanvien"] == null)
            {
                fadd_nhanvien add = new fadd_nhanvien();
                if (add.ShowDialog() == DialogResult.OK)
                {
                    logic.GetNhanVien();
                }
            }
            else
            {
                Application.OpenForms["fadd_nhanvien"].Activate();
            }
        }

        private void btn_searchNhanVien_Click(object sender, EventArgs e)
        {
            string searchTerm = txt_searchNhanVien.Text.Trim();
            DataTable dt;

            if (string.IsNullOrEmpty(searchTerm))
            {
                dt = logic.GetNhanVien();
            }
            else
            {
                dt = logic.SearchNhanVien(searchTerm);
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView_nhanvien.DataSource = dt;
                dataGridView_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_nhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView_nhanvien.DefaultCellStyle.Font = new Font("Arial", 12);
                dataGridView_nhanvien.DefaultCellStyle.Padding = new Padding(6);
            }
            else if (dt == null)
            {
                MessageBox.Show("Có lỗi trong quá trình tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
