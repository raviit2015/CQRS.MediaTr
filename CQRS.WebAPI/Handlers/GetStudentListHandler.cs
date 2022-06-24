using CQRS.WebAPI.Data;
using CQRS.WebAPI.Model;
using CQRS.WebAPI.Query;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.WebAPI.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IDataAccess _data;
        public GetStudentListHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudents());
        }
    }
}
