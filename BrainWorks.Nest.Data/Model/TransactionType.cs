using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWorks.Nest.Data.Model
{
    public class TransactionType
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public IList<Requests> Request{ get; set; }
    }
}
