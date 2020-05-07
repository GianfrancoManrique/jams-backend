using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Employees.Queries.GetEmployeeAssistances
{
    public interface IGetEmployeeAssistancesQuery
    {
        List<GetEmployeeAssistancesModel> Execute(int employeeId, DateTime date);
    }
}
