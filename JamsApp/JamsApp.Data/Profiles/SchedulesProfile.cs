using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using JamsApp.Application.Schedules.Queries.GetSchedules;
using JamsApp.Domain;

namespace JamsApp.Data.Profiles
{
    public class SchedulesProfile: Profile
    {
        public SchedulesProfile()
        {
            this.CreateMap<Schedule, GetSchedulesModel>();
        }
    }
}
