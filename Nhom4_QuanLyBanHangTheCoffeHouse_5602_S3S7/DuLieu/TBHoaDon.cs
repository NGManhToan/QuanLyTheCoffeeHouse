namespace Quanlyquancoffe.DuLieu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBHoaDon")]
    public partial class TBHoaDon
    {
        [Key]
        [StringLength(6)]
        public string MaHD { get; set; }

        [StringLength(6)]
        public string MaNV { get; set; }

        [StringLength(6)]
        public string MaKH { get; set; }

        public DateTime? NgayLapHD { get; set; }

        [StringLength(50)]
        public string PTTT { get; set; }

        [StringLength(50)]
        public string TongSoTien { get; set; }

        public virtual TBKhachHang TBKhachHang { get; set; }

        public virtual TBNhanVien TBNhanVien { get; set; }
    }
}
