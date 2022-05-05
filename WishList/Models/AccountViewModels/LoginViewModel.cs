using System;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class LoginViewModel
    {

        [DataType(DataType.EmailAddress)]
        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public String Password { get; set; }
        

    }
}
