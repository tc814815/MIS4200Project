using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Project.Models
{
    public class Appointment
    {
        [Key]
        public int appointmentID { get; set; }

        public DateTime appointmentDate { get; set; }
        public string apoointmentDescription { get; set; }
        public int patietntD { get; set; }
        public virtual Patient Patient { get; set; }
        
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}