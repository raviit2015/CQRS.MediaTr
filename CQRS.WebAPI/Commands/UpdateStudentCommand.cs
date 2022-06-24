using CQRS.WebAPI.Model;
using MediatR;

namespace CQRS.WebAPI.Commands
{
    public record UpdateStudentCommand(string firstName, string lastName, double age,int id) : IRequest<Student>;
   
}
