using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ASPIdentityTest1.Models.CaseViewModels
{
    public class CaseViewModel
    {
        [Required]
        [Display(Name = "CASE NUMBER:")]
        public long CaseNumber { get; set; }
        [Required]
        [Display(Name = "Title:")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Description:")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "SalaryLevel:")]
        public SalaryLevel SalaryLevel { get; set; }
        [Required]
        [Display(Name = "Have you missed salary payment due to Phenix Payroll issue?")]
        public bool MissedSalary { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Select missed Pay Cycle:")]
        public DateTime PayCycle { get; set; }
        [Required]
        [Display(Name = "Priority:")]
        public Priority Priority { get; set; }
    }

    public enum SalaryLevel
    {
         L1,
         L2,
         L3,
         L4,
         L5
    }

    public enum Priority
    {
       High,
       Medium,
       Low
    }
}
