using System.ComponentModel.DataAnnotations;

namespace blogblog.ViewModel
{
    public class LoginUser
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bu alan gereklidir")]
        [Display(Name = "Password")]
        [DataType(DataType.Password, ErrorMessage = "postanız geçerli değil")]
        public string Password { get; set; }
    }
}
