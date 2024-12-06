using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NhacNhoUongNuoc1
{
    internal class NhacNho
    {
        private Timer timer;
        private NguoiDung nguoiDung;

        public NhacNho(NguoiDung nguoiDung)
        {
            this.nguoiDung = nguoiDung;

            // Thiết lập Timer để nhắc nhở mỗi 60 phút
            timer = new Timer(3600000); // 1 giờ = 60 phút x 60 giây x 1000 ms
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true; // Tự động lặp lại
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string thongBao = nguoiDung.NhacNhoUongNuoc();
            Console.WriteLine(thongBao);
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
