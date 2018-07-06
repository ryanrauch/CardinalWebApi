using System;
using System.Collections.Generic;
using System.Text;

namespace CardinalWebApiLibrary.Models
{
    public class ApplicationOption
    {
        public Guid OptionId { get; set; }
        public Guid ItemGroupId { get; set; }
        public ItemGroup QuickGroup { get; set; }
    }
}
