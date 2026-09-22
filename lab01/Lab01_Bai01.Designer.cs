namespace lab01
{
    partial class Lab01_Bai01
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
            lblSo1 = new Label();
            lblSo2 = new Label();
            txtKetQua1 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtKetQua = new TextBox();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // lblSo1
            // 
            lblSo1.AutoSize = true;
            lblSo1.Location = new Point(106, 94);
            lblSo1.Name = "lblSo1";
            lblSo1.Size = new Size(64, 20);
            lblSo1.TabIndex = 0;
            lblSo1.Text = "Số thứ 1";
            // 
            // lblSo2
            // 
            lblSo2.AutoSize = true;
            lblSo2.Location = new Point(106, 180);
            lblSo2.Name = "lblSo2";
            lblSo2.Size = new Size(64, 20);
            lblSo2.TabIndex = 1;
            lblSo2.Text = "Số thứ 2";
            lblSo2.Click += label2_Click;
            // 
            // txtKetQua1
            // 
            txtKetQua1.AutoSize = true;
            txtKetQua1.Location = new Point(106, 305);
            txtKetQua1.Name = "txtKetQua1";
            txtKetQua1.Size = new Size(60, 20);
            txtKetQua1.TabIndex = 2;
            txtKetQua1.Text = "Kết quả";
            txtKetQua1.Click += label3_Click;
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(364, 87);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(125, 27);
            txtSo1.TabIndex = 3;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(364, 173);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(125, 27);
            txtSo2.TabIndex = 4;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(364, 298);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(125, 27);
            txtKetQua.TabIndex = 5;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(106, 245);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(383, 29);
            btnTinh.TabIndex = 6;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 545);
            Controls.Add(btnTinh);
            Controls.Add(txtKetQua);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(txtKetQua1);
            Controls.Add(lblSo2);
            Controls.Add(lblSo1);
            Name = "Lab01_Bai01";
            Text = "Lab01_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSo1;
        private Label lblSo2;
        private Label txtKetQua1;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private TextBox txtKetQua;
        private Button btnTinh;
    }
}