using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWorks.Nest.Data.Model
{
    public class Document
    {
        public int ID { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        public String Name { get; set; }
        public byte[] Value { get; set; }
        public IList<Property> Properties { get; set; }

    }
}
