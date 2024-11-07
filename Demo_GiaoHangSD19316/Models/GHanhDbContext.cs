using Microsoft.EntityFrameworkCore;

namespace Demo_GiaoHangSD19316.Models
{
    public class GHanhDbContext : DbContext
    {
        //Nếu để chuỗi kết nối ở trong clss dbcontext thì bắt buộc 
        public GHanhDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<GioHang>  GioHangs { get; set; }
        public DbSet<GHCT> GHCTs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }


    }
    
}
