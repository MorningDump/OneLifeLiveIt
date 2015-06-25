using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebVideoPortal.Constants;


namespace WebVideoPortal.Models
{
    public class UserRegisterModel : BaseModel
    {
        [Required(ErrorMessage = "The email " + Strings.IsRequierd)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "The password " + Strings.IsRequierd)]
        [RegularExpression(Strings.PasswordPolicyRegex, ErrorMessage = Strings.PasswordPolicy)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = Strings.PasswordNotMatch)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "The name " + Strings.IsRequierd)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The company name " + Strings.IsRequierd)]
        public string CompanyName { get; set; }
    }
}
