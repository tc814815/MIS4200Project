using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Project.Models
{

    
    public class Appointment
    {

        public System.Guid SID { get; set; }


        [Key]
        public int appointmentID { get; set; }
        
        [Display(Name = "Appointment Date")]
        public DateTime appointmentDate { get; set; }
        
        [Display(Name = "Appointment Description")]
        [Required(ErrorMessage = "Describe what happened at the appointment")]
        [StringLength(500)]
        public string appointmentDescription { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
        
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}