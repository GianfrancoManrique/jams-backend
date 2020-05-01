using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Employees.Commands.PostEmployeeAssistance
{
    public interface IPostEmployeeAssistanceCommand
    {
        bool Execute(int EmployeeId, PostEmployeeAssistanceModel model);
    }
}
