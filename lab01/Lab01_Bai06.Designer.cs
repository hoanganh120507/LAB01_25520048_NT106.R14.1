namespace lab01
{
    partial class Lab01_Bai06
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
            txtA = new TextBox();
            txtB = new TextBox();
            cboLuaChon = new ComboBox();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            rtbKetQua = new RichTextBox();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(121, 82);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 0;
            txtA.TextChanged += textBox1_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(473, 82);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 1;
            // 
            // cboLuaChon
            // 
            cboLuaChon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLuaChon.FormattingEnabled = true;
            cboLuaChon.Location = new Point(269, 158);
            cboLuaChon.Name = "cboLuaChon";
            cboLuaChon.Size = new Size(151, 28);
            cboLuaChon.TabIndex = 3;
            cboLuaChon.SelectedIndexChanged += cboLuaChon_SelectedIndexChanged;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(121, 282);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(305, 282);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(504, 282);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // rtbKetQua
            // 
            rtbKetQua.Location = new Point(121, 334);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.Size = new Size(477, 120);
            rtbKetQua.TabIndex = 7;
            rtbKetQua.Text = "";
            // 
            // Lab01_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(cboLuaChon);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "Lab01_Bai06";
            Text = "Lab01_Bai06";
            Load += Lab01_Bai06_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private ComboBox cboLuaChon;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
        private RichTextBox rtbKetQua;
    }
}