using WebVideoPortal.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVideoPortal.Models
{
    public class ResetPasswordModel : BaseModel
    {
        [Required]
        public Guid? UID { get; set; }
        [Required(ErrorMessage = "The new password " + Strings.IsRequierd)]
        [RegularExpression(Strings.PasswordPolicyRegex, ErrorMessage = Strings.PasswordPolicy)]
        [Display(Name = "New Password")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = Strings.PasswordNotMatch)]
        public string ConfirmPassword { get; set; }
    }
}
