using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Employees.Commands.PostEmployeeAssistance
{
    public class PostEmployeeAssistanceModel
    {
        //public int EmployeeId { get; set; }
        public bool State { get; set; }
        public string Type { get; set; }
        public DateTime FecCreation { get; set; }
    }
}
