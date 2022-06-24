using CQRS.WebAPI.Model;
using MediatR;

namespace CQRS.WebAPI.Commands
{
    public record AddStudentCommand(string firstName, string lastName, double age) : IRequest<Student>;
}
