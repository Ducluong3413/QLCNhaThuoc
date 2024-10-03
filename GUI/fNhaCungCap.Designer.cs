namespace GUI
{
    partial class fNhaCungCap
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
            this.dataGridView_nhacungcap = new System.Windows.Forms.DataGridView();
            this.btn_searchNhaCungCap = new System.Windows.Forms.Button();
            this.txt_searchNhaCungCap = new System.Windows.Forms.TextBox();
            this.btn_addNhaCungCap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_nhacungcap
            // 
            this.dataGridView_nhacungcap.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView_nhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhacungcap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_nhacungcap.Location = new System.Drawing.Point(0, 103);
            this.dataGridView_nhacungcap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_nhacungcap.Name = "dataGridView_nhacungcap";
            this.dataGridView_nhacungcap.RowHeadersWidth = 51;
            this.dataGridView_nhacungcap.RowTemplate.Height = 24;
            this.dataGridView_nhacungcap.Size = new System.Drawing.Size(1451, 649);
            this.dataGridView_nhacungcap.TabIndex = 1;
            // 
            // btn_searchNhaCungCap
            // 
            this.btn_searchNhaCungCap.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_searchNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_searchNhaCungCap.Location = new System.Drawing.Point(541, 21);
            this.btn_searchNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_searchNhaCungCap.Name = "btn_searchNhaCungCap";
            this.btn_searchNhaCungCap.Size = new System.Drawing.Size(212, 78);
            this.btn_searchNhaCungCap.TabIndex = 6;
            this.btn_searchNhaCungCap.Text = "Search";
            this.btn_searchNhaCungCap.UseVisualStyleBackColor = false;
            this.btn_searchNhaCungCap.Click += new System.EventHandler(this.btn_searchNhaCungCap_Click);
            // 
            // txt_searchNhaCungCap
            // 
            this.txt_searchNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchNhaCungCap.Location = new System.Drawing.Point(13, 21);
            this.txt_searchNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_searchNhaCungCap.Multiline = true;
            this.txt_searchNhaCungCap.Name = "txt_searchNhaCungCap";
            this.txt_searchNhaCungCap.Size = new System.Drawing.Size(509, 77);
            this.txt_searchNhaCungCap.TabIndex = 5;
            // 
            // btn_addNhaCungCap
            // 
            this.btn_addNhaCungCap.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_addNhaCungCap.Location = new System.Drawing.Point(1239, 20);
            this.btn_addNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addNhaCungCap.Name = "btn_addNhaCungCap";
            this.btn_addNhaCungCap.Size = new System.Drawing.Size(212, 78);
            this.btn_addNhaCungCap.TabIndex = 4;
            this.btn_addNhaCungCap.Text = "Cập nhật";
            this.btn_addNhaCungCap.UseVisualStyleBackColor = false;
            this.btn_addNhaCungCap.Click += new System.EventHandler(this.btn_addNhaCungCap_Click);
            // 
            // fNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 752);
            this.Controls.Add(this.btn_searchNhaCungCap);
            this.Controls.Add(this.txt_searchNhaCungCap);
            this.Controls.Add(this.btn_addNhaCungCap);
            this.Controls.Add(this.dataGridView_nhacungcap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fNhaCungCap";
            this.Text = "fNhaCungCap";
            this.Load += new System.EventHandler(this.fNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhacungcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_nhacungcap;
        private System.Windows.Forms.Button btn_searchNhaCungCap;
        private System.Windows.Forms.TextBox txt_searchNhaCungCap;
        private System.Windows.Forms.Button btn_addNhaCungCap;
    }
}