using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength =8)]
        [DataType(DataType.Password)]
        public  String Password{ get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match")]
        public String ConfirmPassword { get; set; }
    }
}
