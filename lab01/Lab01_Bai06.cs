using System;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void Lab01_Bai06_Load(object sender, EventArgs e)
        {
            // Tự động thêm các lựa chọn vào ComboBox khi mở Form
            cboLuaChon.Items.Clear();
            cboLuaChon.Items.Add("Bảng cửu chương");
            cboLuaChon.Items.Add("Tính toán giá trị");
            cboLuaChon.SelectedIndex = 0; // Chọn sẵn dòng đầu tiên
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giá trị A và B!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtA.Text, out int A) || !int.TryParse(txtB.Text, out int B))
            {
                MessageBox.Show("Vui lòng nhập giá trị số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboLuaChon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức năng tính toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string luaChon = cboLuaChon.SelectedItem.ToString();
            rtbKetQua.Clear();

            if (luaChon == "Bảng cửu chương")
            {
                int giaTriBCC = B - A;
                rtbKetQua.AppendText($"Bảng cửu chương của {giaTriBCC}:\n\n");

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}