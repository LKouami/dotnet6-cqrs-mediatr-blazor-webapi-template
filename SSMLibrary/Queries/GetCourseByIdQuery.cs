using MediatR;
using SSMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMLibrary.Queries
{
    public record GetCourseByIdQuery(int Id) : IRequest<CourseModel>;
    //public class GetCourseByIdQueryClass
    //{
    //    public int Id { get; set; }

    //    public GetCourseByIdQueryClass(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
