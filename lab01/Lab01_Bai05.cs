using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai05 : Form
    {
        private class PhimInfo
        {
            public double GiaChuan { get; set; }
            public List<int> PhongChieu { get; set; }

            public PhimInfo(double gia, List<int> phong)
            {
                GiaChuan = gia;
                PhongChieu = phong;
            }
        }

        private Dictionary<string, PhimInfo> dsPhim = new Dictionary<string, PhimInfo>();
        private Dictionary<string, double> heSoGiaGhe = new Dictionary<string, double>();
        private Dictionary<int, List<string>> veDaBanTheoPhong = new Dictionary<int, List<string>>();

        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void Lab01_Bai05_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            HienThiDanhSachGhe();
        }

        private void KhoiTaoDuLieu()
        {
            dsPhim.Add("Đào, phở và piano", new PhimInfo(45000, new List<int> { 1, 2, 3 }));
            dsPhim.Add("Mai", new PhimInfo(100000, new List<int> { 2, 3 }));
            dsPhim.Add("Gặp lại chị bầu", new PhimInfo(70000, new List<int> { 1 }));
            dsPhim.Add("Tarot", new PhimInfo(90000, new List<int> { 3 }));

            cboPhim.DataSource = dsPhim.Keys.ToList();

            for (int i = 1; i <= 3; i++)
            {
                veDaBanTheoPhong[i] = new List<string>();
            }

            heSoGiaGhe["A1"] = 0.25; heSoGiaGhe["A5"] = 0.25;
            heSoGiaGhe["C1"] = 0.25; heSoGiaGhe["C5"] = 0.25;

            heSoGiaGhe["B2"] = 2.0; heSoGiaGhe["B3"] = 2.0; heSoGiaGhe["B4"] = 2.0;

            heSoGiaGhe["A2"] = 1.0; heSoGiaGhe["A3"] = 1.0; heSoGiaGhe["A4"] = 1.0;
            heSoGiaGhe["B1"] = 1.0; heSoGiaGhe["B5"] = 1.0;
            heSoGiaGhe["C2"] = 1.0; heSoGiaGhe["C3"] = 1.0; heSoGiaGhe["C4"] = 1.0;
        }

        private void HienThiDanhSachGhe()
        {
            clbGhe.Items.Clear();
            foreach (var ghe in heSoGiaGhe.Keys)
            {
                clbGhe.Items.Add(ghe);
            }
        }

        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhim.SelectedItem == null) return;

            string tenPhim = cboPhim.SelectedItem.ToString()!;
            PhimInfo phim = dsPhim[tenPhim];

            cboPhong.DataSource = phim.PhongChieu.ToList();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTrangThaiGhe();
        }

        private void CapNhatTrangThaiGhe()
        {
            if (cboPhong.SelectedItem == null) return;

            for (int i = 0; i < clbGhe.Items.Count; i++)
            {
                clbGhe.SetItemChecked(i, false);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboPhim.SelectedItem == null || cboPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbGhe.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenKhach = txtHoTen.Text.Trim();
            string tenPhim = cboPhim.SelectedItem.ToString()!;
            int phong = Convert.ToInt32(cboPhong.SelectedItem);
            double giaChuan = dsPhim[tenPhim].GiaChuan;

            List<string> dsGheChon = clbGhe.CheckedItems.Cast<string>().ToList();
            List<string> dsGheDaBan = veDaBanTheoPhong[phong];

            foreach (string ghe in dsGheChon)
            {
                if (dsGheDaBan.Contains(ghe))
                {
                    MessageBox.Show($"Ghế {ghe} ở phòng {phong} đã được bán trước đó! Vui lòng chọn ghế khác.", "Lỗi chọn ghế", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            double tongTien = 0;
            foreach (string ghe in dsGheChon)
            {
                tongTien += giaChuan * heSoGiaGhe[ghe];
            }

            dsGheDaBan.AddRange(dsGheChon);

            rtbKetQua.Clear();
            rtbKetQua.AppendText("================ HÓA ĐƠN ĐẶT VÉ ================\n");
            rtbKetQua.AppendText($"Họ và tên khách hàng: {tenKhach}\n");
            rtbKetQua.AppendText($"Tên phim: {tenPhim}\n");
            rtbKetQua.AppendText($"Phòng chiếu: Phòng {phong}\n");
            rtbKetQua.AppendText($"Vé đã chọn: {string.Join(", ", dsGheChon)}\n");
            rtbKetQua.AppendText($"Tổng số tiền phải thanh toán: {tongTien:N0} VNĐ\n");
            rtbKetQua.AppendText("================================================\n");

            MessageBox.Show("Thanh toán và mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            rtbKetQua.Clear();
            if (cboPhim.Items.Count > 0) cboPhim.SelectedIndex = 0;
            CapNhatTrangThaiGhe();
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
        }
    }
}