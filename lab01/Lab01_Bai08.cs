using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string[] parts = input.Split(',');

            
            if (parts.Length < 2)
            {
                MessageBox.Show("Nhập sai format! Cần nhập tên sinh viên và ít nhất 1 điểm số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hoTen = parts[0].Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Nhập sai format! Họ tên không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<double> diemList = new List<double>();

           
            for (int i = 1; i < parts.Length; i++)
            {
                string strDiem = parts[i].Trim();
                if (double.TryParse(strDiem, NumberStyles.Any, CultureInfo.InvariantCulture, out double diem))
                {
                    if (diem < 0 || diem > 10)
                    {
                        MessageBox.Show($"Nhập sai format! Điểm '{strDiem}' phải nằm trong khoảng từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    diemList.Add(diem);
                }
                else
                {
                    MessageBox.Show($"Nhập sai format! Giá trị '{strDiem}' không phải là điểm số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

           
            MessageBox.Show("Đã nhập đúng format!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
            rtbKetQua.Clear();
            rtbKetQua.AppendText($"Họ và tên: {hoTen}\n\n");

            
            rtbKetQua.AppendText("Danh sách điểm:\n");
            for (int i = 0; i < diemList.Count; i++)
            {
                rtbKetQua.AppendText($"Môn {i + 1}: {diemList[i]}    ");
            }
            rtbKetQua.AppendText("\n\n");

            
            double dtb = diemList.Average();
            double maxDiem = diemList.Max();
            double minDiem = diemList.Min();
            int soMonDau = diemList.Count(d => d >= 5);
            int soMonKhongDau = diemList.Count(d => d < 5);

           
            string xepLoai = "";
            if (dtb >= 8.0 && minDiem >= 6.5)
                xepLoai = "Giỏi";
            else if (dtb >= 6.5 && minDiem >= 5.0)
                xepLoai = "Khá";
            else if (dtb >= 5.0 && minDiem >= 3.5)
                xepLoai = "Trung bình";
            else if (dtb >= 3.5 && minDiem >= 2.0)
                xepLoai = "Yếu";
            else
                xepLoai = "Kém";

           
            rtbKetQua.AppendText($"Điểm Trung bình: {Math.Round(dtb, 2)}\n");
            rtbKetQua.AppendText($"Môn điểm cao nhất: {maxDiem}\n");
            rtbKetQua.AppendText($"Môn điểm thấp nhất: {minDiem}\n");
            rtbKetQua.AppendText($"Số môn đậu: {soMonDau}\n");
            rtbKetQua.AppendText($"Số môn không đậu: {soMonKhongDau}\n");
            rtbKetQua.AppendText($"Xếp loại sinh viên: {xepLoai}\n");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            rtbKetQua.Clear();
            txtInput.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}