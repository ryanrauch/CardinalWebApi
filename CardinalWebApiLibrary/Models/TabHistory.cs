using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalWebApiLibrary.Models
{
    public class TabHistory
    {
        public Guid TabHistoryId { get; set; }
        public Guid TabId { get; set; }
        public Tab Tab { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime Timestamp { get; set; }
        public string ActionText { get; set; }
    }
}
