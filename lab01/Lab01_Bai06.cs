using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giá trị A và B!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int A = Convert.ToInt32(txtA.Text);
            int B = Convert.ToInt32(txtB.Text);
            string luaChon = cboLuaChon.SelectedItem.ToString();

            rtbKetQua.Clear();


            if (luaChon == "Bảng cửu chương")
            {
                int giaTriBCC = B - A;
                rtbKetQua.AppendText($"Bảng cửu chương của {giaTriBCC}:\n");

                for (int i = 1; i <= 10; i++)
                {
                    rtbKetQua.AppendText($"{giaTriBCC} x {i} = {giaTriBCC * i}\n");
                }
            }
            else if (luaChon == "Tính toán giá trị")
            {

                int hieu = A - B;
                if (hieu < 0)
                {
                    rtbKetQua.AppendText($"(A - B)! = ({A} - {B})! : Không tính được giai thừa cho số âm.\n");
                }
                else
                {
                    long giaiThua = 1;
                    for (int i = 1; i <= hieu; i++)
                    {
                        giaiThua *= i;
                    }
                    rtbKetQua.AppendText($"(A - B)! = {hieu}! = {giaiThua}\n");
                }


                long tongS = 0;
                for (int i = 1; i <= B; i++)
                {
                    tongS += (long)Math.Pow(A, i);
                }
                rtbKetQua.AppendText($"\nTổng S = {tongS}\n");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            rtbKetQua.Clear();


            if (cboLuaChon.Items.Count > 0)
            {
                cboLuaChon.SelectedIndex = 0;
            }

            txtA.Focus();
        }

        private void Lab01_Bai06_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
