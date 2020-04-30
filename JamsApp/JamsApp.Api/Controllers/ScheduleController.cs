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
    public class ScheduleController: Controller
    {
        private readonly IGetSchedulesQuery _IGetSchedulesQuery;

        public ScheduleController(IGetSchedulesQuery IGetSchedulesQuery)
        {
            _IGetSchedulesQuery = IGetSchedulesQuery;
        }

        [HttpGet]
        public IActionResult GetSchedules()
        {
            var courses = _IGetSchedulesQuery.Execute();
            return Ok(courses);
        }
    }
}
