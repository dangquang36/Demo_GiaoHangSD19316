using Demo_GiaoHangSD19316.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo_GiaoHangSD19316.Configuration
{
    public class GHCTConfig : IEntityTypeConfiguration<GHCT>
    {
        public void Configure(EntityTypeBuilder<GHCT> builder)
        {
            builder.HasKey(x => x.ID);
            //thiết lập mph 1-n vs giỏ hàng
            builder.HasOne(x => x.GioHang)
                .WithMany(x => x.GHCTs)
                .HasForeignKey(x => x.GioHangId);
            //thiết lập mph 1-n SanPham
            builder.HasOne(x => x.SanPham)
                .WithMany(x => x.GHCTs)
                .HasForeignKey(x => x.SanPhamId);
        }
    }
}
