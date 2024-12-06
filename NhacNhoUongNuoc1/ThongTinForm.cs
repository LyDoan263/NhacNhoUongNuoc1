using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NhacNhoUongNuoc1
{
    public partial class ThongTinForm : Form
    {

        private Timer nhacNhoTimer;
        private double tongNuocCanUong; // Tổng lượng nước cần uống
        private double nuocDaUong = 0;
        private NguoiDung nguoiDung;

        public ThongTinForm(NguoiDung nguoiDung)
        {

            InitializeComponent();
            nhacNhoTimer = new Timer();
            nhacNhoTimer.Tick += NhacNhoTimer_Tick; // Gắn sự kiện Tick để xử lý logic khi Timer đến giờ
            this.nguoiDung = nguoiDung;
            HienThiThongTin();
        }
        private void HienThiThongTin()
        {
            lblTen.Text = nguoiDung.Ten;
            lblTuoi.Text = nguoiDung.Tuoi.ToString();
            lblCanNang.Text = nguoiDung.CanNang.ToString("F2") + " kg";
            lblChieuCao.Text = nguoiDung.ChieuCao.ToString("F2") + " cm";
            lblLitNuoc.Text = nguoiDung.LitNuoc.ToString("0.00");
        }
        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            CaiDatForm caiDatForm = new CaiDatForm();
            if (caiDatForm.ShowDialog() == DialogResult.OK)
            {
                if (caiDatForm.IsTuDong)
                {
                    // Kích hoạt nhắc nhở tự động mỗi giờ
                    nhacNhoTimer.Interval = 60000; // 1 giờ = 3600000 ms
                    nhacNhoTimer.Start();
                    MessageBox.Show("Đã bật chế độ nhắc nhở tự động sau mỗi giờ!", "Thông Báo");
                }
                else
                {
                    // Kích hoạt nhắc nhở thủ công với thời gian được thiết lập
                    nhacNhoTimer.Interval = caiDatForm.ThoiGianThuCong * 60000; // Convert phút sang ms
                    nhacNhoTimer.Start();
                    MessageBox.Show($"Đã bật chế độ nhắc nhở thủ công mỗi {caiDatForm.ThoiGianThuCong} phút!", "Thông Báo");
                }
            }
        }
        private void NhacNhoTimer_Tick(object sender, EventArgs e)
        {
            // Mã thực hiện mỗi khi Timer "tick" (đến giờ)
            MessageBox.Show("Đã đến giờ uống nước!", "Nhắc nhở", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            System.Diagnostics.Process.Start("IExplore", "https://www.vinmec.com/vie/bai-viet/khuyen-cao-cua-who-ve-nhu-cau-nuoc-hang-ngay-vi");

        }
    }
}