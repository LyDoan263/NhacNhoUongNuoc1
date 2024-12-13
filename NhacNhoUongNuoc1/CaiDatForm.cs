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

    public partial class CaiDatForm : Form
    {
        private Timer timeNhacNho;

        public CaiDatForm()
        {
            InitializeComponent();
            timeNhacNho = new Timer();
            timeNhacNho.Interval = 1000;
            timeNhacNho.Tick += TimeNhacNho_Tick;
            timeNhacNho.Start();
            timeNhacNho.Stop();
           

        }

        private void ckb_tuDong_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_tuDong.Checked)
                ckb_thuCong.Checked = false;
            numThoiGian.Enabled = !ckb_tuDong.Checked;
        }

        private void ckb_thuCong_CheckedChanged(object sender, EventArgs e)
        {
            numThoiGian.Enabled = ckb_thuCong.Checked;

            if (ckb_thuCong.Checked)
            {
                ckb_tuDong.Checked = false;

            }
        }
        public bool IsTuDong { get; private set; } // Lưu trạng thái Tự Động
        public int ThoiGianThuCong { get; private set; } // Thời gian nhắc nhở (thủ công)
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            CaiDatForm caiDat = new CaiDatForm();
            if (ckb_tuDong.Checked)//chế độ tự động
            {
                timeNhacNho.Interval = 3600000;
                timeNhacNho.Start();
                MessageBox.Show("Đã thiết lập chế độ nhắc nhở sau mỗi giờ!!!!", "CHÚ Ý",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int soPhut = (int)numThoiGian.Value;//chế độ thủ công
                if (soPhut > 0)
                {
                    timeNhacNho.Tag = soPhut * 60;
                    timeNhacNho.Start();
                    MessageBox.Show("Đã thiết lập chế độ nhắc nhở thủ công", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thời gian để thiết lập nhắc nhở!!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (!ckb_thuCong.Checked && !ckb_tuDong.Checked) {
                MessageBox.Show("Vui lòng chọn 1 chế độ nhắc nhở!!!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        private void TimeNhacNho_Tick(object sender, EventArgs e)//sự kiện tick
        {
            int timeConLai = (int)timeNhacNho.Tag;
            if (timeConLai > 0)
            {
                timeNhacNho.Tag = timeConLai - 1;
            }
            else
            {
                timeNhacNho.Stop();
                MessageBox.Show("Đã tới giờ uống nước","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.vinmec.com/vie/bai-viet/khuyen-cao-cua-who-ve-nhu-cau-nuoc-hang-ngay-vi");
        }

        private void CaiDatForm_Load(object sender, EventArgs e)
        {
            txt_NuocCaiDat.Text = Form1.SaveDataNuoc;
           
            
        }
    } 
}

