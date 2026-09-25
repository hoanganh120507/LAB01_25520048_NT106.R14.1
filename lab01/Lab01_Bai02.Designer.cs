namespace lab01
{
    partial class Lab01_Bai02
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtSo3 = new TextBox();
            txtMax = new TextBox();
            txtMin = new TextBox();
            btnTim = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 108);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Số Thứ Nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 108);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Số Thứ Hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(686, 108);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Số Thứ Ba";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 341);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Lớn Nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 341);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Số Nhỏ Nhất";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(189, 105);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(125, 27);
            txtSo1.TabIndex = 5;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(474, 108);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(125, 27);
            txtSo2.TabIndex = 6;
            // 
            // txtSo3
            // 
            txtSo3.Location = new Point(768, 108);
            txtSo3.Name = "txtSo3";
            txtSo3.Size = new Size(125, 27);
            txtSo3.TabIndex = 7;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(246, 334);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(125, 27);
            txtMax.TabIndex = 8;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(667, 334);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(125, 27);
            txtMin.TabIndex = 9;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(233, 227);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 10;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(432, 227);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(634, 227);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 572);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtSo3);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai02";
            Text = "Lab01_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private TextBox txtSo3;
        private TextBox txtMax;
        private TextBox txtMin;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
    }
}