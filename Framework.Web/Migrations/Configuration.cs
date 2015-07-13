using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Framework.Web.Domain;

namespace Framework.Web.Migrations
{
    //internal sealed class Configuration : DbMigrationsConfiguration<SchoolContext>
    //{
    //    public Configuration()
    //    {
    //        AutomaticMigrationsEnabled = true;
    //    }

    //    protected override void Seed(SchoolContext context)
    //    {
    //        var students = new List<Student>
    //        {
    //            new Student { FirstMidName = "Carson",   LastName = "Alexander", 
    //                EnrollmentDate = DateTime.Parse("2010-09-01") },
    //            new Student { FirstMidName = "Meredith", LastName = "Alonso",    
    //                EnrollmentDate = DateTime.Parse("2012-09-01") },
    //            new Student { FirstMidName = "Arturo",   LastName = "Anand",     
    //                EnrollmentDate = DateTime.Parse("2013-09-01") },
    //            new Student { FirstMidName = "Gytis",    LastName = "Barzdukas", 
    //                EnrollmentDate = DateTime.Parse("2012-09-01") },
    //            new Student { FirstMidName = "Yan",      LastName = "Li",        
    //                EnrollmentDate = DateTime.Parse("2012-09-01") },
    //            new Student { FirstMidName = "Peggy",    LastName = "Justice",   
    //                EnrollmentDate = DateTime.Parse("2011-09-01") },
    //            new Student { FirstMidName = "Laura",    LastName = "Norman",    
    //                EnrollmentDate = DateTime.Parse("2013-09-01") },
    //            new Student { FirstMidName = "Nino",     LastName = "Olivetto",  
    //                EnrollmentDate = DateTime.Parse("2005-09-01") }
    //        };


    //        students.ForEach(s => context.Set<Student>().AddOrUpdate(p => p.LastName, s));
    //        context.SaveChanges();

    //        var instructors = new List<Instructor>
    //        {
    //            new Instructor { FirstMidName = "Kim",     LastName = "Abercrombie", 
    //                HireDate = DateTime.Parse("1995-03-11") },
    //            new Instructor { FirstMidName = "Fadi",    LastName = "Fakhouri",    
    //                HireDate = DateTime.Parse("2002-07-06") },
    //            new Instructor { FirstMidName = "Roger",   LastName = "Harui",       
    //                HireDate = DateTime.Parse("1998-07-01") },
    //            new Instructor { FirstMidName = "Candace", LastName = "Kapoor",      
    //                HireDate = DateTime.Parse("2001-01-15") },
    //            new Instructor { FirstMidName = "Roger",   LastName = "Zheng",      
    //                HireDate = DateTime.Parse("2004-02-12") }
    //        };
    //        instructors.ForEach(s => context.Set<Instructor>().AddOrUpdate(p => p.LastName, s));
    //        context.SaveChanges();

    //        var departments = new List<Department>
    //        {
    //            new Department { Name = "English",     Budget = 350000, 
    //                StartDate = DateTime.Parse("2007-09-01"), 
    //                PersonID  = instructors.Single( i => i.LastName == "Abercrombie").PersonID },
    //            new Department { Name = "Mathematics", Budget = 100000, 
    //                StartDate = DateTime.Parse("2007-09-01"), 
    //                PersonID  = instructors.Single( i => i.LastName == "Fakhouri").PersonID },
    //            new Department { Name = "Engineering", Budget = 350000, 
    //                StartDate = DateTime.Parse("2007-09-01"), 
    //                PersonID  = instructors.Single( i => i.LastName == "Harui").PersonID },
    //            new Department { Name = "Economics",   Budget = 100000, 
    //                StartDate = DateTime.Parse("2007-09-01"), 
    //                PersonID  = instructors.Single( i => i.LastName == "Kapoor").PersonID }
    //        };
    //        departments.ForEach(s => context.Set<Department>().AddOrUpdate(p => p.Name, s));
    //        context.SaveChanges();

