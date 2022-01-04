namespace QuanLyDiemSinhVien.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            Diems = new HashSet<Diem>();
            PhanLopSinhViens = new HashSet<PhanLopSinhVien>();
        }

        [Key]
        public int Masv { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Hoten { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        public byte? Gioitinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanLopSinhVien> PhanLopSinhViens { get; set; }
    }
}
