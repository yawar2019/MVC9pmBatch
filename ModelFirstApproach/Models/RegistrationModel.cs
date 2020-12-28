using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelFirstApproach.Models
{
    public class RegistrationModel
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage ="Employee Name Cannot be Empty")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string  Password { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        [Compare("Password",ErrorMessage ="Password and Confirm Password Mismatch")]
        public string ConfirmPassword { get; set; }
        [Range(18,50,ErrorMessage ="18-50 is Allowed")]
        public string Age { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Email Id is Not Valid")]
        public string EmailId { get; set; }
        [StringLength(20,ErrorMessage ="Only 20 Character are Allowed")]
        public string Address { get; set; }
    }
}