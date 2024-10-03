namespace GUI
{
    partial class fNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_nhanvien = new System.Windows.Forms.DataGridView();
            this.btn_addNhanVien = new System.Windows.Forms.Button();
            this.txt_searchNhanVien = new System.Windows.Forms.TextBox();
            this.btn_searchNhanVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_nhanvien
            // 
            this.dataGridView_nhanvien.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_nhanvien.Location = new System.Drawing.Point(0, 103);
            this.dataGridView_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_nhanvien.Name = "dataGridView_nhanvien";
            this.dataGridView_nhanvien.RowHeadersWidth = 51;
            this.dataGridView_nhanvien.RowTemplate.Height = 24;
            this.dataGridView_nhanvien.Size = new System.Drawing.Size(1451, 649);
            this.dataGridView_nhanvien.TabIndex = 0;
            // 
            // btn_addNhanVien
            // 
            this.btn_addNhanVien.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_addNhanVien.Location = new System.Drawing.Point(1226, 20);
            this.btn_addNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addNhanVien.Name = "btn_addNhanVien";
            this.btn_addNhanVien.Size = new System.Drawing.Size(212, 78);
            this.btn_addNhanVien.TabIndex = 1;
            this.btn_addNhanVien.Text = "Cập nhật";
            this.btn_addNhanVien.UseVisualStyleBackColor = false;
            this.btn_addNhanVien.Click += new System.EventHandler(this.btn_addNhanVien_Click);
            // 
            // txt_searchNhanVien
            // 
            this.txt_searchNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchNhanVien.Location = new System.Drawing.Point(13, 20);
            this.txt_searchNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_searchNhanVien.Multiline = true;
            this.txt_searchNhanVien.Name = "txt_searchNhanVien";
            this.txt_searchNhanVien.Size = new System.Drawing.Size(509, 77);
            this.txt_searchNhanVien.TabIndex = 2;
            // 
            // btn_searchNhanVien
            // 
            this.btn_searchNhanVien.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_searchNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchNhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_searchNhanVien.Location = new System.Drawing.Point(544, 20);
            this.btn_searchNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_searchNhanVien.Name = "btn_searchNhanVien";
            this.btn_searchNhanVien.Size = new System.Drawing.Size(212, 78);
            this.btn_searchNhanVien.TabIndex = 3;
            this.btn_searchNhanVien.Text = "Search";
            this.btn_searchNhanVien.UseVisualStyleBackColor = false;
            this.btn_searchNhanVien.Click += new System.EventHandler(this.btn_searchNhanVien_Click);
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 752);
            this.Controls.Add(this.btn_searchNhanVien);
            this.Controls.Add(this.txt_searchNhanVien);
            this.Controls.Add(this.btn_addNhanVien);
            this.Controls.Add(this.dataGridView_nhanvien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fNhanVien";
            this.Text = "fQuanLyNhanVien";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_nhanvien;
        private System.Windows.Forms.Button btn_addNhanVien;
        private System.Windows.Forms.TextBox txt_searchNhanVien;
        private System.Windows.Forms.Button btn_searchNhanVien;
    }
}