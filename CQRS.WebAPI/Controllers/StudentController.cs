using CQRS.WebAPI.Commands;
using CQRS.WebAPI.Model;
using CQRS.WebAPI.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Student>> Get()
        {
            return await _mediator.Send(new GetStudentListQuery());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentByID(string id)
        {
            var studnet = await _mediator.Send(new GetStudentById(Convert.ToInt32(id)));
            return studnet != null ? Ok(studnet) : NotFound();
        }

        [HttpPost]
        public async Task<Student> Post([FromBody] Student value)
        {
            var model = new AddStudentCommand(value.FirstName, value.LastName, value.Age);
            return await _mediator.Send(model);
        }

        [HttpDelete("{id}")]
        public async Task<Student> RemoveStudent(string id)
        {
            var model = new DeleteStudentCommand(Convert.ToInt32(id));
            return await _mediator.Send(model);
        }

        [HttpPut("{id}")]
        public async Task<Student> UpdateStudent([FromBody] Student value,string id)
        {
            var model = new UpdateStudentCommand(value.FirstName, value.LastName, value.Age,Convert.ToInt32(id));
            return await _mediator.Send(model);
        }

    }
}
