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

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
