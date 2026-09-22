using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            long so1, so2;

            
            if (!long.TryParse(txtSo1.Text, out so1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                txtSo1.Focus(); 
                txtSo1.SelectAll();
                return; 
            }

            
            if (!long.TryParse(txtSo2.Text, out so2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                txtSo2.Focus(); 
                txtSo2.SelectAll();
                return; 
            }

           
            long tong = so1 + so2;
            txtKetQua.Text = tong.ToString();
        }
    }
}
