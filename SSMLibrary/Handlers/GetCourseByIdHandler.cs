using MediatR;
using SSMLibrary.Models;
using SSMLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMLibrary.Handlers
{
    public class GetCourseByIdHandler : IRequestHandler<GetCourseByIdQuery, CourseModel>
    {
        private readonly IMediator mediator;

        public GetCourseByIdHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<CourseModel> Handle(GetCourseByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await this.mediator.Send(new GetCourseListQuery());

            var output = results.FirstOrDefault(x => x.Id == request.Id);

            return output;
        }
    }
}
