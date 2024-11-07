using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_GiaoHangSD19316.Models
{
    public class GioHang
    {
        
        public Guid Id { get; set; }
        [Required]
        public string UseName { get; set; }

        public Account? Account {  get; set; }
        [ForeignKey("Account")]   
        
        public Guid? AccountId {  get; set; } //khoá ngoại
        public List<GHCT> GHCTs { get; set; }
    }
}
