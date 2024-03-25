using System.ComponentModel;
using Esperanza.Shared.Entities;

namespace Esperanza.API.UseCases.Students.Tests
{
    public class AddStudentUseCaseTests
    {
        [Fact()]
        [DisplayName("Add student with valid values")]
        public void AddStudentUseCaseTest()
        {
            var student = new Student { FullName = "test", Email="test1@test.com", Password="123456" };
            var students = new List<Student>();
            var addStudent = new AddStudentUseCase(students);
            var result = addStudent.Execute(student);
            Assert.NotNull(result);
            Assert.IsType<Student>(result);
        }

        [Fact()]
        [DisplayName("student with empty name")]
        public void AddStudentUseCaseTestEmptyName()
        {
            var student = new Student { FullName="", Email = "test1@test.com", Password = "123456" };
            var students = new List<Student>();
            var addStudent = new AddStudentUseCase(students);      
            Assert.Throws<ArgumentException>(() => addStudent.Execute(student));
        }     

        [Fact()]
        [DisplayName("student with null name")]
        public void AddStudentUseCaseTestNullName()
        {
            var student = new Student { Email = "test1@test.com", Password = "123456" };
            var students = new List<Student>();
            var addStudent = new AddStudentUseCase(students);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(student));
        }
        [Fact()]
        [DisplayName("student with empty email")]
        public void AddStudentUseCaseTestEmptyEmail()
        {
            var student = new Student { FullName = "STIVEN", Email = "", Password = "123456" };
            var students = new List<Student>();
            var addStudent = new AddStudentUseCase(students);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(student));
        }

        [Fact()]
        [DisplayName("student with null name")]
        public void AddStudentUseCaseTestNullEmail()
        {
            var student = new Student { FullName = "STIVEN", Password = "123456" };
            var students = new List<Student>();
            var addStudent = new AddStudentUseCase(students);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(student));
        }
        [Fact()]
        [DisplayName("student with invalid email address")]
        public void AddStudentUseCaseTestNotFormatEmail()
        {
            var student = new Student { FullName = "STIVEN", Email = "test.com", Password = "123456" };
            var students = new List<Student>();
            var addStudent = new AddStudentUseCase(students);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(student));
        }
        [Fact()]
        [DisplayName("student with empty password")]
        public void AddStudentUseCaseTestEmptyPassword()
        {
            var student = new Student { FullName = "STIVEN", Email = "test1@test.com", Password = "" };
            var students = new List<Student>();
            var addStudent = new AddStudentUseCase(students);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(student));
        }
        [Fact()]
        [DisplayName("student with null password")]
        public void AddStudentUseCaseTestNullPassword()
        {
            var student = new Student { FullName = "STIVEN", Email = "test1@test.com"  };
            var students = new List<Student>();
            var addStudent = new AddStudentUseCase(students);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(student));
        }
        [Fact()]
        [DisplayName("student with short password")]
        public void AddStudentUseCaseTestShortPassword()
        {
            var student = new Student { FullName = "STIVEN", Email = "test1@test.com", Password = "1234" };
            var students = new List<Student>();
            var addStudent = new AddStudentUseCase(students);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(student));
        }
    }
}