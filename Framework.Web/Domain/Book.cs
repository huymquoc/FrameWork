using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Web.Domain
{
   public class Book
    {
      public int BookID { get; set; }

      [StringLength(50, MinimumLength = 3)]
      public string Title { get; set; }

      [StringLength(20, MinimumLength = 3)]
      public string Publisher { get; set; }

      [StringLength(20, MinimumLength = 3)]
      public string Author { get; set; }

      [Range(0, 5)]
      public int Rating { get; set; }

      public virtual ICollection<Category> Categories { get; set; }
      public virtual ICollection<Transaction> Transactions { get; set; }
    }
}