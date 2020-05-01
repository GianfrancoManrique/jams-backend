using AutoMapper;
using JamsApp.Application.Common;
using JamsApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Employees.Commands.PostEmployeeAssistance
{
    public class PostEmployeeAssistanceCommand : IPostEmployeeAssistanceCommand
    {
        private readonly IDatabaseService _database;
        private readonly IMapper _IMapper;

        public PostEmployeeAssistanceCommand(IDatabaseService database, IMapper IMapper)
        {
            _database = database;
            _IMapper = IMapper;
        }
        public bool Execute(int EmployeeId, PostEmployeeAssistanceModel model)
        {
            var assistance = _IMapper.Map<PostEmployeeAssistanceModel,Assistance>(model);
            assistance.EmployeeId = EmployeeId;
            _database.Assistances.Add(assistance);
            _database.Save();
            return true;
        }
    }
}
