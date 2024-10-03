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
    public partial class fNhaCungCap : Form
    {
        private BusinessLogic logic = new BusinessLogic();
        private DataTable dtncc;
        public fNhaCungCap()
        {
            InitializeComponent();
        }

        private void fNhaCungCap_Load(object sender, EventArgs e)
        {
            dtncc = logic.GetNhaCungCap();
            if (dtncc != null && dtncc.Rows.Count > 0)
            {
                dataGridView_nhacungcap.DataSource = dtncc;
                dataGridView_nhacungcap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_nhacungcap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView_nhacungcap.DefaultCellStyle.Font = new Font("Arial", 12);
                dataGridView_nhacungcap.DefaultCellStyle.Padding = new Padding(6);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_addNhaCungCap_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fadd_nhacungcap"] == null)
            {
                 fadd_nhacungcap ncc = new fadd_nhacungcap();
                if (ncc.ShowDialog() == DialogResult.OK)
                {
                    logic.GetNhaCungCap();
                }
            }
            else
            {
                Application.OpenForms["fadd_nhacungcap"].Activate();
            }
        }

        private void btn_searchNhaCungCap_Click(object sender, EventArgs e)
        {
            String searchTerm = txt_searchNhaCungCap.Text.Trim();
            DataTable dt;

    if (string.IsNullOrEmpty(searchTerm))
    {
        dt = logic.GetNhaCungCap(); 
    }
    else
    {
        dt = logic.SearchItemNhaCungCap(searchTerm);
    }

    if (dt != null)
    {
        if (dt.Rows.Count > 0)
        {
            dataGridView_nhacungcap.DataSource = dt;
            dataGridView_nhacungcap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_nhacungcap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_nhacungcap.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView_nhacungcap.DefaultCellStyle.Padding = new Padding(6);
        }
        else
        {
            MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    else
    {
        MessageBox.Show("Có lỗi trong quá trình tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }
    }
}
