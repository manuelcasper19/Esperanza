using Esperanza.API.Helpers;
using Universidad.Console.Helpers;
using Universidad.Console.UseCase.Interfaces;
using Universidad.Shared.Entities;

namespace Universidad.Console.UseCases.Students
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
            //if (string.IsNullOrWhiteSpace(student.FullName))
            //{
            //    throw new ArgumentException("El nombre es obligatorio.");
            //}

            //if (string.IsNullOrWhiteSpace(student.Email))
            //{
            //    throw new ArgumentException("El correo electrónico es obligatorio.");
            //}
            _students.Add(student);
            return student;
        }
        private void Validate(Student student)
        {
            ValidateDataInput.ValidateField(student.FullName, ValidateDataInput.IsFullnameValid);
            ValidateDataInput.ValidateField(student.Email, ValidateDataInput.IsValidEmail);
            ValidateDataInput.ValidateField(student.Password, ValidateDataInput.IsValidPassword);
            //Guard.AgainstNullOrEmpty(student.Name, nameof(student.Name));
            //Guard.AgainstNull(student.Name, nameof(student.Name));
        }
    }
}
