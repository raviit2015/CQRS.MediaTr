using CQRS.WebAPI.Commands;
using CQRS.WebAPI.Data;
using CQRS.WebAPI.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.WebAPI.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, Student>
    {
        private readonly IDataAccess _data;
        public DeleteStudentHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<Student> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.RemoveStudentById(request.Id));
        }
    }
}
