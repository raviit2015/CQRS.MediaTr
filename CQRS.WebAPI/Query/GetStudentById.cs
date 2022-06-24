using CQRS.WebAPI.Model;
using MediatR;

namespace CQRS.WebAPI.Query
{
    public class GetStudentById : IRequest<Student>
    {
        public int Id { get; }

        public GetStudentById(int id)
        {
            Id = id;
        }
    }
}
