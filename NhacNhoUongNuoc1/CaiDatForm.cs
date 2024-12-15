using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NhacNhoUongNuoc1
{

    public partial class CaiDatForm : Form
    {
       
        
        public int NuocDaUong = 0;
        private int soPhut;
        private const int NuocUongVao = 200;
        private int MaxNuoc = int.Parse(Form1.SaveDataNuoc);
        private Timer timer;
        
        public CaiDatForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += timer3_Tick;
            pcb_MucTieuCaiDat.Minimum = 0;
            pcb_MucTieuCaiDat.Maximum = MaxNuoc;
            pcb_MucTieuCaiDat.Value = NuocDaUong;
        }

        private void CaiDatForm_Load_1(object sender, EventArgs e)
        {
            int NuocDaUong = 0;
            txt_NuocCaiDat.Text = Form1.SaveDataNuoc;//string
            NuocDaUong = pcb_MucTieuCaiDat.Value;
        }

        private void ckb_tuDong_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckb_tuDong.Checked)
                ckb_thuCong.Checked = false;
            numThoiGian.Enabled = !ckb_tuDong.Checked;
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            NuocDaUong = 0;
            pcb_MucTieuCaiDat.Value = NuocDaUong;
            if (ckb_tuDong.Checked)//chế độ tự động
            {
                timer3.Interval = 3600000;
                timer3.Start();
                MessageBox.Show("Đã thiết lập chế độ nhắc nhở sau mỗi giờ!!!!", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (ckb_thuCong.Checked && numThoiGian.Value > 0)
                {
                    int soPhut = (int)numThoiGian.Value;
                    MessageBox.Show("Đã thiết lập chế độ nhắc nhở thủ công", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuocDaUong = 0;
                    timer3.Interval = soPhut * 60*1000;
                    timer3.Start();
                }
                else
                {
                    MessageBox.Show("Vui lòng cài đặt thời gian nhắc nhở!!!", "Chú Ý!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            if (!ckb_thuCong.Checked && !ckb_tuDong.Checked)
            {
                MessageBox.Show("Vui lòng chọn 1 chế độ nhắc nhở!!!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ckb_thuCong_CheckedChanged_1(object sender, EventArgs e)
        {
            numThoiGian.Enabled = ckb_thuCong.Checked;

            if (ckb_thuCong.Checked)
            {
                ckb_tuDong.Checked = false;

            }
        }

        public bool IsTuDong { get; private set; } // Lưu trạng thái Tự Động
        public int ThoiGianThuCong { get; private set; } // Thời gian nhắc nhở (thủ công)


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.vinmec.com/vie/bai-viet/khuyen-cao-cua-who-ve-nhu-cau-nuoc-hang-ngay-vi");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            if (NuocDaUong >= MaxNuoc)
            {
                // Dừng Timer nếu đã uống đủ nước
                timer3.Stop();
                MessageBox.Show("Bạn đã uống đủ nước. Không còn nhắc nhở nữa!");
                return;
            }

            if (NuocDaUong < MaxNuoc)
            {
                { // Gửi thông báo nhắc nhở uống nước
                    DialogResult result = MessageBox.Show("Nhớ uống nước nhé!", "Nhắc nhở", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        // Tăng lượng nước đã uống mỗi lần nhấn OK
                        NuocDaUong += NuocUongVao;
                      

                        // Cập nhật giá trị ProgressBar
                        //NuocDaUong = pcb_MucTieuCaiDat.Value; ( Vẫn chưa cập nhật được)
                    }
                }
            }

        }
    }
}

