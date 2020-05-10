using JamsApp.Application.Employees.Commands.PostEmployeeAssistance;
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

        public EmployeeController(IPostEmployeeAssistanceCommand IPostEmployeeAssistanceCommand)
        {
            _IPostEmployeeAssistanceCommand = IPostEmployeeAssistanceCommand;
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
    }
}
