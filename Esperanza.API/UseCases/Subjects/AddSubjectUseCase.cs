using Esperanza.API.Helpers;
using Esperanza.API.UseCases.Interfaces;
using Esperanza.Shared.Entities;

namespace Esperanza.API.UseCases.Subjects
{
    public class AddSubjectUseCase : IUseCaseWithParameter<Subject>
    {
        private readonly List<Subject> _subjects;

        public AddSubjectUseCase(List<Subject> subjects)
        {
            _subjects = subjects;
        }

        public Subject Execute(Subject subject)
        {
            Validate(subject);
            _subjects.Add(subject);
            return subject;
        }
        private void Validate(Subject subject)
        {
            ValidateDataInput.ValidateField(subject.Name, ValidateDataInput.IsFullnameValid);
        }
    }
}
