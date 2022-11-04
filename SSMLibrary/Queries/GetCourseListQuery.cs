using MediatR;
using SSMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMLibrary.Queries
{
    public record GetCourseListQuery() : IRequest<List<CourseModel>>;

    //public class GetCourseListQueryClass : IRequest<List<CourseModel>>
    //{

    //}
}
