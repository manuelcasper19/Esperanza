namespace Esperanza.Shared.Entities
{
    public class StudentSubject
    {
        public Student? Student { get; set; }
        public Subject? Subject { get; set; }
        public double[]? Scores { get; set; }
        public double Average { get; }

    }
}
