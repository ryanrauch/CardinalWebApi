using System;
using System.Collections.Generic;
using System.Text;

namespace CardinalWebApiLibrary.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PinCode { get; set; }
    }
}
