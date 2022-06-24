using CQRS.WebAPI.Commands;
using CQRS.WebAPI.Data;
using CQRS.WebAPI.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.WebAPI.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, Student>
    {
        private readonly IDataAccess _data;
        public UpdateStudentHandler(IDataAccess data)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }
        public Task<Student> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.UpdateStudentById(request.firstName, request.lastName, request.age,request.id));
        }
    }
}
