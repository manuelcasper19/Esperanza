namespace Esperanza.Shared.Entities
{
    public class Student
    {
        private static int nextId = 1;
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<StudentSubject>? StudentSubjects { get; set; }
        public double Average { get; }
        public Student()
        {
            Id = nextId++;
        }
    }
}
