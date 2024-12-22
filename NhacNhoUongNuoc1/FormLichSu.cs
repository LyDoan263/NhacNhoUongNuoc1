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
    public partial class FormLichSu : Form
    {

        public List<string> timeHistory = new List<string>();

        public FormLichSu()
        {
            InitializeComponent();

        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            var savedItems = Properties.Settings.Default.SaveListLichSuValue as string;
            List<string> timeHistory = new List<string>();

            if (!string.IsNullOrEmpty(savedItems))
            {
                timeHistory = savedItems.Split(';').ToList();              
            }
            ProcessAndDisplayWaterData(timeHistory);

        }
        private void ProcessAndDisplayWaterData(List<string> timeHistory)
        {
            List<int> waterAmounts = new List<int>();
            List<string> timestamps = new List<string>();

            foreach (string record in timeHistory)//lấy các mốc trong list timeHistory
            {
                // Tách thông tin mốc và trạng thái
                string[] parts = record.Split('-');
                if (parts.Length > 1)
                {
                    string timestamp = parts[0].Replace("Mốc: ", "").Trim();
                    string status = parts[1].Trim();

                    
                    string[] timestampParts = timestamp.Split(' ');

                    if (timestampParts.Length > 1)
                    {
                        // Tách phần thời gian (HH:mm:ss)
                        string timePart = timestampParts[0]; 
                       // Tách ra giờ và phút
                        string[] timeElements = timePart.Split(':');
                        if (timeElements.Length >= 2)
                        {
                            string hourAndMinute = timeElements[0] + ":" + timeElements[1] + ":" + timeElements[2];
                            timestamps.Add(hourAndMinute); // add vào timestamps
                        }
                    }

                    // Thêm lượng nước vào danh sách (200 nếu "OK", 0 nếu "Miss")
                    if (status == "OK")
                    {
                        waterAmounts.Add(200);
                    }
                    else if (status == "Miss")
                    {
                        waterAmounts.Add(0);
                    }
                }
            }

            // Kiểm tra để đảm bảo số lượng phần tử trong timestamps và waterAmounts là bằng nhau
            if (timestamps.Count == waterAmounts.Count)
            {
                // Hiển thị biểu đồ cột với dữ liệu
                DisplayBarChart(waterAmounts, timestamps);
            }
            else
            {
                MessageBox.Show("Lỗi: Số lượng mốc thời gian không khớp với số lượng dữ liệu nước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayBarChart(List<int> waterAmounts, List<string> timestamps)
        {
            // Cài đặt các tham số cho biểu đồ
            chart1.Series.Clear();
            var series = chart1.Series.Add("Lượng nước");
            series.Points.DataBindY(waterAmounts);  // Gắn dữ liệu cho biểu đồ
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;  // Định dạng hình cột

            // Thiết lập nhãn trục X (tên mốc thời gian)
            chart1.ChartAreas[0].AxisX.Title = "Mốc thời gian";
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chart1.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;
            chart1.ChartAreas[0].AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45;
            chart1.Series[0].Points.DataBindXY(timestamps, waterAmounts);  // Gắn nhãn trục X (tên mốc thời gian)
        }

    }
}
