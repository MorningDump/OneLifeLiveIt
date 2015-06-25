using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebVideoPortal.Constants;
using WebVideoPortal.Constants.Enums;

namespace WebVideoPortal.Models
{
    public class QuestionaireModel :BaseModel
    {
        [Required(ErrorMessage = "The year of birth " + Strings.IsRequierd)]
        public int YearOfBirth { get; set; }
        [Required(ErrorMessage = "The sex " + Strings.IsRequierd)]
        public Sex Sex { get; set; }
        [Required(ErrorMessage = "The occupation " + Strings.IsRequierd)]
        public string Occupation { get; set; }
        [Required(ErrorMessage = "The height " + Strings.IsRequierd)]
        public string Height { get; set; }
        [Required(ErrorMessage = "The weight " + Strings.IsRequierd)]
        public string Weight { get; set; }
        [Required(ErrorMessage = "The activity level " + Strings.IsRequierd)]
        public ActivityLevel ActivityLevel { get; set; }
    }
}
