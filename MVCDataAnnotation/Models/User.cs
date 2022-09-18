using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Antlr.Runtime;

namespace MVCDataAnnotation.Models
{
    public class User
    {
        [Display(Name = "User Name:")]
        [Required(ErrorMessage = "User Field Cannot be left empty")]
        [RegularExpression(@"[A-Za-z\s]{3,}", ErrorMessage = "Name can have alphabets and spaces with min size of 3")]
        public string Name { get; set; }

        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Field Cannot be left Empty")]
        [RegularExpression(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$_-])(?=\S+$).{8,16}", ErrorMessage = "Password  Format: < br /> -No spaces.< br /> -Minimum 1 numeric.< br /> -Minimum 1 upper case &lower case alphabet.< br /> -Minimum 1, any of these Special characters: -, _, @, #, $.<br />-Should be ranging between 8 - 16 chars.")]
        public string Password { get; set; }
        [Display(Name = "Conform Password:")]
        [Required(ErrorMessage = "Conform Password Field Cannot be left Empty")]
        [DataType(DataType.Password)]
        [Compare ("Password",ErrorMessage ="Conform Password should match with password")]
        public string ConformPassword { get; set; }

        [Display(Name="Date Of Birth:")]
        [DataType (DataType.Date)]
        [Required(ErrorMessage ="Date of Birth Cannot be left Empty")]
        public DateTime DOB { get; set; }

        [Display(Name="Mobile Number:")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Mobile No. should start with 6, 7, 8, and 9 only and can be having a length of 10 digits(Both Max & Min).")]
        public string Mobile { get; set; }

        [Display(Name="Email Id:")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name="Address:")]
        public string Address { get; set; }
    }
}