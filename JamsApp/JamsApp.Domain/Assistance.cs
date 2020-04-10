using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JamsApp.Domain
{
    public class Assistance
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required][MaxLength(2)]
        public string Type { get; set; }

        public DateTime FecCreation { get; set; }

        public bool State { get; set; }
    }
}
