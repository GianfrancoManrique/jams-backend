using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JamsApp.Domain
{
    public class Schedule
    {
        public Schedule()
        {
            Employees = new List<Employee>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int Description { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        public bool State { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
