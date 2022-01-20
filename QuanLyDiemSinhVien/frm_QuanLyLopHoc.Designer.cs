
namespace QuanLyDiemSinhVien
{
    partial class frm_QuanLyLopHoc
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
            this.dgDS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrove = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.lb_tongso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDS
            // 
            this.dgDS.AllowUserToAddRows = false;
            this.dgDS.AllowUserToDeleteRows = false;
            this.dgDS.BackgroundColor = System.Drawing.Color.Azure;
            this.dgDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lop,
            this.malop,
            this.mon,
            this.mamon});
            this.dgDS.Location = new System.Drawing.Point(23, 75);
            this.dgDS.Name = "dgDS";
            this.dgDS.ReadOnly = true;
            this.dgDS.RowHeadersVisible = false;
            this.dgDS.RowHeadersWidth = 51;
            this.dgDS.RowTemplate.Height = 24;
            this.dgDS.Size = new System.Drawing.Size(754, 300);
            this.dgDS.TabIndex = 2;
            this.dgDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChonLop);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(331, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "LỚP HỌC ĐANG DẠY";
            // 
            // btnTrove
            // 
            this.btnTrove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrove.ForeColor = System.Drawing.Color.Blue;
            this.btnTrove.Location = new System.Drawing.Point(645, 395);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(132, 44);
            this.btnTrove.TabIndex = 38;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXem.Enabled = false;
            this.btnXem.Location = new System.Drawing.Point(23, 395);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(132, 44);
            this.btnXem.TabIndex = 41;
            this.btnXem.Text = "Xem thông tin";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lb_tongso
            // 
            this.lb_tongso.AutoSize = true;
            this.lb_tongso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongso.Location = new System.Drawing.Point(105, 32);
            this.lb_tongso.Name = "lb_tongso";
            this.lb_tongso.Size = new System.Drawing.Size(23, 25);
            this.lb_tongso.TabIndex = 43;
            this.lb_tongso.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tổng số:";
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
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "malop";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.ReadOnly = true;
            this.malop.Visible = false;
            this.malop.Width = 125;
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
            // mamon
            // 
            this.mamon.DataPropertyName = "mamon";
            this.mamon.HeaderText = "mamon";
            this.mamon.MinimumWidth = 6;
            this.mamon.Name = "mamon";
            this.mamon.ReadOnly = true;
            this.mamon.Visible = false;
            this.mamon.Width = 125;
            // 
            // frm_QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.lb_tongso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDS);
            this.Name = "frm_QuanLyLopHoc";
            this.Text = "Quản lý lớp học";
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lb_tongso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamon;
    }
}