using CQRS.WebAPI.Model;
using System.Collections.Generic;

namespace CQRS.WebAPI.Data
{
    public interface IDataAccess
    {
        Student AddStudent(string firstName, string lastName, double age);
        Student GetStudentById(int id);
        List<Student> GetStudents();
        Student RemoveStudentById(int id);
        Student UpdateStudentById(string firstName, string lastName, double age, int id);
    }
}