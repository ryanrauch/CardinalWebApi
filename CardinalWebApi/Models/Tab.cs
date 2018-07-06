using CardinalWebApiLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalWebApi.Models
{
    public class Tab
    {
        public Guid TabId { get; set; }
        public TabState CurrentState { get; set; }
        public DateTime TimestampOpened { get; set; }
        public DateTime TimestampClosed { get; set; }
        public DateTime TimestampFinalized { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardToken { get; set; }
        
        public List<TabLineItem> Items { get; set; }
    }
}
