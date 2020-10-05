using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BrainWorks.Nest.Data.Model
{
    public class Requests
    {
        public int ID { get; set; }
        public int PropertyId { get; set; }  //foreign key
        public Property Property { get; set; }

        public int TransactionType { get; set; }  //foreign key
        public TransactionType TransactionTypes { get; set; }   //reference of table for fk
        public Decimal AmountRequested { get; set; }
        public Decimal Rate { get; set; }
        public DateTime AvailiableOn { get; set; }
        public DateTime DateAdded { get; set; }
        public IList<Property> Properties{ get; set; }
        public IList<TransactionType> TransactionsType { get; set; }
    }
}
