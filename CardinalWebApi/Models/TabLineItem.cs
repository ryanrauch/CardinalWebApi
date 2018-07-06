using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalWebApi.Models
{
    public class TabLineItem
    {
        public Guid TabId { get; set; }
        public Tab Tab { get; set; }
        public int Order { get; set; }

        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
