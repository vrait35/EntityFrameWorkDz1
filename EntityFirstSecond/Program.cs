using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            using(UniversityContext universityContext=new UniversityContext())
            {
                universityContext.Groups.Add(new Group
                {
                    Id = 1,
                    Name = "Sdp-172",
                });
                universityContext.Groups.Add(new Group
                {
                    Id = 2,
                    Name = "Sdp-171",
                });
                universityContext.Teachers.Add(new Teacher
                {
                    FullName = "Oleg Skidan"
                });
                universityContext.Teachers.Add(new Teacher
                {
                    FullName = "Mokrushin Evgeniy"
                });
                universityContext.Students.Add(new Student
                {
                    FullName = "Anuar Temirbulat",
                    IdGroup=1
                });
                universityContext.SaveChanges();
            }
            using(UniversityContext db=new UniversityContext())
            {
                foreach(Teacher teacher in db.Teachers)
                {
                    Console.WriteLine(teacher.Id+" - "+teacher.FullName);
                }
            }
        }
    }
}
