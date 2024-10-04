﻿using System;
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
    public partial class test : Form
    {
        private BusinessLogic dbManager = new BusinessLogic();  
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isConnected = dbManager.CheckConnection();

            if (isConnected)
            {
                MessageBox.Show("Kết nối thành công!");
                fDangNhap mainForm = new fDangNhap();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Kết nối thất bại!");
            }
        }
    }
}
