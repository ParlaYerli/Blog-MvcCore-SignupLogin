using blogblog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogblog.ViewModel
{
    public class SignUser
    {
        public int UserID { get; set; }

        [EmailAddress]
        [Required(AllowEmptyStrings = false,  ErrorMessage = "Maili eksik girdiniz,lütfen maili doldurunuz.")]
        [Display(Name = "EmailAddress")]
        public string EmailAddress { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Adı eksik girdiniz,lütfen adı doldurunuz")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Şifreyi eksik girdiniz,lütfen maili doldurunuz")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        
        public string Password { get; set; }
    }
}
