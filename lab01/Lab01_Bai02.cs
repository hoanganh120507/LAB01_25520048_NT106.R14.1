using System;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;

            bool isNum1Valid = double.TryParse(txtSo1.Text, out num1);
            bool isNum2Valid = double.TryParse(txtSo2.Text, out num2);
            bool isNum3Valid = double.TryParse(txtSo3.Text, out num3);

            if (!isNum1Valid || !isNum2Valid || !isNum3Valid)
            {
                MessageBox.Show("Vui lòng nhập đúng số vào cả 3 ô!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            double min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }

            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtSo3.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtSo1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}