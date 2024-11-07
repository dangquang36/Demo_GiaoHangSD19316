using Demo_GiaoHangSD19316.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Demo_GiaoHangSD19316.Controllers
{
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            //thiết lập khoá chính
            builder.HasKey(x => x.Id);
            //cònig cho các thuộc tính

            //thuộc tính pas => matkhau có 256 kí tu
            builder.Property(x => x.Password).IsRequired()
                .HasColumnName("Mat Khau")
                .HasColumnType("varchar(255)");
            //thiết lập name nvachar(256)
            builder.Property(x => x.Name).IsRequired()
                .IsUnicode(true)
                .IsFixedLength(true)
                .HasMaxLength(256);
            //thiết lập mối quan hệ 1-1
            //hasone: chỉ ra mph đầu 1
            //withone: chỉ ra bảng 1
            builder.HasOne(x => x.GioHang)
                .WithOne(x => x.Account)
                .HasPrincipalKey<GioHang>(x => x.AccountId);

        }
    }
}
