using CQRS.WebAPI.Model;
using MediatR;

namespace CQRS.WebAPI.Commands
{
    public record DeleteStudentCommand(int Id) : IRequest<Student>;
}
