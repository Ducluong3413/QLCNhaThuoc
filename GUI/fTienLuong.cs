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
    public partial class fTienLuong : Form
    {
        private BusinessLogic luongBusiness = new BusinessLogic();
        private DataTable dtLuong; 
        public fTienLuong()
        {
            InitializeComponent();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // Lấy dữ liệu từ bảng luong thông qua tầng BLL
            dtLuong = luongBusiness.GetLuong();

            // Gán dữ liệu vào DataGridView
            if (dtLuong != null && dtLuong.Rows.Count > 0)
            {
                // Gán dữ liệu từ biến dtLuong vào DataGridView
                dataGridView1.DataSource = dtLuong;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Hiển thị tháng và năm hiện tại trên Label
            label1.Text = now.ToString("MM/yyyy");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
