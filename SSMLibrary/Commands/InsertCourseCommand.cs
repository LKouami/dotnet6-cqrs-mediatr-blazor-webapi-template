using MediatR;
using SSMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMLibrary.Commands
{
    public record InsertCourseCommand(string Name) : IRequest<CourseModel>;
    //public class InsertCourseCommandClass : IRequest<CourseModel>
    //{
    //    public string Name { get; set; }

    //    public InsertCourseCommandClass(string name)
    //    {
    //        Name = name;
    //    }
    //}
}
