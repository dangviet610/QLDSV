namespace QuanLyDiemSinhVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanLopSinhVien")]
    public partial class PhanLopSinhVien
    {
        public int ID { get; set; }

        public int Masv { get; set; }

        public int Malop { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
