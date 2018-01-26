using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ASPIdentityTest1.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Department Name:")]
        public string DepartmentName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email:")]
        public string Email { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Verify:")]
        public string EmailConfirmed { get; set; }

        [Required]
        [Display(Name = "Street:")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "City:")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Province:")]
        public string Province { get; set; }

        [Required]
        [Display(Name = "Postal Code:")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Phone Number:")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Work Phone:")]
        public string WorkPhone { get; set; }
        [Required]
        [Display(Name = "Ext:")]
        public string Ext { get; set; }
        [Required]
        [Display(Name = "User Name:")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password:")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name = "Security Answer 1:")]
        public string SecurityAnswer1 { get; set; }
        [Required]
        [Display(Name = "Security Answer 2:")]
        public string SecurityAnswer2 { get; set; }
        [Required]
        [Display(Name = "Security Answer 2:")]
        public string SecurityAnswer3 { get; set; }
        //[Required]
        //[Display(Name = "Security Question 1:")]
        //public int SelectedQuestionId { get; set; }
        //public IEnumerable<SelectListItem> SecurityQuestion1 { get; set; }

        //[Required]
        //[Display(Name = "Security Answer 1:")]
        //public string SecurityAnswer1 { get; set; }

        //[Required]
        //[Display(Name = "Security Question 2:")]
        //public string SecurityQuestion2 { get; set; }
        //[Required]
        //[Display(Name = "Security Answer 2:")]
        //public string SecurityAnswer2 { get; set; }

        //[Required]
        //[Display(Name = "Security Question 3:")]
        //public string SecurityQuestion3 { get; set; }
        //[Required]
        //[Display(Name = "Security Answer 2:")]
        //public string SecurityAnswer3 { get; set; }
    }
}
