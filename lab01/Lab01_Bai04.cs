using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string input = txtSo.Text.Trim();

            if (!long.TryParse(input, out long n) || n < 0 || input.Length > 12)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương tối đa 12 chữ số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (n == 0)
            {
                txtKetQua.Text = "Không";
                return;
            }

            txtKetQua.Text = DocSoThanhChu(n);
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


        private string DocSoThanhChu(long number)
        {
            int ty = (int)((number / 1000000000) % 1000);
            int trieu = (int)((number / 1000000) % 1000);
            int ngan = (int)((number / 1000) % 1000);
            int donVi = (int)(number % 1000);

            string ketQua = "";
            bool daCoLopTruoc = false;

            if (ty > 0)
            {
                ketQua += Doc3So(ty, daCoLopTruoc) + " tỷ ";
                daCoLopTruoc = true;
            }

            if (trieu > 0)
            {
                ketQua += Doc3So(trieu, daCoLopTruoc) + " triệu ";
                daCoLopTruoc = true;
            }

            if (ngan > 0)
            {
                ketQua += Doc3So(ngan, daCoLopTruoc) + " ngàn ";
                daCoLopTruoc = true;
            }

            if (donVi > 0)
            {
                ketQua += Doc3So(donVi, daCoLopTruoc);
            }

            ketQua = ketQua.Trim();

            if (!string.IsNullOrEmpty(ketQua))
            {
                ketQua = char.ToUpper(ketQua[0]) + ketQua.Substring(1);
            }

            return ketQua;
        }

        private string Doc3So(int number, bool full)
        {
            string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            int tram = number / 100;
            int chuc = (number % 100) / 10;
            int dv = number % 10;
            string res = "";

            if (tram > 0 || full)
            {
                res += chuSo[tram] + " trăm ";
            }

            if (chuc > 1)
            {
                res += chuSo[chuc] + " mươi ";
                if (dv == 1) res += "mốt";
                else if (dv == 5) res += "lăm";
                else if (dv > 0) res += chuSo[dv];
            }
            else if (chuc == 1)
            {
                res += "mười ";
                if (dv == 5) res += "lăm";
                else if (dv > 0) res += chuSo[dv];
            }
            else
            {
                if (dv > 0)
                {
                    if (tram > 0 || full) res += "lẻ ";
                    res += chuSo[dv];
                }
            }

            return res.Trim();
        }
    } 
} 