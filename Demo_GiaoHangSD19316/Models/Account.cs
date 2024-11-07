using System.ComponentModel.DataAnnotations;

namespace Demo_GiaoHangSD19316.Models
{
    public class Account
    {
        
        public Guid Id { get; set; }
        [Required, MaxLength(255)]
        public string Name { get; set; }
        [Required, StringLength(450, MinimumLength = 6, ErrorMessage ="Bắt buộc nhập 6-450 kí tự")]
        public string UseName { get; set; }

        public string Password { get; set; }

        public DateTime NgaySinh { get; set; }
        [Required]
        [RegularExpression("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]d{3}[\\s.-]\\d{4}$",
        ErrorMessage = "số điên thoại phải đúng format xxx-")]
        //xxx-xxx-xxx
        public string SDT { get; set; }
        //đối tượng gh
        public GioHang? GioHang { get; set; } //đóng vai trò là khoá ngoại
        
    }
}
