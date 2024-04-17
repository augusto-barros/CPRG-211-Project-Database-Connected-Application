using Microsoft.EntityFrameworkCore;

namespace Lab4 
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}


namespace Lab4 
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
    }
}

