using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Project.Models
{
    public class Patient
    {
      public System.Guid SID { get; set; }

        [Key]
        public int patientID { get; set; }
        [Display(Name = "Patient First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(30)]
        public string firstName { get; set; }
        [Display(Name = "Patient Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(30)]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter your most frequently used Email address")]
        [StringLength(30)]
        public string email { get; set; }
        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number is Required")]
        public string phone { get; set; }
        [Display(Name = "When did you become a registered patient?")]
        public DateTime patientSince { get; set; }

        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}