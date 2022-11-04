using MediatR;
using Microsoft.AspNetCore.Mvc;
using SSMLibrary.Commands;
using SSMLibrary.Models;
using SSMLibrary.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SSMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IMediator mediator;

        public CourseController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public async Task<List<CourseModel>> Get()
        {
            return await this.mediator.Send(new GetCourseListQuery());
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public async Task<CourseModel> Get(int id)
        {
            return await this.mediator.Send(new GetCourseByIdQuery(id));
        }

        // POST api/<CourseController>
        [HttpPost]
        public async Task<CourseModel> Post([FromBody] CourseModel value)
        {
            //var model = new InsertCourseCommand(value.Name);
            return await mediator.Send(new InsertCourseCommand(value.Name));
        }

        //// PUT api/<CourseController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CourseController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
