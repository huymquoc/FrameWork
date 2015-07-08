using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Framework.Web.Domain
{
   public class OfficeAssignment
   {
      [Key]
      [ForeignKey("Instructor")]
      public int PersonID { get; set; }
      [StringLength(50)]
      [Display(Name = "Office Location")]
      public string Location { get; set; }

      public virtual Instructor Instructor { get; set; }
   }
}