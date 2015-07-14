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

      [DisplayName("Copy")]
      public string CopyID { get; set; }

      [DisplayName("Borrower")]
      public string BorrowerID { get; set; }

      public DateTime TransactionDate { get; set; }

      public DateTime DueDate { get; set; }

      public int TransactionType { get; set; }

      public virtual Copy Copy { get; set; }
      public virtual Borrower Borrower { get; set; }
   }
}