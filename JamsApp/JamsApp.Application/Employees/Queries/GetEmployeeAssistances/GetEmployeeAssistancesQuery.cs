using AutoMapper;
using JamsApp.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Employees.Queries.GetEmployeeAssistances
{
    public class GetEmployeeAssistancesQuery : IGetEmployeeAssistancesQuery
    {
        private readonly IMapper _IMapper;
        private readonly IDatabaseService _IDatabaseService;
        private readonly IDatabaseComplexService _IDatabaseComplexService;

        public GetEmployeeAssistancesQuery(IMapper IMapper, IDatabaseService IDatabaseService, IDatabaseComplexService IDatabaseComplexService)
        {
            _IMapper = IMapper;
            _IDatabaseService = IDatabaseService;
            _IDatabaseComplexService = IDatabaseComplexService;
        }

        public List<GetEmployeeAssistancesModel> Execute(int employeeId, DateTime date)
        {
            var results = _IDatabaseComplexService.GetList<GetEmployeeAssistancesModel>(
                             "USP_SelAssistancesByEmployee",
                             new {employeeId = employeeId, date = date}
                           );

            List<GetEmployeeAssistancesModel> assistances = _IMapper.Map<List<GetEmployeeAssistancesModel>>(results);

            return assistances;
        }
    }
}
