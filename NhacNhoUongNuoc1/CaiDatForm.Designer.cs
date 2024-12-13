namespace NhacNhoUongNuoc1
{
    partial class CaiDatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaiDatForm));
            this.ckb_tuDong = new System.Windows.Forms.CheckBox();
            this.ckb_thuCong = new System.Windows.Forms.CheckBox();
            this.numThoiGian = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcb_MucTieuCaiDat = new System.Windows.Forms.ProgressBar();
            this.txt_NuocCaiDat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).BeginInit();
            this.SuspendLayout();
            // 
            // ckb_tuDong
            // 
            this.ckb_tuDong.AutoSize = true;
            this.ckb_tuDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_tuDong.Location = new System.Drawing.Point(39, 127);
            this.ckb_tuDong.Name = "ckb_tuDong";
            this.ckb_tuDong.Size = new System.Drawing.Size(241, 33);
            this.ckb_tuDong.TabIndex = 0;
            this.ckb_tuDong.Text = "Nhắc Nhớ Tự Động";
            this.ckb_tuDong.UseVisualStyleBackColor = true;
            this.ckb_tuDong.CheckedChanged += new System.EventHandler(this.ckb_tuDong_CheckedChanged);
            // 
            // ckb_thuCong
            // 
            this.ckb_thuCong.AutoSize = true;
            this.ckb_thuCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_thuCong.Location = new System.Drawing.Point(39, 171);
            this.ckb_thuCong.Name = "ckb_thuCong";
            this.ckb_thuCong.Size = new System.Drawing.Size(334, 33);
            this.ckb_thuCong.TabIndex = 1;
            this.ckb_thuCong.Text = "Nhắc Nhở Thủ Công ( phút )";
            this.ckb_thuCong.UseVisualStyleBackColor = true;
            this.ckb_thuCong.CheckedChanged += new System.EventHandler(this.ckb_thuCong_CheckedChanged);
            // 
            // numThoiGian
            // 
            this.numThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numThoiGian.Location = new System.Drawing.Point(406, 170);
            this.numThoiGian.Name = "numThoiGian";
            this.numThoiGian.Size = new System.Drawing.Size(92, 34);
            this.numThoiGian.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(50, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "CÀI ĐẶT NHẮC NHỞ";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.Location = new System.Drawing.Point(170, 265);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(201, 38);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(549, 507);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(260, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nhu cầu uống nước hằng ngày ( Đọc thêm.)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(514, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mục Tiêu Của Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(808, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "ml";
            // 
            // pcb_MucTieuCaiDat
            // 
            this.pcb_MucTieuCaiDat.Location = new System.Drawing.Point(518, 238);
            this.pcb_MucTieuCaiDat.Name = "pcb_MucTieuCaiDat";
            this.pcb_MucTieuCaiDat.Size = new System.Drawing.Size(324, 35);
            this.pcb_MucTieuCaiDat.TabIndex = 8;
            // 
            // txt_NuocCaiDat
            // 
            this.txt_NuocCaiDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NuocCaiDat.Location = new System.Drawing.Point(728, 188);
            this.txt_NuocCaiDat.Name = "txt_NuocCaiDat";
            this.txt_NuocCaiDat.Size = new System.Drawing.Size(68, 22);
            this.txt_NuocCaiDat.TabIndex = 9;
            // 
            // CaiDatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 624);
            this.Controls.Add(this.txt_NuocCaiDat);
            this.Controls.Add(this.pcb_MucTieuCaiDat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numThoiGian);
            this.Controls.Add(this.ckb_thuCong);
            this.Controls.Add(this.ckb_tuDong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaiDatForm";
            this.Text = "Custom Time";
            this.Load += new System.EventHandler(this.CaiDatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb_tuDong;
        private System.Windows.Forms.CheckBox ckb_thuCong;
        private System.Windows.Forms.NumericUpDown numThoiGian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pcb_MucTieuCaiDat;
        private System.Windows.Forms.TextBox txt_NuocCaiDat;
    }
}