namespace lab01
{
    partial class Lab01_Bai00
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtTong = new TextBox();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(252, 50);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 135);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 186);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Số thứ hai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(106, 309);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 3;
            label4.Text = "TỔNG";
            label4.Click += label4_Click;
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(311, 128);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(125, 27);
            txtSo1.TabIndex = 4;
            txtSo1.TextChanged += textBox1_TextChanged;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(311, 179);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(125, 27);
            txtSo2.TabIndex = 5;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(311, 309);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(125, 27);
            txtTong.TabIndex = 6;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(106, 253);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(330, 29);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTinh);
            Controls.Add(txtTong);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private TextBox txtTong;
        private Button btnTinh;
    }
}
