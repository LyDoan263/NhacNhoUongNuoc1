﻿namespace NhacNhoUongNuoc1
{
    partial class ThongTinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.TextBox();
            this.lblTuoi = new System.Windows.Forms.TextBox();
            this.lblChieuCao = new System.Windows.Forms.TextBox();
            this.lblCanNang = new System.Windows.Forms.TextBox();
            this.lblLitNuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(123, 55);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(179, 22);
            this.lblTen.TabIndex = 5;
            // 
            // lblTuoi
            // 
            this.lblTuoi.Location = new System.Drawing.Point(123, 95);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(179, 22);
            this.lblTuoi.TabIndex = 6;
            // 
            // lblChieuCao
            // 
            this.lblChieuCao.Location = new System.Drawing.Point(123, 134);
            this.lblChieuCao.Name = "lblChieuCao";
            this.lblChieuCao.Size = new System.Drawing.Size(179, 22);
            this.lblChieuCao.TabIndex = 7;
            // 
            // lblCanNang
            // 
            this.lblCanNang.Location = new System.Drawing.Point(123, 179);
            this.lblCanNang.Name = "lblCanNang";
            this.lblCanNang.Size = new System.Drawing.Size(179, 22);
            this.lblCanNang.TabIndex = 8;
            // 
            // lblLitNuoc
            // 
            this.lblLitNuoc.Location = new System.Drawing.Point(123, 223);
            this.lblLitNuoc.Name = "lblLitNuoc";
            this.lblLitNuoc.Size = new System.Drawing.Size(179, 22);
            this.lblLitNuoc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Người Dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Chiều Cao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cân Nặng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lít Nước Uống";
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Location = new System.Drawing.Point(123, 274);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(75, 23);
            this.btnCaiDat.TabIndex = 20;
            this.btnCaiDat.Text = "Cài Đặt";
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // ThongTinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLitNuoc);
            this.Controls.Add(this.lblCanNang);
            this.Controls.Add(this.lblChieuCao);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.label5);
            this.Name = "ThongTinForm";
            this.Text = "ThongTinForm";
            this.Load += new System.EventHandler(this.ThongTinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblTen;
        private System.Windows.Forms.TextBox lblTuoi;
        private System.Windows.Forms.TextBox lblChieuCao;
        private System.Windows.Forms.TextBox lblCanNang;
        private System.Windows.Forms.TextBox lblLitNuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCaiDat;
    }
}