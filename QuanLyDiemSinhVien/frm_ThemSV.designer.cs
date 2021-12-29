
namespace QuanLyDiemSinhVien
{
    partial class frm_ThemSV
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
            this.hoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.diachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.masv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nam = new System.Windows.Forms.RadioButton();
            this.nu = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(133, 65);
            this.hoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(259, 22);
            this.hoten.TabIndex = 3;
            this.hoten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(73, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(53, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày sinh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(502, 128);
            this.diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(217, 22);
            this.diachi.TabIndex = 7;
            this.diachi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(441, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(440, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lớp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(618, 275);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 33);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Thêm";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(495, 275);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(99, 33);
            this.btnback.TabIndex = 21;
            this.btnback.Text = "Quay lại";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // masv
            // 
            this.masv.Location = new System.Drawing.Point(133, 198);
            this.masv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(259, 22);
            this.masv.TabIndex = 23;
            this.masv.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(73, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Checked = true;
            this.nam.Location = new System.Drawing.Point(502, 194);
            this.nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(58, 21);
            this.nam.TabIndex = 62;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            this.nam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(618, 194);
            this.nu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(47, 21);
            this.nu.TabIndex = 63;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            this.nu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(431, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Giới tính";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(133, 130);
            this.ngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(259, 22);
            this.ngaysinh.TabIndex = 65;
            this.ngaysinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(502, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 66;
            // 
            // frm_ThemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nu);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.masv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ThemSV";
            this.Text = "Thêm sinh viên";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox masv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}