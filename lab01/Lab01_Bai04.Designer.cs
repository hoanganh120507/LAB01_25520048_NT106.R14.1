namespace lab01
{
    partial class Lab01_Bai04
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
            txtSo = new MaskedTextBox();
            txtKetQua = new MaskedTextBox();
            btnDoc = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên (tối đa 12 chữ số)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 252);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Kết quả";
            label2.Click += label2_Click;
            // 
            // txtSo
            // 
            txtSo.Location = new Point(394, 80);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(125, 27);
            txtSo.TabIndex = 2;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(394, 245);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(125, 27);
            txtKetQua.TabIndex = 3;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(617, 98);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(94, 29);
            btnDoc.TabIndex = 4;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(617, 157);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(617, 210);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnDoc);
            Controls.Add(txtKetQua);
            Controls.Add(txtSo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai04";
            Text = "Lab01_Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox txtSo;
        private MaskedTextBox txtKetQua;
        private Button btnDoc;
        private Button btnXoa;
        private Button btnThoat;
    }
}