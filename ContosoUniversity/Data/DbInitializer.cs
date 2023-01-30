using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SchoolContext>();

                context.Database.EnsureCreated();


                //Cinema
                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()
                    {
                        new Student()
                        {
                            FirstMidName="Carson",
                            LastName="Alexander",
                            EnrollmentDate=DateTime.Parse("2005-09-01")
                        },
                         new Student()
                        {
                           FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")
                        },
                         new Student()
                        {
                            FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")
                        },
                         new Student()
                        {
                            FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")
                        },
                         new Student()
                        {
                            FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")
                        },
                    });
                    context.SaveChanges();
                }
                //Cinema
                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course()
                        {
                           CourseID=1050,Title="Chemistry",Credits=3
                        },
                        new Course()
                        {
                           CourseID=4022,Title="Microeconomics",Credits=3
                        },
                        new Course()
                        {
                            CourseID=4041,Title="Macroeconomics",Credits=3
                        },
                         new Course()
                        {
                           CourseID=1045,Title="Calculus",Credits=4
                        },
                         new Course()
                        {
                            CourseID=3141,Title="Trigonometry",Credits=4
                        },
                          new Course()
                        {
                            CourseID=2021,Title="Composition",Credits=3
                        },
                           new Course()
                        {
                            CourseID=2042,Title="Literature",Credits=4
                        },
                    });
                    context.SaveChanges();
                }

                //Cinema
                if (!context.Enrollments.Any())
                {
                    context.Enrollments.AddRange(new List<Enrollment>()
                    {
                        new Enrollment()
                        {
                           StudentID=1,CourseID=1050,Grade=Grade.A
                        },
                        new Enrollment()
                        {
                           StudentID=1,CourseID=4022,Grade=Grade.C
                        },
                        new Enrollment()
                        {
                            StudentID=1,CourseID=4041,Grade=Grade.B
                        },
                         new Enrollment()
                        {
                           StudentID=2,CourseID=1045,Grade=Grade.B
                        },
                        new Enrollment()
                        {
                            StudentID=2,CourseID=3141,Grade=Grade.F
                        },
                        new Enrollment()
                        {
                            StudentID=2,CourseID=2021,Grade=Grade.F
                        },
                        new Enrollment()
                        {
                           StudentID=3,CourseID=1050
                        },
                        new Enrollment()
                        {
                           StudentID=4,CourseID=1050
                        },
                        new Enrollment()
                        {
                           StudentID=4,CourseID=4022,Grade=Grade.F
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}

