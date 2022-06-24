using CQRS.WebAPI.Commands;
using CQRS.WebAPI.Data;
using CQRS.WebAPI.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.WebAPI.Handlers
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly IDataAccess _data;
        public AddStudentHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddStudent(request.firstName, request.lastName, request.age));
        }
    }
}
