using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Framework.Repository;

namespace Framework.Web.Domain
{
   public class LibraryContext : DbContext, IDbContext
   {

       public LibraryContext() : base ("LibraryConnection")
       {
           
       }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

         modelBuilder.Entity<Book>()
             .HasMany(c => c.Categories).WithMany(i => i.Books)
             .Map(t => t.MapLeftKey("BookID")
                 .MapRightKey("CategoryID")
                 .ToTable("BookCategory"));
      }

       public virtual new IDbSet<T> Set<T>() where T : class
       {
           return base.Set<T>();
       }
   }
}