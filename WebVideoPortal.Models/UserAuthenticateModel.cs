using WebVideoPortal.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVideoPortal.Models
{
    public class UserAuthenticateModel : BaseModel
    {
        [Required(ErrorMessage = "The email " + Strings.IsRequierd)]
        public string Email { get; set; }
        [Required(ErrorMessage = "The password " + Strings.IsRequierd)]
        public string Password { get; set; }
    }
}
