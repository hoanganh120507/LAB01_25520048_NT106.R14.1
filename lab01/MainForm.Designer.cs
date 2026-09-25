namespace lab01
{
    partial class MainForm
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
            btnBai0 = new Button();
            btnBai2 = new Button();
            btnBai1 = new Button();
            btnBai3 = new Button();
            btnBai4 = new Button();
            btnBai5 = new Button();
            SuspendLayout();
            // 
            // btnBai0
            // 
            btnBai0.Location = new Point(102, 47);
            btnBai0.Name = "btnBai0";
            btnBai0.Size = new Size(114, 29);
            btnBai0.TabIndex = 0;
            btnBai0.Text = "Bài 0";
            btnBai0.UseVisualStyleBackColor = true;
            btnBai0.Click += btnBai0_Click;
            // 
            // btnBai2
            // 
            btnBai2.Location = new Point(102, 167);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(114, 29);
            btnBai2.TabIndex = 1;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = true;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai1
            // 
            btnBai1.Location = new Point(386, 47);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(117, 29);
            btnBai1.TabIndex = 2;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += btnBai1_Click;
            // 
            // btnBai3
            // 
            btnBai3.Location = new Point(386, 167);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(128, 29);
            btnBai3.TabIndex = 3;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = true;
            btnBai3.Click += btnBai3_Click;
            // 
            // btnBai4
            // 
            btnBai4.Location = new Point(102, 276);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(114, 29);
            btnBai4.TabIndex = 4;
            btnBai4.Text = "Bài 4";
            btnBai4.UseVisualStyleBackColor = true;
            btnBai4.Click += btnBai4_Click;
            // 
            // btnBai5
            // 
            btnBai5.Location = new Point(386, 272);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(133, 29);
            btnBai5.TabIndex = 5;
            btnBai5.Text = "Bài 5";
            btnBai5.UseVisualStyleBackColor = true;
            btnBai5.Click += btnBai5_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBai5);
            Controls.Add(btnBai4);
            Controls.Add(btnBai3);
            Controls.Add(btnBai1);
            Controls.Add(btnBai2);
            Controls.Add(btnBai0);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBai0;
        private Button btnBai2;
        private Button btnBai1;
        private Button btnBai3;
        private Button btnBai4;
        private Button btnBai5;
       
    }
}