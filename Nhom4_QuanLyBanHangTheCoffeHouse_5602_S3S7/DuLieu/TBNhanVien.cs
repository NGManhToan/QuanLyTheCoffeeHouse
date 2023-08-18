namespace Quanlyquancoffe.DuLieu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBNhanVien")]
    public partial class TBNhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBNhanVien()
        {
            TBHoaDons = new HashSet<TBHoaDon>();
            TBPhuCaps = new HashSet<TBPhuCap>();
        }

        [Key]
        [StringLength(6)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(6)]
        public string MaCN { get; set; }

        [StringLength(50)]
        public string HoNV { get; set; }

        [StringLength(50)]
        public string TenNV { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinhNV { get; set; }

        [StringLength(12)]
        public string CCCD { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Luong { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBHoaDon> TBHoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBPhuCap> TBPhuCaps { get; set; }
    }
}