    //        var courses = new List<Course>
    //        {
    //            new Course {CourseID = 1050, Title = "Chemistry",      Credits = 3,
    //              DepartmentID = departments.Single( s => s.Name == "Engineering").DepartmentID,
    //              Instructors = new List<Instructor>() 
    //            },
    //            new Course {CourseID = 4022, Title = "Microeconomics", Credits = 3,
    //              DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID,
    //              Instructors = new List<Instructor>() 
    //            },
    //            new Course {CourseID = 4041, Title = "Macroeconomics", Credits = 3,
    //              DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID,
    //              Instructors = new List<Instructor>() 
    //            },
    //            new Course {CourseID = 1045, Title = "Calculus",       Credits = 4,
    //              DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID,
    //              Instructors = new List<Instructor>() 
    //            },
    //            new Course {CourseID = 3141, Title = "Trigonometry",   Credits = 4,
    //              DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID,
    //              Instructors = new List<Instructor>() 
    //            },
    //            new Course {CourseID = 2021, Title = "Composition",    Credits = 3,
    //              DepartmentID = departments.Single( s => s.Name == "English").DepartmentID,
    //              Instructors = new List<Instructor>() 
    //            },
    //            new Course {CourseID = 2042, Title = "Literature",     Credits = 4,
    //              DepartmentID = departments.Single( s => s.Name == "English").DepartmentID,
    //              Instructors = new List<Instructor>() 
    //            },
    //        };
    //        courses.ForEach(s => context.Set<Course>().AddOrUpdate(p => p.CourseID, s));
    //        context.SaveChanges();

    //        var officeAssignments = new List<OfficeAssignment>
    //        {
    //            new OfficeAssignment { 
    //                PersonID = instructors.Single( i => i.LastName == "Fakhouri").PersonID, 
    //                Location = "Smith 17" },
    //            new OfficeAssignment { 
    //                PersonID = instructors.Single( i => i.LastName == "Harui").PersonID, 
    //                Location = "Gowan 27" },
    //            new OfficeAssignment { 
    //                PersonID = instructors.Single( i => i.LastName == "Kapoor").PersonID, 
    //                Location = "Thompson 304" },
    //        };
    //        officeAssignments.ForEach(s => context.Set<OfficeAssignment>().AddOrUpdate(p => p.Location, s));
    //        context.SaveChanges();

    //        AddOrUpdateInstructor(context, "Chemistry", "Kapoor");
    //        AddOrUpdateInstructor(context, "Chemistry", "Harui");
    //        AddOrUpdateInstructor(context, "Microeconomics", "Zheng");
    //        AddOrUpdateInstructor(context, "Macroeconomics", "Zheng");

    //        AddOrUpdateInstructor(context, "Calculus", "Fakhouri");
    //        AddOrUpdateInstructor(context, "Trigonometry", "Harui");
    //        AddOrUpdateInstructor(context, "Composition", "Abercrombie");
    //        AddOrUpdateInstructor(context, "Literature", "Abercrombie");

    //        context.SaveChanges();

    //        var enrollments = new List<Enrollment>
    //        {
    //            new Enrollment { 
    //                PersonID = students.Single(s => s.LastName == "Alexander").PersonID, 
    //                CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID, 
    //                Grade = Grade.A 
    //            },
    //             new Enrollment { 
    //                PersonID = students.Single(s => s.LastName == "Alexander").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID, 
    //                Grade = Grade.C 
    //             },                            
    //             new Enrollment { 
    //                PersonID = students.Single(s => s.LastName == "Alexander").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Macroeconomics" ).CourseID, 
    //                Grade = Grade.B
    //             },
    //             new Enrollment { 
    //                 PersonID = students.Single(s => s.LastName == "Alonso").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Calculus" ).CourseID, 
    //                Grade = Grade.B 
    //             },
    //             new Enrollment { 
    //                 PersonID = students.Single(s => s.LastName == "Alonso").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Trigonometry" ).CourseID, 
    //                Grade = Grade.B 
    //             },
    //             new Enrollment {
    //                PersonID = students.Single(s => s.LastName == "Alonso").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Composition" ).CourseID, 
    //                Grade = Grade.B 
    //             },
    //             new Enrollment { 
    //                PersonID = students.Single(s => s.LastName == "Anand").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID
    //             },
    //             new Enrollment { 
    //                PersonID = students.Single(s => s.LastName == "Anand").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Microeconomics").CourseID,
    //                Grade = Grade.B         
    //             },
    //            new Enrollment { 
    //                PersonID = students.Single(s => s.LastName == "Barzdukas").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Chemistry").CourseID,
    //                Grade = Grade.B         
    //             },
    //             new Enrollment { 
    //                PersonID = students.Single(s => s.LastName == "Li").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Composition").CourseID,
    //                Grade = Grade.B         
    //             },
    //             new Enrollment { 
    //                PersonID = students.Single(s => s.LastName == "Justice").PersonID,
    //                CourseID = courses.Single(c => c.Title == "Literature").CourseID,
    //                Grade = Grade.B         
    //             }
    //        };

