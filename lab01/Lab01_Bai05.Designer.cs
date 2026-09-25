namespace lab01
{
    partial class Lab01_Bai05
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
            txtHoTen = new TextBox();
            cboPhim = new ComboBox();
            cboPhong = new ComboBox();
            clbGhe = new CheckedListBox();
            rtbKetQua = new RichTextBox();
            btnThanhToan = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(12, 45);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 0;
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(12, 122);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(151, 28);
            cboPhim.TabIndex = 1;
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            // 
            // cboPhong
            // 
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(12, 192);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(151, 28);
            cboPhong.TabIndex = 2;
            cboPhong.SelectedIndexChanged += cboPhong_SelectedIndexChanged;
            // 
            // clbGhe
            // 
            clbGhe.FormattingEnabled = true;
            clbGhe.Location = new Point(12, 262);
            clbGhe.Name = "clbGhe";
            clbGhe.Size = new Size(150, 114);
            clbGhe.TabIndex = 3;
            // 
            // rtbKetQua
            // 
            rtbKetQua.Location = new Point(12, 431);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.Size = new Size(125, 120);
            rtbKetQua.TabIndex = 4;
            rtbKetQua.Text = "";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(505, 85);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(505, 192);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(505, 318);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnXoa_Click;
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 707);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThanhToan);
            Controls.Add(rtbKetQua);
            Controls.Add(clbGhe);
            Controls.Add(cboPhong);
            Controls.Add(cboPhim);
            Controls.Add(txtHoTen);
            Name = "Lab01_Bai05";
            Text = "Lab01_Bai05";
            Load += Lab01_Bai05_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private ComboBox cboPhim;
        private ComboBox cboPhong;
        private CheckedListBox clbGhe;
        private RichTextBox rtbKetQua;
        private Button btnThanhToan;
        private Button btnXoa;
        private Button btnThoat;
    }
}
