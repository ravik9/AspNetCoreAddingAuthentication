using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [StringLength(100)]
        [DataType("Password")]
        public string Password { get; set; }

        [Required]
        [MinLength(8)]
        [StringLength(100)]
        [DataType("Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
