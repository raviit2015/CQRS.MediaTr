using CQRS.WebAPI.Model;
using MediatR;
using System.Collections.Generic;

namespace CQRS.WebAPI.Query
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {
    }
}
