using JamsApp.Application.Employees.Commands.PostEmployeeAssistance;
using JamsApp.Application.Employees.Queries.GetEmployeeAssistances;
using JamsApp.Application.Schedules.Queries.GetSchedules;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamsApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController: Controller
    {
        private readonly IPostEmployeeAssistanceCommand _IPostEmployeeAssistanceCommand;
        private readonly IGetEmployeeAssistancesQuery _IGetEmployeeAssistancesQuery;

       public EmployeeController(IPostEmployeeAssistanceCommand IPostEmployeeAssistanceCommand,
                                 IGetEmployeeAssistancesQuery IGetEmployeeAssistancesQuery)
        {
            _IPostEmployeeAssistanceCommand = IPostEmployeeAssistanceCommand;
            _IGetEmployeeAssistancesQuery = IGetEmployeeAssistancesQuery;
        }

        [HttpPost("{EmployeeId}/Assistance")]
        public IActionResult PostEmployeeAssistance(int EmployeeId, [FromBody] PostEmployeeAssistanceModel model)
        {
            if (model == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return new UnprocessableEntityObjectResult(ModelState);

            _IPostEmployeeAssistanceCommand.Execute(EmployeeId, model);

            return NoContent();
        }

        
        [HttpGet("{employeeId}/Assistances")]
        public IActionResult GetEmployeeAssistances(int employeeId, [FromQuery] DateTime date)
        {
            var assistances = _IGetEmployeeAssistancesQuery.Execute(employeeId, date);

            return Ok(assistances);
        }
    }
}
