using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Employees.Queries.GetEmployeeLogin
{
    public interface IGetEmployeeLoginQuery
    {
        GetEmployeeLoginModel Execute(string Username, string Password);
    }
}
