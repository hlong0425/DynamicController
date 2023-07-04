namespace Domain.Models
{
    public class Student : EntityBase
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Subject { get; set; }

        public string MainClass { get; set; }   
    }
}