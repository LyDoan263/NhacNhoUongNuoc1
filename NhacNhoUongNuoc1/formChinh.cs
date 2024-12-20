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
    public partial class formChinh : Form
    {
     
        public formChinh()
        {
            InitializeComponent();
            
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Body.Controls.Add(childForm);
            pnl_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

      

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
         
            OpenChildForm(new Form1());
            lbl_Top.Text = btn_ThongTin.Text;
        }

       private void btn_LichSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLichSu());

            lbl_Top.Text = btn_LichSu.Text;
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
          
            OpenChildForm(new CaiDatForm());
            lbl_Top.Text = btn_CaiDat.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lbl_Top.Text = "Home";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://suckhoedoisong.vn/tim-kiem.htm?keywords=U%E1%BB%91ng%20%C4%91%E1%BB%A7%20n%C6%B0%E1%BB%9Bc");
        }
    }
}
