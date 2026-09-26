namespace lab01
{
    partial class Lab01_Bai09
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNhapMonAn = new Label();
            txtMonAn = new TextBox();
            btnThem = new Button();
            rtbDanhSachMonAn = new RichTextBox();
            btnTimMonAn = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblKetQua = new Label();
            txtKetQua = new TextBox();
            SuspendLayout();

            lblNhapMonAn.AutoSize = true;
            lblNhapMonAn.Location = new Point(30, 30);
            lblNhapMonAn.Name = "lblNhapMonAn";
            lblNhapMonAn.Size = new Size(101, 20);
            lblNhapMonAn.TabIndex = 0;
            lblNhapMonAn.Text = "Nhập món ăn:";

            txtMonAn.Location = new Point(135, 27);
            txtMonAn.Name = "txtMonAn";
            txtMonAn.Size = new Size(200, 27);
            txtMonAn.TabIndex = 1;

            btnThem.Location = new Point(235, 65);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            rtbDanhSachMonAn.Location = new Point(365, 27);
            rtbDanhSachMonAn.Name = "rtbDanhSachMonAn";
            rtbDanhSachMonAn.ReadOnly = true;
            rtbDanhSachMonAn.Size = new Size(260, 170);
            rtbDanhSachMonAn.TabIndex = 3;
            rtbDanhSachMonAn.Text = "";

            btnTimMonAn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimMonAn.Location = new Point(45, 220);
            btnTimMonAn.Name = "btnTimMonAn";
            btnTimMonAn.Size = new Size(150, 38);
            btnTimMonAn.TabIndex = 4;
            btnTimMonAn.Text = "Tìm món ăn";
            btnTimMonAn.UseVisualStyleBackColor = true;
            btnTimMonAn.Click += btnTimMonAn_Click;

            btnXoa.Location = new Point(275, 220);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 38);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            btnThoat.Location = new Point(495, 220);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 38);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;

            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(245, 285);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(160, 20);
            lblKetQua.TabIndex = 7;
            lblKetQua.Text = "Món ăn hôm nay ăn là:";

            txtKetQua.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKetQua.ForeColor = Color.DarkBlue;
            txtKetQua.Location = new Point(185, 312);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(280, 31);
            txtKetQua.TabIndex = 8;
            txtKetQua.TextAlign = HorizontalAlignment.Center;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 370);
            Controls.Add(txtKetQua);
            Controls.Add(lblKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTimMonAn);
            Controls.Add(rtbDanhSachMonAn);
            Controls.Add(btnThem);
            Controls.Add(txtMonAn);
            Controls.Add(lblNhapMonAn);
            Name = "Lab01_Bai09";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 09 - Hôm nay ăn gì?";
            Load += Lab01_Bai09_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapMonAn;
        private TextBox txtMonAn;
        private Button btnThem;
        private RichTextBox rtbDanhSachMonAn;
        private Button btnTimMonAn;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblKetQua;
        private TextBox txtKetQua;
    }
}