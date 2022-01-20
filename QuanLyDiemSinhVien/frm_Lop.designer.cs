
namespace QuanLyDiemSinhVien
{
    partial class frm_Lop
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
            this.btnXoaSv = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.btnThemSv = new System.Windows.Forms.Button();
            this.lb_tenlop = new System.Windows.Forms.Label();
            this.dgDS = new System.Windows.Forms.DataGridView();
            this.btnTrove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaSv
            // 
            this.btnXoaSv.Enabled = false;
            this.btnXoaSv.Location = new System.Drawing.Point(442, 305);
            this.btnXoaSv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSv.Name = "btnXoaSv";
            this.btnXoaSv.Size = new System.Drawing.Size(148, 44);
            this.btnXoaSv.TabIndex = 24;
            this.btnXoaSv.Text = "Xóa sinh viên";
            this.btnXoaSv.UseVisualStyleBackColor = false;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXem.Enabled = false;
            this.btnXem.Location = new System.Drawing.Point(607, 305);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(167, 44);
            this.btnXem.TabIndex = 23;
            this.btnXem.Text = "Xem thông tin sinh viên";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Enabled = false;
            this.btnXemDiem.Location = new System.Drawing.Point(134, 305);
            this.btnXemDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(148, 44);
            this.btnXemDiem.TabIndex = 22;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = false;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // btnThemSv
            // 
            this.btnThemSv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemSv.Location = new System.Drawing.Point(288, 305);
            this.btnThemSv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSv.Name = "btnThemSv";
            this.btnThemSv.Size = new System.Drawing.Size(148, 44);
            this.btnThemSv.TabIndex = 21;
            this.btnThemSv.Text = "Thêm sinh viên";
            this.btnThemSv.UseVisualStyleBackColor = false;
            // 
            // lb_tenlop
            // 
            this.lb_tenlop.AutoSize = true;
            this.lb_tenlop.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.lb_tenlop.Location = new System.Drawing.Point(286, 11);
            this.lb_tenlop.Name = "lb_tenlop";
            this.lb_tenlop.Size = new System.Drawing.Size(237, 45);
            this.lb_tenlop.TabIndex = 20;
            this.lb_tenlop.Text = "LỚP HỌC ABC";
            // 
            // dgDS
            // 
            this.dgDS.AllowUserToAddRows = false;
            this.dgDS.AllowUserToDeleteRows = false;
            this.dgDS.BackgroundColor = System.Drawing.Color.Azure;
            this.dgDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDS.Location = new System.Drawing.Point(27, 70);
            this.dgDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDS.Name = "dgDS";
            this.dgDS.ReadOnly = true;
            this.dgDS.RowHeadersVisible = false;
            this.dgDS.RowHeadersWidth = 51;
            this.dgDS.RowTemplate.Height = 29;
            this.dgDS.Size = new System.Drawing.Size(747, 212);
            this.dgDS.TabIndex = 19;
            this.dgDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetID);
            // 
            // btnTrove
            // 
            this.btnTrove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrove.ForeColor = System.Drawing.Color.Blue;
            this.btnTrove.Location = new System.Drawing.Point(27, 305);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(101, 44);
            this.btnTrove.TabIndex = 39;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frm_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.btnXoaSv);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btnThemSv);
            this.Controls.Add(this.lb_tenlop);
            this.Controls.Add(this.dgDS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Lop";
            this.Text = "Danh sách các lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dgDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaSv;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Button btnThemSv;
        private System.Windows.Forms.Label lb_tenlop;
        private System.Windows.Forms.DataGridView dgDS;
        private System.Windows.Forms.Button btnTrove;
    }
}