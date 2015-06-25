using WebVideoPortal.Constants;
using WebVideoPortal.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVideoPortal.Models
{
    public class UserRegisterModel2 : UserRegisterModel
    {
        [IsTrue(ErrorMessage = Strings.AgreeTerms)]
        public bool IsAgree { get; set; }
    }
}
