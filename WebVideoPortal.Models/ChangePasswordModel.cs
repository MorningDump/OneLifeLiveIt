using WebVideoPortal.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVideoPortal.Models
{
    public class ChangePasswordModel : BaseModel
    {
        [Required(ErrorMessage = "The old password " + Strings.IsRequierd)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "The new password " + Strings.IsRequierd)]
        [RegularExpression(Strings.PasswordPolicyRegex, ErrorMessage = Strings.PasswordPolicy)]
        [Display(Name = "New Password")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = Strings.PasswordNotMatch)]
        public string ConfirmPassword { get; set; }
    }
}
