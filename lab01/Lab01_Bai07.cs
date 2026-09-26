using System;
using System.Windows.Forms;

namespace lab01
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void btnXacDinh_Click(object sender, EventArgs e)
        {
            int day = dtpNgaySinh.Value.Day;
            int month = dtpNgaySinh.Value.Month;

            string cungHoangDao = "";

            // Xử lý logic switch-case theo từng tháng sinh
            switch (month)
            {
                case 1:
                    cungHoangDao = (day <= 20) ? "Ma Kết" : "Bảo Bình";
                    break;
                case 2:
                    cungHoangDao = (day <= 19) ? "Bảo Bình" : "Song Ngư";
                    break;
                case 3:
                    cungHoangDao = (day <= 20) ? "Song Ngư" : "Bạch Dương";
                    break;
                case 4:
                    cungHoangDao = (day <= 20) ? "Bạch Dương" : "Kim Ngưu";
                    break;
                case 5:
                    cungHoangDao = (day <= 21) ? "Kim Ngưu" : "Song Tử";
                    break;
                case 6:
                    cungHoangDao = (day <= 21) ? "Song Tử" : "Cự Giải";
                    break;
                case 7:
                    cungHoangDao = (day <= 22) ? "Cự Giải" : "Sư Tử";
                    break;
                case 8:
                    cungHoangDao = (day <= 22) ? "Sư Tử" : "Xử Nữ";
                    break;
                case 9:
                    cungHoangDao = (day <= 23) ? "Xử Nữ" : "Thiên Bình";
                    break;
                case 10:
                    cungHoangDao = (day <= 23) ? "Thiên Bình" : "Thần Nông";
                    break;
                case 11:
                    cungHoangDao = (day <= 22) ? "Thần Nông" : "Nhân Mã";
                    break;
                case 12:
                    cungHoangDao = (day <= 21) ? "Nhân Mã" : "Ma Kết";
                    break;
            }

            txtCungHoangDao.Text = cungHoangDao;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}