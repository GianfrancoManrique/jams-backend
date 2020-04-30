﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Schedules.Queries.GetSchedules
{
    public class GetSchedulesModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
