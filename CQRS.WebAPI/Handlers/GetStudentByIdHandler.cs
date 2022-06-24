using CQRS.WebAPI.Data;
using CQRS.WebAPI.Model;
using CQRS.WebAPI.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.WebAPI.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentById, Student>
    {
        private readonly IDataAccess _data;
        public GetStudentByIdHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<Student> Handle(GetStudentById request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudentById(request.Id));
        }
    }
}
