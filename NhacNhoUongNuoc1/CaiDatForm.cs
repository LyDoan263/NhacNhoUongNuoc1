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
        public CaiDatForm()
        {
            InitializeComponent();
        }
            private void chkThuCong_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu chọn chế độ thủ công, hiển thị NumericUpDown
            numThoiGian.Enabled = chkThuCong.Checked;

            // Đảm bảo chế độ tự động không được chọn cùng lúc
            if (chkThuCong.Checked)
                chkTuDong.Checked = false;
        }
        private void chkTuDong_CheckedChanged(object sender, EventArgs e)
        {
            // Đảm bảo chế độ thủ công không được chọn cùng lúc
            if (chkTuDong.Checked)
                chkThuCong.Checked = false;

            // Vô hiệu hóa NumericUpDown nếu chọn tự động
            numThoiGian.Enabled = !chkTuDong.Checked;
        }
        public bool IsTuDong { get; private set; } // Lưu trạng thái Tự Động
        public int ThoiGianThuCong { get; private set; } // Thời gian nhắc nhở (thủ công)

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (chkTuDong.Checked)
            {
                IsTuDong = true; // Bật chế độ tự động
                
            }
            else if (chkThuCong.Checked)
            {
                IsTuDong = false; // Chế độ thủ công
                ThoiGianThuCong = (int)numThoiGian.Value; // Lấy giá trị từ NumericUpDown
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chế độ nhắc nhở!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK; // Trả về kết quả OK
            this.Close(); // Đóng CaiDatForm
        }

        
    }
}

