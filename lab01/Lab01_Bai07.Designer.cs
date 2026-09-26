namespace lab01
{
    partial class Lab01_Bai07
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
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            btnXacDinh = new Button();
            lblKetQua = new Label();
            txtCungHoangDao = new TextBox();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(40, 40);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(153, 20);
            lblNgaySinh.TabIndex = 0;
            lblNgaySinh.Text = "Chọn ngày tháng năm:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(200, 35);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(180, 27);
            dtpNgaySinh.TabIndex = 1;
            // 
            // btnXacDinh
            // 
            btnXacDinh.Location = new Point(200, 80);
            btnXacDinh.Name = "btnXacDinh";
            btnXacDinh.Size = new Size(95, 32);
            btnXacDinh.TabIndex = 2;
            btnXacDinh.Text = "Xác định";
            btnXacDinh.UseVisualStyleBackColor = true;
            btnXacDinh.Click += btnXacDinh_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(40, 140);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(149, 20);
            lblKetQua.TabIndex = 3;
            lblKetQua.Text = "Cung hoàng đạo là:";
            // 
            // txtCungHoangDao
            // 
            txtCungHoangDao.Location = new Point(200, 137);
            txtCungHoangDao.Name = "txtCungHoangDao";
            txtCungHoangDao.ReadOnly = true;
            txtCungHoangDao.Size = new Size(200, 27);
            txtCungHoangDao.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(305, 80);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 32);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 200);
            Controls.Add(btnThoat);
            Controls.Add(txtCungHoangDao);
            Controls.Add(lblKetQua);
            Controls.Add(btnXacDinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblNgaySinh);
            Name = "Lab01_Bai07";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 07 - Tra cứu Cung Hoàng Đạo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Button btnXacDinh;
        private Label lblKetQua;
        private TextBox txtCungHoangDao;
        private Button btnThoat;
    }
}