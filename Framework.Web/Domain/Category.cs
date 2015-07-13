﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Web.Domain
{
   public class Category
    {
      public int CategoryID { get; set; }

      [StringLength(50, MinimumLength = 3)]
      public string Title { get; set; }

      [Display(Name = "Book")]
      public int BookID { get; set; }

      public virtual ICollection<Book> Books { get; set; }
   }
}