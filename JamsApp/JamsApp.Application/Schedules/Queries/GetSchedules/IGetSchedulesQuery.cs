using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Schedules.Queries.GetSchedules
{
    public interface IGetSchedulesQuery
    {
        List<GetSchedulesModel> Execute();
    }
}
