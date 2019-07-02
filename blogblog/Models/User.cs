using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogblog.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir")]
        [Display(Name = "EmailAddress")]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = "Bu alan gereklidir")]
        [Display(Name = "Username")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Bu alan gereklidir")]
        [Display(Name = "Password")]
        [DataType(DataType.Password, ErrorMessage = "postanız geçerli değil")]
        public string Password { get; set; }
    }
}
