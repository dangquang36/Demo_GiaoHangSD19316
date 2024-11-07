using System.ComponentModel.DataAnnotations;

namespace Demo_GiaoHangSD19316.Models
{
    public class SanPham
    {
       
        public Guid SanPhamId { get; set; }
       
        public string SanPhamName { get; set; }
        
        public decimal Price { get; set; }
        //thiết lập mqh 1-n
        //Icolection, colection, list 
        public List<GHCT> GHCTs { get; set; }
    }
}
