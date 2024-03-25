
namespace Universidad.Shared.Entities
{
    public class Subject
    {
        private static int nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<StudentSubject>? StudentSubjects { get; set; }
        public Subject()
        {
            Id = nextId++;
        }
    }
}
