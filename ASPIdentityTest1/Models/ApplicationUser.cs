using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ASPIdentityTest1.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string WorkPhone { get; set; }
        public string Ext { get; set; }
        public string SecurityAnswer1 { get; set; }
        public string SecurityAnswer2 { get; set; }
        public string SecurityAnswer3 { get; set; }
    }
}
