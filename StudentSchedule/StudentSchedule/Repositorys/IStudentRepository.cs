using System;
namespace StudentSchedule.Repositorys
{
    public interface IStudentRepository
    {
        void CreateStudent(StudentSchedule.Models.Student createdStudent);
        void DeleteStudent(int id);
        StudentSchedule.Models.Student FindStudent(int id);
        System.Collections.Generic.IList<StudentSchedule.Models.Student> ListStudents();
        void UpdateStudent(StudentSchedule.Models.Student updatedStudent);
    }
}
