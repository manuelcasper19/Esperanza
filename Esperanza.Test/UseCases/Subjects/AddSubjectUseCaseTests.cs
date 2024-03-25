using Esperanza.Shared.Entities;
using System.ComponentModel;

namespace Esperanza.API.UseCases.Subjects.Tests
{
    public class AddSubjectUseCaseTests
    {
        [Fact()]
        [DisplayName("Add subject with valid values")]
        public void AddSubjectUseCaseTest()
        {
            var subject = new Subject { Name = "quimica" };
            var subjects = new List<Subject>();
            var addStudent = new AddSubjectUseCase(subjects);
            var result = addStudent.Execute(subject);
            Assert.NotNull(result);
            Assert.IsType<Subject>(result);
        }
        [Fact()]
        [DisplayName("Subject with empty name")]
        public void AddSubjectUseCaseTestEmptyName()
        {
            var subject = new Subject { Name = "" };
            var subjects = new List<Subject>();
            var addStudent = new AddSubjectUseCase(subjects);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(subject));
        }
        [Fact()]
        [DisplayName("Subject with null name")]
        public void AddSubjectUseCaseTestNullName()
        {
            var subject = new Subject();
            var subjects = new List<Subject>();
            var addStudent = new AddSubjectUseCase(subjects);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(subject));
        }
        [Fact()]
        [DisplayName("Subject with bad name")]
        public void AddSubjectUseCaseTestBadName()
        {
            var subject = new Subject { Name = "quimica23" }; ;
            var subjects = new List<Subject>();
            var addStudent = new AddSubjectUseCase(subjects);
            Assert.Throws<ArgumentException>(() => addStudent.Execute(subject));
        }
        [Fact()]
        [DisplayName("Subject exist by name")]
        public void AddSubjectUseCaseTestExistByName()
        {
            var subject = new Subject { Name = "quimica" }; 
            var subjects = new List<Subject>();
            subjects.Add(subject);
            var addStudent = new AddSubjectUseCase(subjects);
            var result = addStudent.Execute(subject);
            Assert.Null(result);        
        }
        [Fact()]
        [DisplayName("Subject not exist by name")]
        public void AddSubjectUseCaseTestNotExistByName()
        {
            var subject = new Subject { Name = "fisica" };
            var subject1 = new Subject { Name = "quimica" };
            var subjects = new List<Subject>();
            subjects.Add(subject);
            var addStudent = new AddSubjectUseCase(subjects);
            var result = addStudent.Execute(subject1);
            Assert.NotNull(result);
        }

    }
}