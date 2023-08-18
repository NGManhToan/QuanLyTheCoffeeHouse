namespace Quanlyquancoffe.DuLieu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBKhachHang")]
    public partial class TBKhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBKhachHang()
        {
            TBHoaDons = new HashSet<TBHoaDon>();
        }

        [Key]
        [StringLength(6)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(6)]
        public string MaCN { get; set; }

        [StringLength(50)]
        public string HoKH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKH { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? NgayDK { get; set; }

        [StringLength(12)]
        public string CCCD { get; set; }

        public double TongDiem { get; set; }

        [StringLength(50)]
        public string ThanhVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBHoaDon> TBHoaDons { get; set; }
    }
}
