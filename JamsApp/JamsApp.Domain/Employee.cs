using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JamsApp.Domain
{
    public class Employee
    {
        public Employee()
        {
            Assistances = new List<Assistance>();
        }
        [Key]
        public int Id { get; set; }

        [Required][MaxLength(2)]
        public string DocumentType { get; set; }

        [Required][MaxLength(2)]
        public string DocumentNumber { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        [Required][MaxLength(2)]
        public string EmployeeType { get; set; }

        public float Salary { get; set; }

        [Required]
        public int ScheduleId { get; set; }

        public Schedule Schedule { get; set; }

        public bool State { get; set; }

        public List<Assistance> Assistances { get; set; }
    }
}
