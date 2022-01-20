
namespace QuanLyDiemSinhVien
{
    partial class frm_BangDiemSinhVien
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
            this.dgDanhSach = new System.Windows.Forms.DataGridView();
            this.mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBangdiem = new System.Windows.Forms.Button();
            this.cbSx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH ĐIỂM";
            // 
            // dgDanhSach
            // 
            this.dgDanhSach.AllowUserToAddRows = false;
            this.dgDanhSach.AllowUserToDeleteRows = false;
            this.dgDanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgDanhSach.BackgroundColor = System.Drawing.Color.Azure;
            this.dgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mon,
            this.diem});
            this.dgDanhSach.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgDanhSach.Location = new System.Drawing.Point(32, 74);
            this.dgDanhSach.Name = "dgDanhSach";
            this.dgDanhSach.ReadOnly = true;
            this.dgDanhSach.RowHeadersVisible = false;
            this.dgDanhSach.RowHeadersWidth = 51;
            this.dgDanhSach.RowTemplate.Height = 24;
            this.dgDanhSach.Size = new System.Drawing.Size(734, 264);
            this.dgDanhSach.TabIndex = 1;
            // 
            // mon
            // 
            this.mon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mon.DataPropertyName = "mon";
            this.mon.HeaderText = "Môn học";
            this.mon.MinimumWidth = 6;
            this.mon.Name = "mon";
            this.mon.ReadOnly = true;
            // 
            // diem
            // 
            this.diem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diem.DataPropertyName = "d";
            this.diem.HeaderText = "Điểm";
            this.diem.MinimumWidth = 6;
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            // 
            // btnBangdiem
            // 
            this.btnBangdiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBangdiem.Location = new System.Drawing.Point(634, 358);
            this.btnBangdiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBangdiem.Name = "btnBangdiem";
            this.btnBangdiem.Size = new System.Drawing.Size(132, 44);
            this.btnBangdiem.TabIndex = 26;
            this.btnBangdiem.Text = "Trở về";
            this.btnBangdiem.UseVisualStyleBackColor = false;
            this.btnBangdiem.Click += new System.EventHandler(this.btnBangdiem_Click);
            // 
            // cbSx
            // 
            this.cbSx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSx.FormattingEnabled = true;
            this.cbSx.Items.AddRange(new object[] {
            "Từ cao đến thấp",
            "Từ thấp đến cao"});
            this.cbSx.Location = new System.Drawing.Point(552, 26);
            this.cbSx.Name = "cbSx";
            this.cbSx.Size = new System.Drawing.Size(214, 24);
            this.cbSx.TabIndex = 27;
            this.cbSx.SelectedIndexChanged += new System.EventHandler(this.SapXep);
            // 
            // frm_BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.cbSx);
            this.Controls.Add(this.btnBangdiem);
            this.Controls.Add(this.dgDanhSach);
            this.Controls.Add(this.label1);
            this.Name = "frm_BangDiem";
            this.Text = "Bảng điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDanhSach;
        private System.Windows.Forms.Button btnBangdiem;
        private System.Windows.Forms.ComboBox cbSx;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
    }
}