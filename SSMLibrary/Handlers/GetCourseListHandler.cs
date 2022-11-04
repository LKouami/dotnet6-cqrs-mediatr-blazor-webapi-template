using MediatR;
using SSMLibrary.DataAccess;
using SSMLibrary.Models;
using SSMLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMLibrary.Handlers
{
    public class GetCourseListHandler : IRequestHandler<GetCourseListQuery, List<CourseModel>>
    {
        private readonly IDataAccess _data;

        public GetCourseListHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<CourseModel>> Handle(GetCourseListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetCourse());
        }
    }
}
