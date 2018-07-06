using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalWebApiLibrary.Models
{
    public class TabItem
    {
        public Guid TabId { get; set; }
        public Tab Tab { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
