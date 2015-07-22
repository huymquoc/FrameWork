using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Web.Domain
{
   public class Book
    {
      public int BookID { get; set; }

      public string Title { get; set; }

      public string Publisher { get; set; }

      public string Author { get; set; }

      [Range(0, 5)]
      public int Rating { get; set; }

      public int Amount { get; set; }

      public DateTime ReceivedDate { get; set; }  

      public virtual ICollection<Category> Categories { get; set; }
      public virtual ICollection<Copy> Copies { get; set; }
    }
}