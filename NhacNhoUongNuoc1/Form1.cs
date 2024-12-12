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
    
    public partial class Form1 : Form
    {
       
        private double tongNuocCanUong;
        private double nuocDaUong = 0;
        private Timer nhacNhoTimer;
        //private NguoiDung user;
        private NguoiDung nguoiDung;
        //các biến tĩnh để lưu data
        public static string SavedDataTen = "";
        public static string SaveDataTuoi = "";
        public static string SaveDataChieuCao = "";
        public static string SaveDataCanNang = "";
        public static string SaveDatakqLuongNuoc = "";
        public static string SaveDataNuoc = "";
        public Form1()
        {
            
            InitializeComponent();
            
            nguoiDung = new NguoiDung("Nguyen Van A", 25, 60, 170, 2.0, 3.0);
            nhacNhoTimer = new Timer
            {
                Interval = 3600000 // 1 giờ = 3600000 ms
            };
            nhacNhoTimer.Tick += NhacNhoTimer_Tick;
            nhacNhoTimer.Start();
            nhacNhoTimer.Stop();
        }


        
        private void NhacNhoTimer_Tick(object sender, EventArgs e)
        {
            // Thông báo nhắc nhở
            MessageBox.Show("Đã đến lúc uống nước! Hãy bổ sung đủ lượng nước trong ngày.",
                            "Nhắc Nhở Uống Nước",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            nhacNhoTimer.Stop();
        }
        private double TinhTongNuocCanUong(double canNang)
        {
            // Giả sử mỗi kg cân nặng cần 40ml nước
            return canNang * 40;
        }

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        
            System.Diagnostics.Process.Start("IExplore", "https://www.vinmec.com/vie/bai-viet/khuyen-cao-cua-who-ve-nhu-cau-nuoc-hang-ngay-vi");
        
    }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNguoiDung.Text) ||
     string.IsNullOrWhiteSpace(txtTuoi.Text) ||
     string.IsNullOrWhiteSpace(txtCanNang.Text) ||
     string.IsNullOrWhiteSpace(txtChieuCao.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Lấy thông tin từ các TextBox
                string ten = txtTenNguoiDung.Text;
                int tuoi = int.Parse(txtTuoi.Text);
                double canNang = double.Parse(txtCanNang.Text);
                double chieuCao = double.Parse(txtChieuCao.Text);
                // Tính tổng lượng nước cần uống
                tongNuocCanUong = TinhTongNuocCanUong(canNang);

                // Tính lượng nước cần uống (theo cân nặng)
                double litNuoc = canNang * 0.04;
                txtkqLuongNuoc.Text = litNuoc.ToString();
                txt_Nuoc.Text = txtkqLuongNuoc.Text;
                



            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin nhập không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)// tạo biến tĩnh để lưu data người dùng
        {
            SavedDataTen = txtTenNguoiDung.Text;
          SaveDataTuoi = txtTuoi.Text;
            SaveDataChieuCao = txtChieuCao.Text;
            SaveDataCanNang = txtCanNang.Text;
            SaveDatakqLuongNuoc = txtkqLuongNuoc.Text;
            SaveDataNuoc = txt_Nuoc.Text;
            //block thông tin
            txtTenNguoiDung.Enabled = false;
            txtTuoi.Enabled = false;
            txtChieuCao.Enabled = false;
            txtCanNang.Enabled = false;
            txtkqLuongNuoc.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenNguoiDung.Text=Form1.SavedDataTen;
            txtTuoi.Text =Form1.SaveDataTuoi;
            txtChieuCao.Text = Form1.SaveDataChieuCao;
            txtCanNang.Text = Form1.SaveDataCanNang;
            txtkqLuongNuoc.Text=Form1.SaveDatakqLuongNuoc;
            txt_Nuoc.Text = Form1.SaveDataNuoc;
        }
        
    }
}
