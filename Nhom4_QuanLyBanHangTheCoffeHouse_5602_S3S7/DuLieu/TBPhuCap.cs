namespace Quanlyquancoffe.DuLieu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBPhuCap")]
    public partial class TBPhuCap
    {
        [Key]
        [StringLength(6)]
        public string MaPC { get; set; }

        [Required]
        [StringLength(6)]
        public string MaNV { get; set; }

        public double? PhuCap { get; set; }

        public virtual TBNhanVien TBNhanVien { get; set; }
    }
}
