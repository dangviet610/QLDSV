﻿
namespace QuanLyDiemSinhVien
{
    partial class frm_SinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBangdiem = new System.Windows.Forms.Button();
            this.btnThaydoithongtin = new System.Windows.Forms.Button();
            this.btnLopdanghoc = new System.Windows.Forms.Button();
            this.lbten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbGt = new System.Windows.Forms.Label();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh viên:";
            // 
            // btnBangdiem
            // 
            this.btnBangdiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBangdiem.Location = new System.Drawing.Point(189, 239);
            this.btnBangdiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBangdiem.Name = "btnBangdiem";
            this.btnBangdiem.Size = new System.Drawing.Size(132, 44);
            this.btnBangdiem.TabIndex = 25;
            this.btnBangdiem.Text = "Bảng điểm";
            this.btnBangdiem.UseVisualStyleBackColor = false;
            this.btnBangdiem.Click += new System.EventHandler(this.btnBangdiem_Click);
            // 
            // btnThaydoithongtin
            // 
            this.btnThaydoithongtin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThaydoithongtin.Location = new System.Drawing.Point(341, 239);
            this.btnThaydoithongtin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThaydoithongtin.Name = "btnThaydoithongtin";
            this.btnThaydoithongtin.Size = new System.Drawing.Size(132, 44);
            this.btnThaydoithongtin.TabIndex = 26;
            this.btnThaydoithongtin.Text = "Thay đổi thông tin";
            this.btnThaydoithongtin.UseVisualStyleBackColor = false;
            this.btnThaydoithongtin.Click += new System.EventHandler(this.btnThaydoithongtin_Click);
            // 
            // btnLopdanghoc
            // 
            this.btnLopdanghoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLopdanghoc.Location = new System.Drawing.Point(34, 239);
            this.btnLopdanghoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLopdanghoc.Name = "btnLopdanghoc";
            this.btnLopdanghoc.Size = new System.Drawing.Size(132, 44);
            this.btnLopdanghoc.TabIndex = 27;
            this.btnLopdanghoc.Text = "Các lớp đang học ";
            this.btnLopdanghoc.UseVisualStyleBackColor = false;
            this.btnLopdanghoc.Click += new System.EventHandler(this.btnLopdanghoc_Click);
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.ForeColor = System.Drawing.Color.Blue;
            this.lbten.Location = new System.Drawing.Point(423, 9);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(44, 24);
            this.lbten.TabIndex = 28;
            this.lbten.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Blue;
            this.lbEmail.Location = new System.Drawing.Point(381, 64);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(58, 25);
            this.lbEmail.TabIndex = 33;
            this.lbEmail.Text = "email";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaysinh.ForeColor = System.Drawing.Color.Blue;
            this.lbNgaysinh.Location = new System.Drawing.Point(420, 118);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(33, 25);
            this.lbNgaysinh.TabIndex = 34;
            this.lbNgaysinh.Text = "ns";
            // 
            // lbGt
            // 
            this.lbGt.AutoSize = true;
            this.lbGt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGt.ForeColor = System.Drawing.Color.Blue;
            this.lbGt.Location = new System.Drawing.Point(403, 173);
            this.lbGt.Name = "lbGt";
            this.lbGt.Size = new System.Drawing.Size(28, 25);
            this.lbGt.TabIndex = 35;
            this.lbGt.Text = "gt";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangxuat.Location = new System.Drawing.Point(499, 239);
            this.btnDangxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(132, 44);
            this.btnDangxuat.TabIndex = 36;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyDiemSinhVien.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 208);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frm_SinhVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(665, 294);
            this.Controls.Add(this.btnDangxuat);
            this.Controls.Add(this.lbGt);
            this.Controls.Add(this.lbNgaysinh);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.btnLopdanghoc);
            this.Controls.Add(this.btnThaydoithongtin);
            this.Controls.Add(this.btnBangdiem);
            this.Controls.Add(this.label1);
            this.Name = "frm_SinhVien";
            this.Text = "Sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBangdiem;
        private System.Windows.Forms.Button btnThaydoithongtin;
        private System.Windows.Forms.Button btnLopdanghoc;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbGt;
        private System.Windows.Forms.Button btnDangxuat;
    }
}