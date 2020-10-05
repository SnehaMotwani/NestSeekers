using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWorks.Nest.Data.Model
{
    public class PropertyType
    {
        public int ID { get; set; }  //primary key
        public String Name { get; set; }
        public String Description { get; set; }
        public List<Property> Property { get; set; }
    }
}
