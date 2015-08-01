using StudentSchedule.DbContexts;
using StudentSchedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentSchedule.Repositorys
{
    public class StudentRepository : IDisposable, StudentSchedule.Repositorys.IStudentRepository
    {
        private StudentDbContext _db = new StudentDbContext();

        //Get a List of all the students!

        public IList<Student> ListStudents()  // a METHOD with return type IList of Student
        {
            return _db.Students.ToList();
        }

        //Find a student by its Primary Key!

        public Student FindStudent(int id)
        {
            return _db.Students.Find(id);
        }

        //Add a new student to database
        public void CreateStudent(Student createdStudent)
        {
            _db.Students.Add(createdStudent);
            _db.SaveChanges();
        }

        //update an exsisting student in the database
        public void UpdateStudent(Student updatedStudent)
        {
            var originalStudent = this.FindStudent(updatedStudent.Id);
            originalStudent.FirstName = updatedStudent.FirstName;
            originalStudent.LastName = updatedStudent.LastName;
            _db.SaveChanges();
        }

        //Delete a student
        public void DeleteStudent(int id)
        {
            var studentToDelete = this.FindStudent(id);
            _db.Students.Remove(studentToDelete);
            _db.SaveChanges();

        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}