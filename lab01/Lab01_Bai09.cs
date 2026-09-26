using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai09 : Form
    {
        private List<string> dsMonAn = new List<string>();

        public Lab01_Bai09()
        {
            InitializeComponent();
        }

        private void Lab01_Bai09_Load(object sender, EventArgs e)
        {
            KhoiTaoDanhSachMacDinh();
        }

        private void KhoiTaoDanhSachMacDinh()
        {
            dsMonAn = new List<string>
            {
                "Bún riêu",
                "Bún thịt nướng",
                "Cơm tấm sườn trứng",
                "Phở",
                "Gỏi cuốn"
            };
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            rtbDanhSachMonAn.Clear();
            foreach (string mon in dsMonAn)
            {
                rtbDanhSachMonAn.AppendText(mon + "\n");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string monMoi = txtMonAn.Text.Trim();
            if (string.IsNullOrEmpty(monMoi))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dsMonAn.Add(monMoi);
            HienThiDanhSach();
            txtMonAn.Clear();
            txtMonAn.Focus();
        }

        private void btnTimMonAn_Click(object sender, EventArgs e)
        {
            if (dsMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random rand = new Random();
            int index = rand.Next(0, dsMonAn.Count);
            txtKetQua.Text = dsMonAn[index];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMonAn.Clear();
            txtKetQua.Clear();
            KhoiTaoDanhSachMacDinh();
            txtMonAn.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}