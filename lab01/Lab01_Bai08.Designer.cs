namespace lab01
{
    partial class Lab01_Bai08
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
            lblInput = new Label();
            txtInput = new TextBox();
            btnXuLy = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            rtbKetQua = new RichTextBox();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(30, 25);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(160, 20);
            lblInput.TabIndex = 0;
            lblInput.Text = "Nhập thông tin sinh viên:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(30, 50);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(590, 27);
            txtInput.TabIndex = 1;
            txtInput.Text = "Nguyễn Thị A, 7.5, 5, 8, 10, 9, 10, 8.5, 9, 10, 3.5, 5.5, 2";
            // 
            // btnXuLy
            // 
            btnXuLy.Location = new Point(30, 90);
            btnXuLy.Name = "btnXuLy";
            btnXuLy.Size = new Size(110, 32);
            btnXuLy.TabIndex = 2;
            btnXuLy.Text = "Xử lý";
            btnXuLy.UseVisualStyleBackColor = true;
            btnXuLy.Click += btnXuLy_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(160, 90);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 32);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(280, 90);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 32);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(30, 135);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(125, 20);
            lblKetQua.TabIndex = 5;
            lblKetQua.Text = "Kết quả xử lý:";
            // 
            // rtbKetQua
            // 
            rtbKetQua.Location = new Point(30, 160);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.ReadOnly = true;
            rtbKetQua.Size = new Size(590, 260);
            rtbKetQua.TabIndex = 6;
            rtbKetQua.Text = "";
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 445);
            Controls.Add(rtbKetQua);
            Controls.Add(lblKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnXuLy);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Name = "Lab01_Bai08";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 08 - Xử lý mảng (Thông tin Sinh Viên)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private Button btnXuLy;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblKetQua;
        private RichTextBox rtbKetQua;
    }
}