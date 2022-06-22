using ContosoUniversity.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {

        public static void Initialize(SchoolContext context)
        {
            users name = new users();
            context.Database.EnsureCreated();

            // Look for any userss.
            if (context.userss.Any())
            {
                return;   // DB has been seeded
            }
            if (context.Absences.Any())
            {
                return;   // DB has been seeded
            }
            if (context.Logins.Any())
            {
                return;   // DB has been seeded
            }
            {
                
            }
            var logins = new Login[]
           {
                new Login{UserName="admin",Password="test" }
           };
            foreach (Login l in logins)
            {


                context.Logins.Add(l);

            }

            context.SaveChanges();

            var users = new users[]
            {
            new users{FirstMidName="among us",LastName="sussy impasta" },
            new users{FirstMidName="Meredith",LastName="Alonso" },
            new users{FirstMidName="Arturo",LastName="Anand" },
            new users{FirstMidName="Gytis",LastName="Barzdukas"},
            new users{FirstMidName="Yan",LastName="Li"},
            new users{FirstMidName="Peggy",LastName="Justice"},
            new users{FirstMidName="Laura",LastName="Norman"},
            new users{FirstMidName="Nino",LastName="Olivetto"}
            };
            foreach (users s in users)
            {
                context.userss.Add(s);
            }
            context.SaveChanges();




            var Absences = new Absence[]
            {
                new Absence{userId=1, StartAbsence = new DateTime(2019, 1, 1), StopAbsence = new DateTime(2019, 1, 2), reason = "I'm sick", status = false},
                new Absence{userId=1, StartAbsence = new DateTime(2019, 1, 1), StopAbsence = new DateTime(2019, 1, 2), reason = "I'm sick", status = false}
            };
            foreach (Absence ab in Absences)

            {
                context.Absences.Add(ab);
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
            


            
        }
    }
}
    