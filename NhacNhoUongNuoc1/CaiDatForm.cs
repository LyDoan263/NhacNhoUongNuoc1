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
            var savedItems = Properties.Settings.Default.SaveListLichSuValue;         
            foreach (var time in timeHistory)
            {
                // Tạo một Label mới để hiển thị mốc thời gian
                Label timeLabel = new Label();
                timeLabel.Text = time;
                timeLabel.AutoSize = true;
                // Thêm Label vào FlowLayoutPanel (Giả sử FlowLayoutPanel của bạn là flowLayoutPanel)
                flowLayoutPanel1.Controls.Add(timeLabel);
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
                    timer3.Interval = soPhut * 1000;
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
                    DialogResult result = MessageBox.Show("Nhớ uống nước nhé!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        // Tăng lượng nước đã uống mỗi lần nhấn OK                     
                        NuocDaUong += NuocUongVao;
                        txt_NuocDangUong.Text = NuocDaUong.ToString();
                        string timeStamp = DateTime.Now.ToString("HH:mm:ss ddd/MM/yyyy");
                        //timeHistory.Add("Mốc: " + timeStamp );
                        Label timeLabel = new Label();
                        timeLabel.Text = "Mốc time : "+timeStamp ;
                        timeLabel.AutoSize = true;
                        flowLayoutPanel1.Controls.Add(timeLabel);                  
                    }
                }
            }

        }
    

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Savedckb_tuDongValue =ckb_tuDong.Checked;
            Properties.Settings.Default.Savedckb_thuCongValue = ckb_thuCong.Checked;
            Properties.Settings.Default.SavednumThoiGianValue = numThoiGian.Value; 
            Properties.Settings.Default.SavedNuocDangUongValue = txt_NuocDangUong.Text;
            //////var selectedItems = new System.Collections.Specialized.StringCollection();
            //////foreach (Control control in flowLayoutPanel1.Controls)
            //////{
            //////    if (control is Label label)  // Kiểm tra xem điều khiển có phải là Label không
            //////    {
            //////        selectedItems.Add(label.Text);  // Lưu văn bản của Label vào StringCollection
            //////    }
            //////}
            //////Properties.Settings.Default.SaveListLichSuValue = selectedItems;
            Properties.Settings.Default.Save();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }
    }
}

