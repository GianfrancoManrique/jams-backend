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
        public ScheduleController()
        {

        }

        [HttpGet]
        public IActionResult GetSchedules()
        {
            //var courses = _IgetCoursesQuery.Execute();
            return Ok();
        }
    }
}
