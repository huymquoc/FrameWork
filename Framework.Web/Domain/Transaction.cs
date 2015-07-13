using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Web.Domain
{
   public class Transaction
    {
      public int TransactionID { get; set; }

      [DisplayName("BookID")]
      public string BookID { get; set; }

      [DisplayName("BorrowerID")]
      public string BorrowerID { get; set; }

      public DateTime TransactionDate { get; set; }

      public int TransactionType { get; set; }

      public virtual Book Book { get; set; }
      public virtual Borrower Borrower { get; set; }
   }
}