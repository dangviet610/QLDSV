
namespace QuanLyDiemSinhVien
{
    partial class frm_LopDangHoc
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
            this.dgDS = new System.Windows.Forms.DataGridView();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTrove = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH LỚP HỌC ";
            // 
            // dgDS
            // 
            this.dgDS.AllowUserToAddRows = false;
            this.dgDS.AllowUserToDeleteRows = false;
            this.dgDS.BackgroundColor = System.Drawing.Color.Azure;
            this.dgDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lop,
            this.mon,
            this.gv});
            this.dgDS.Location = new System.Drawing.Point(15, 56);
            this.dgDS.Name = "dgDS";
            this.dgDS.ReadOnly = true;
            this.dgDS.RowHeadersVisible = false;
            this.dgDS.RowHeadersWidth = 51;
            this.dgDS.RowTemplate.Height = 24;
            this.dgDS.Size = new System.Drawing.Size(754, 300);
            this.dgDS.TabIndex = 1;
            // 
            // lop
            // 
            this.lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lop.DataPropertyName = "tenlop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.ReadOnly = true;
            // 
            // mon
            // 
            this.mon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mon.DataPropertyName = "tenmon";
            this.mon.HeaderText = "Môn học";
            this.mon.MinimumWidth = 6;
            this.mon.Name = "mon";
            this.mon.ReadOnly = true;
            // 
            // gv
            // 
            this.gv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gv.DataPropertyName = "gv";
            this.gv.HeaderText = "Giáo viên";
            this.gv.MinimumWidth = 6;
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            // 
            // btnTrove
            // 
            this.btnTrove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrove.Location = new System.Drawing.Point(637, 373);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(132, 44);
            this.btnTrove.TabIndex = 37;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // btnPick
            // 
            this.btnPick.BackColor = System.Drawing.Color.Tomato;
            this.btnPick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPick.Location = new System.Drawing.Point(15, 373);
            this.btnPick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(132, 44);
            this.btnPick.TabIndex = 38;
            this.btnPick.Text = "Đăng ký lớp học";
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Visible = false;
            this.btnPick.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Lớp đã đăng ký",
            "Lớp chưa đăng ký"});
            this.cbLoai.Location = new System.Drawing.Point(613, 20);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(156, 24);
            this.cbLoai.TabIndex = 39;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.ChonLoai);
            // 
            // frm_LopDangHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.dgDS);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frm_LopDangHoc";
            this.Text = "Các lớp đang học";
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDS;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv;
        private System.Windows.Forms.ComboBox cbLoai;
    }
}