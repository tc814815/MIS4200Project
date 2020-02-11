using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Project.Models
{
    public class Patient
    {
      [Key]
        public int patientID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime patientSince { get; set; }

        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}