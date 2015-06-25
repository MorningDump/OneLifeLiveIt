using WebVideoPortal.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVideoPortal.Models
{
    public class ForgotPasswordModel : BaseModel
    {
        [Required(ErrorMessage = "The email " + Strings.IsRequierd)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
