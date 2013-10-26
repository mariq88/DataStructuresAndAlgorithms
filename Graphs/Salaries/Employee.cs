using System.Collections.Generic;

namespace Salaries
{
    class Employee
    {
        public int Id { get; set; }
        public long Salary { get; set; }
        public List<Employee> Employers { get; set; }

        public Employee(int id)
        {
            this.Id = id;
            this.Employers = new List<Employee>();
        }
    }
}