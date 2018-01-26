using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIdentityTest1.Models
{
    public class Case
    {
        public long Id { get; set; }
        public long CaseNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SalaryLevel { get; set; }
        public bool MissedSalary { get; set; }
        public DateTime PayCycle { get; set; }
        public string Priority { get; set; }
    }
}
