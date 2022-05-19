using ContosoUniversity.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any userss.
            if (context.userss.Any())
            {
                return;   // DB has been seeded
            }

            var users = new users[]
            {
            new users{FirstMidName="among us",LastName="sussy impasta",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new users{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new users{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new users{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new users{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new users{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new users{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new users{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (users s in users)
            {
                context.userss.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{usersID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{usersID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{usersID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{usersID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{usersID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{usersID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{usersID=3,CourseID=1050},
            new Enrollment{usersID=4,CourseID=1050},
            new Enrollment{usersID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{usersID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{usersID=6,CourseID=1045},
            new Enrollment{usersID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}