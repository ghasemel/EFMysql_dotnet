using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMysql
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataLayer.SchoolContext())
            {
                DataLayer.Standard stand = new DataLayer.Standard() { StandardName = "standard 1" };
                db.Standards.Add(stand);

                DataLayer.Student student = new DataLayer.Student() { StudentName = "رئوف", CurrentStandardId = stand.StandardId };
                db.Students.Add(student);

                db.SaveChanges();
            }
        }
    }
}
