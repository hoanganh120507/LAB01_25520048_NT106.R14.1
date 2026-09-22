namespace lab01
{
    public partial class Lab01_Bai00 : Form
    {
        public Lab01_Bai00()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtSo1.Text, out long so1) && long.TryParse(txtSo2.Text, out long so2))
            {
           
                long tong = so1 + so2;
               
                txtTong.Text = tong.ToString();
            }
            else
            {
        
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
