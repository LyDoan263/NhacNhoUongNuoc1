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
        private const int NuocUongVao = 200;
        private int MaxNuoc = int.Parse(Form1.SaveDataNuoc);
        private Timer timer;
        public List<string> timeHistory = new List<string>(); 
        
        public CaiDatForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += timer3_Tick;
           
        }

        private void CaiDatForm_Load_1(object sender, EventArgs e)
        {         
            txt_NuocCaiDat.Text = Form1.SaveDataNuoc;//string  
            ckb_thuCong.Checked = Properties.Settings.Default.Savedckb_thuCongValue;
            ckb_tuDong.Checked = Properties.Settings.Default.Savedckb_tuDongValue;
            numThoiGian.Value = Properties.Settings.Default.SavednumThoiGianValue;
            txt_NuocDangUong.Text = Properties.Settings.Default.SavedNuocDangUongValue;
            var savedItems = Properties.Settings.Default.SaveListLichSuValue as string;
            if (!string.IsNullOrEmpty(savedItems))
            {
                timeHistory = savedItems.Split(';').ToList();
                foreach (var time in timeHistory)
                {
                    Label timeLabel = new Label
                    {
                        Text = time,
                        AutoSize = true
                    };
                    flowLayoutPanel1.Controls.Add(timeLabel);
                }
            }
        }
        private void ckb_tuDong_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckb_tuDong.Checked)
                ckb_thuCong.Checked = false;
            numThoiGian.Enabled = !ckb_tuDong.Checked;          
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {        
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

        private Panel notificationPanel;
        private Label lblNotification;
        private System.Windows.Forms.Button btnOK;
        private bool isReminderActive = false;
        private async void timer3_Tick(object sender, EventArgs e)
        {

            if (NuocDaUong >= MaxNuoc)
            {
                timer3.Stop();
                MessageBox.Show("Bạn đã uống đủ nước. Không còn nhắc nhở nữa!");
                return;
            }
            if (NuocDaUong < MaxNuoc && !isReminderActive)
            {
                isReminderActive = true; // Đánh dấu thông báo đang hoạt động
                string timeStamp = DateTime.Now.ToString("HH:mm:ss ddd/MM/yyyy");

                // Hiển thị thông báo
                ShowNotification("Tới giờ uống nước rồi!!!");

                bool userResponded = false;
                btnOK.Click += (s, args) =>
                {
                    userResponded = true;
                    HideNotification();
                };

               
                await Task.Delay(30000);//delay 30s

                if (userResponded)
                {
                    // Người dùng nhấn OK
                    NuocDaUong += NuocUongVao;
                    txt_NuocDangUong.Text = NuocDaUong.ToString();
                    timeHistory.Add($"Mốc: {timeStamp} -Hoàn thành");

                    Label timeLabel = new Label
                    {
                        Text = $"Mốc: {timeStamp} - Hoàn thành",
                        AutoSize = true
                    };
                    flowLayoutPanel1.Controls.Add(timeLabel);
                }
                else
                {
                    // Người dùng không nhấn OK trong thời gian cho phép
                    timeHistory.Add($"Mốc: {timeStamp} - Miss");

                    Label timeLabel = new Label
                    {
                        Text = $"Mốc: {timeStamp} - Miss",
                        AutoSize = true
                    };
                    flowLayoutPanel1.Controls.Add(timeLabel);
                }

                HideNotification(); // Đảm bảo thông báo được ẩn
                isReminderActive = false; // Đặt lại trạng thái thông báo
            }

        }
        private void ShowNotification(string message)
        {
            if (notificationPanel == null)
            {
                // Tạo Panel nếu chưa có
                notificationPanel = new Panel
                {
                    Size = new Size(300, 100),
                    BackColor = Color.LightYellow,
                    BorderStyle = BorderStyle.FixedSingle,
                    Visible = false
                };

                lblNotification = new Label
                {
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 50
                };

                btnOK = new System.Windows.Forms.Button
                {
                    Text = "OK",
                    Dock = DockStyle.Bottom,
                    Height = 30
                };

                notificationPanel.Controls.Add(lblNotification);
                notificationPanel.Controls.Add(btnOK);

                // Thêm vào Form
                this.Controls.Add(notificationPanel);
                notificationPanel.BringToFront();
            }

            lblNotification.Text = message;
            notificationPanel.Location = new Point((this.Width - notificationPanel.Width) / 2, (this.Height - notificationPanel.Height) / 2);
            notificationPanel.Visible = true;
        }
        private void HideNotification()
        {
            if (notificationPanel != null)
            {
                notificationPanel.Visible = false;
            }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Savedckb_tuDongValue =ckb_tuDong.Checked;
            Properties.Settings.Default.Savedckb_thuCongValue = ckb_thuCong.Checked;
            Properties.Settings.Default.SavednumThoiGianValue = numThoiGian.Value; 
            Properties.Settings.Default.SavedNuocDangUongValue = txt_NuocDangUong.Text;
            Properties.Settings.Default.SaveListLichSuValue = string.Join(";", timeHistory);
            Properties.Settings.Default.Save();
        }

      
    }
}

