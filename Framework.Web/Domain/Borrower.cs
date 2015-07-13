using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Web.Domain
{
   public class Borrower : Person
    { 

        [StringLength(100)]
        public string Address { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}