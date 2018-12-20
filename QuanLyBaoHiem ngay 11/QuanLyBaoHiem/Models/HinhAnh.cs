namespace QuanLyBaoHiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HinhAnh")]
    public partial class HinhAnh
    {
        [Key]
        [StringLength(50)]
        public string MaHA { get; set; }

        [Column("HinhAnh")]
        public byte[] HinhAnh1 { get; set; }

        [StringLength(50)]
        public string MaKH { get; set; }

        public bool? Status { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