    //        foreach (Enrollment e in enrollments)
    //        {
    //            var enrollmentInDataBase = context.Set<Enrollment>().Where(
    //                s =>
    //                     s.Student.PersonID == e.PersonID &&
    //                     s.Course.CourseID == e.CourseID).SingleOrDefault();
    //            if (enrollmentInDataBase == null)
    //            {
    //                context.Set<Enrollment>().Add(e);
    //            }
    //        }
    //        context.SaveChanges();
    //    }

    //    void AddOrUpdateInstructor(SchoolContext context, string courseTitle, string instructorName)
    //    {
    //        var crs = context.Set<Course>().SingleOrDefault(c => c.Title == courseTitle);
    //        var inst = crs.Instructors.SingleOrDefault(i => i.LastName == instructorName);
    //        if (inst == null)
    //            crs.Instructors.Add(context.Set<Instructor>().Single(i => i.LastName == instructorName));
    //    }
    //}

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LibraryContext context)
        {
            var books = new List<Book>
            {
                new Book { Title = "Program Entity Framework: Code First",   Publisher = "O'Reilly",
                    Author = "Julie Lerman", Rating = 3, Categories = new List<Category>()},
                new Book { Title = "C# in Depth",   Publisher = "Manning",
                    Author = "Jon Skeet", Rating = 4, Categories = new List<Category>() },
                new Book { Title = "JavaScript: The Good Parts",   Publisher = "O'Reilly",
                    Author = "Douglas Crockford", Rating = 3 , Categories = new List<Category>()},
                new Book { Title = "Mastering Web Application Development with AngularJS",   Publisher = "O'Reilly",
                    Author = "Pawel Kozlowski", Rating = 3, Categories = new List<Category>() },
                new Book { Title = "ASP.NET MVC 4 in Action",   Publisher = "Manning",
                    Author = "Jeffrey Palermo", Rating = 2, Categories = new List<Category>() }
            };


            books.ForEach(b => context.Set<Book>().AddOrUpdate(p => p.Title, b));
            context.SaveChanges();

    
            var categories = new List<Category>
            {
                new Category { CategoryID = 1050, Title = "Chemistry", 
                  Books = new List<Book>()
                },
                new Category { CategoryID = 1051, Title = "ASP.NET",
                  Books = new List<Book>()
                },
                new Category { CategoryID = 1052, Title = "JavaScript",
                  Books = new List<Book>(),
                },
                new Category { CategoryID = 1053, Title = "AngularJS",
                  Books = new List<Book>()
                }
            };
            categories.ForEach(c => context.Set<Category>().AddOrUpdate(p => p.CategoryID, c));
            context.SaveChanges();

  

            AddOrUpdateCategory(context, "Program Entity Framework: Code First", "ASP.NET");
            AddOrUpdateCategory(context, "C# in Depth", "ASP.NET");
            AddOrUpdateCategory(context, "JavaScript: The Good Parts", "JavaScript");
            AddOrUpdateCategory(context, "Mastering Web Application Development with AngularJS", "JavaScript");
            AddOrUpdateCategory(context, "Mastering Web Application Development with AngularJS", "AngularJS");
            AddOrUpdateCategory(context, "ASP.NET MVC 4 in Action", "ASP.NET");

            context.SaveChanges();

        }

        void AddOrUpdateCategory(LibraryContext context, string bookTitle, string category)
        {
            var book = context.Set<Book>().SingleOrDefault(c => c.Title == bookTitle);
            if (book == null) return;
            var cate = book.Categories.SingleOrDefault(i => i.Title == category);
            if (cate != null)
            {
                cate.Books.Add(context.Set<Book>().Single(i => i.Title == bookTitle));
            }


        }
    }

}
