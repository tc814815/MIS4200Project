using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Project.Models
{
    public class Doctor
    {
        
        [Key]
        public int doctorID { get; set; }
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="First Name is Required")]
        [StringLength(30)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
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

        [Display(Name = "How many years of experience do you have as Doctor?")]
        public DateTime doctorSince { get; set; }
        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)
        public ICollection<Patient> Patient { get; set; }
    }
}