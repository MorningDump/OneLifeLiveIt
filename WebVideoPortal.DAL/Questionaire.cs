//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebVideoPortal.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Questionaire
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int YearOfBirth { get; set; }
        public string Sex { get; set; }
        public string Occupation { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string ActivityLevel { get; set; }
    
        public virtual User User { get; set; }
    }
}
