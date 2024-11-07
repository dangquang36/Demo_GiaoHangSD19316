using Demo_GiaoHangSD19316.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo_GiaoHangSD19316.Configuration
{
    public class GioHangConfig : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(x => x.Id);
            //thiét lập mph 1-1 vs account
            builder.HasOne(x => x.Account)
                .WithOne(x => x.GioHang)
                .HasForeignKey<GioHang>(x => x.AccountId);
        }
    }
}
