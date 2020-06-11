
using System;
using System.ComponentModel.DataAnnotations;

namespace FormValidation.Models
{
    public class User
    {   
        [Required(ErrorMessage="Can I have your Last Name? ")]
        [Display(Name ="Last Name: ")]
        public string LastName {get;set;}
        [Required(ErrorMessage="Can I have your First Name? ")]
        [Display(Name = "First Name:")]
        public string FirstName{get;set;}
        [Required(ErrorMessage="Can I have your Age? ")]
        [Range(0,Int32.MaxValue,ErrorMessage="Please submit valid age!")]
        [Display(Name = "Age:")]
        public int Age{get;set;}
        [Required(ErrorMessage="Can I have your Email? ")]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string Email{get;set;}
        [Required(ErrorMessage="Please set a password for your security")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password{get;set;}
    }

}