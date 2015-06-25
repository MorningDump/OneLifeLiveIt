using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVideoPortal.Models
{
    public abstract class BaseModel
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
        public string InformationMessage { get; set; }
        public bool IsWizardMode { get; set; }

        public BaseModel()
        {
            IsValid = true;
        }
    }
}
