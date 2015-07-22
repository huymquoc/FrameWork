using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Web.Domain
{
   public class Copy
    {
      public int CopyID { get; set; }

      [DisplayName("Book")]
      public string BookID { get; set; }

      [DisplayName("Transaction")]
      public string TransactionID { get; set; }

      public DateTime TransactionDate { get; set; }

      public int TransactionType { get; set; }

      public virtual Book Book { get; set; }
      public virtual Transaction Transaction { get; set; }
   }
}