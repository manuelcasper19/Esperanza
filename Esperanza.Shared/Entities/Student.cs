
namespace Universidad.Shared.Entities
{
    public class Student
    {
        private static int nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<StudentSubject>? StudentSubjects { get; set; }
        public double Average { get; set; }
        public Student()
        {
            Id = nextId++;
        }
    }
}
