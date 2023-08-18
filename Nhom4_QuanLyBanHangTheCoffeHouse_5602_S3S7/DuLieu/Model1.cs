namespace Quanlyquancoffe.DuLieu
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<TBHoaDon> TBHoaDons { get; set; }
        public virtual DbSet<TBKhachHang> TBKhachHangs { get; set; }
        public virtual DbSet<TBNhanVien> TBNhanViens { get; set; }
        public virtual DbSet<TBPhuCap> TBPhuCaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBHoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<TBHoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<TBHoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<TBKhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<TBKhachHang>()
                .Property(e => e.MaCN)
                .IsFixedLength();

            modelBuilder.Entity<TBNhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<TBNhanVien>()
                .Property(e => e.MaCN)
                .IsFixedLength();

            modelBuilder.Entity<TBNhanVien>()
                .Property(e => e.GioiTinhNV)
                .IsFixedLength();

            modelBuilder.Entity<TBNhanVien>()
                .HasMany(e => e.TBPhuCaps)
                .WithRequired(e => e.TBNhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBPhuCap>()
                .Property(e => e.MaPC)
                .IsFixedLength();

            modelBuilder.Entity<TBPhuCap>()
                .Property(e => e.MaNV)
                .IsFixedLength();
        }
    }
}
