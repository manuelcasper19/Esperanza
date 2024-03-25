using Esperanza.API.Helpers;
using Esperanza.API.UseCases.Interfaces;
using Esperanza.Shared.Entities;


namespace Esperanza.API.UseCases.Students
{
    public class AddStudentUseCase : IUseCaseWithParameter<Student>
    {
        private readonly List<Student> _students;
        public AddStudentUseCase(List<Student> students)
        {
            _students = students;
        }

        public Student Execute(Student student)
        {

            Validate(student);
            if (ValidateDataInput.ExistEntityByProperty(_students, s => s.Email, student.Email)) return null!;
            _students.Add(student);
            return student;
        }
        private void Validate(Student student)
        {
            ValidateDataInput.ValidateField(student.FullName, ValidateDataInput.IsFullnameValid);
            ValidateDataInput.ValidateField(student.Email, ValidateDataInput.IsValidEmail);
            ValidateDataInput.ValidateField(student.Password, ValidateDataInput.IsValidPassword);
        }
    }
}
