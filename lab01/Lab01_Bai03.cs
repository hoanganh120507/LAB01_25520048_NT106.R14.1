using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSo.Text, out int n) && n >= 0 && n <= 9)
            {
                string ketQua = "";
                switch (n)
                {
                    case 0: ketQua = "Không"; break;
                    case 1: ketQua = "Một"; break;
                    case 2: ketQua = "Hai"; break;
                    case 3: ketQua = "Ba"; break;
                    case 4: ketQua = "Bốn"; break;
                    case 5: ketQua = "Năm"; break;
                    case 6: ketQua = "Sáu"; break;
                    case 7: ketQua = "Bảy"; break;
                    case 8: ketQua = "Tám"; break;
                    case 9: ketQua = "Chín"; break;
                }
                txtKetQua.Text = ketQua;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên trong khoảng 0 - 9!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            txtKetQua.Clear();
            txtSo.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
