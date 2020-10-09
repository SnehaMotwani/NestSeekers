using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWorks.Nest.Data.Model
{
   public class Status
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Property> Property { get; set; }
    }
}
