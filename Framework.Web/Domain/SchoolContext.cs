using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Framework.Repository;

namespace Framework.Web.Domain
{
   public class SchoolContext : DbContext, IDbContext
   {
      //public DbSet<Course> Courses { get; set; }
      //public DbSet<Department> Departments { get; set; }
      //public DbSet<Enrollment> Enrollments { get; set; }
      //public DbSet<Instructor> Instructors { get; set; }
      //public DbSet<Student> Students { get; set; }
      //public DbSet<Employee> Employees { get; set; }
      //public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
      //public DbSet<Person> People { get; set; }

       public SchoolContext() : base ("SchoolConnection")
       {
           
       }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

         modelBuilder.Entity<Course>()
             .HasMany(c => c.Instructors).WithMany(i => i.Courses)
             .Map(t => t.MapLeftKey("CourseID")
                 .MapRightKey("PersonID")
                 .ToTable("CourseInstructor"));
      }

       public virtual new IDbSet<T> Set<T>() where T : class
       {
           return base.Set<T>();
       }
   }
}