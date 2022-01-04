namespace QuanLyDiemSinhVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanLopGiaoVien")]
    public partial class PhanLopGiaoVien
    {
        public int ID { get; set; }

        public int Magiaovien { get; set; }

        public int Malop { get; set; }

        public int Mamon { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual Lop Lop { get; set; }
    }
}
