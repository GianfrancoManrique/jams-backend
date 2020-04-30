using AutoMapper;
using JamsApp.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Schedules.Queries.GetSchedules
{
    public class GetSchedulesQuery : IGetSchedulesQuery
    {
        private readonly IDatabaseService _database;
        private readonly IMapper _IMapper;

        public GetSchedulesQuery(IDatabaseService database, IMapper IMapper)
        {
            _database = database;
            _IMapper = IMapper;
        }

        public List<GetSchedulesModel> Execute()
        {
            var courses = _database.Schedules;
            List<GetSchedulesModel> schedules = _IMapper.Map<List<GetSchedulesModel>>(courses);
            return schedules;
        }
    }
}
