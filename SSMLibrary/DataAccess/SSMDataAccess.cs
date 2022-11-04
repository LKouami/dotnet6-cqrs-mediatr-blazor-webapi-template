using SSMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMLibrary.DataAccess
{
    public class SSMDataAccess : IDataAccess
    {
        private List<CourseModel> course = new();

        public SSMDataAccess()
        {
            course.Add(new CourseModel { Id = 1, Name = "Mathématiques 102" });
            course.Add(new CourseModel { Id = 2, Name = "Sciences Naturelles 102" });
        }

        public List<CourseModel> GetCourse()
        {
            return course;
        }

        public CourseModel InsertCourse(string Name)
        {
            CourseModel c = new() { Name = Name };
            c.Id = course.Max(x => x.Id) + 1;
            course.Add(c);
            return c;
        }
    }
}
