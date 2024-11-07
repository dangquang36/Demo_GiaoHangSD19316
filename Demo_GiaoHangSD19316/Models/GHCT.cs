using System.ComponentModel.DataAnnotations;

namespace Demo_GiaoHangSD19316.Models
{
    public class GHCT
    {
        public Guid ID { get; set; }
       
        public Guid? SanPhamId { get; set; }
        
        public Guid? GioHangId { get; set; }
        
        public GioHang? GioHang { get; set; }
        public SanPham? SanPham { get; set; }  
        public int SoLuong {  get; set; }

    }
}
