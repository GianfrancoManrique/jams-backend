using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Employees.Queries.GetEmployeeLogin
{
    public interface IGetEmployeeQuery
    {
        GetEmployeeModel Execute(string Username, string Password);
    }
}
