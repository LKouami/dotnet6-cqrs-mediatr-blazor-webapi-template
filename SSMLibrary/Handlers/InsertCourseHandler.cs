using MediatR;
using SSMLibrary.Commands;
using SSMLibrary.DataAccess;
using SSMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMLibrary.Handlers
{
    public class InsertCourseHandler : IRequestHandler<InsertCourseCommand, CourseModel>
    {
        private readonly IDataAccess data;

        public InsertCourseHandler(IDataAccess data)
        {
            this.data = data;
        }
        public Task<CourseModel> Handle(InsertCourseCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(this.data.InsertCourse(request.Name));
        }
    }
}
