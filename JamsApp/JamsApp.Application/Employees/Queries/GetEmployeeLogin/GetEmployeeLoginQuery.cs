using AutoMapper;
using JamsApp.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Employees.Queries.GetEmployeeLogin
{
    public class GetEmployeeLoginQuery : IGetEmployeeLoginQuery
    {
        private readonly IDatabaseComplexService _IDatabaseComplexService;
        private readonly IMapper _IMapper;

        public GetEmployeeLoginQuery(IDatabaseComplexService IDatabaseComplexService, IMapper IMapper)
        {
            _IDatabaseComplexService = IDatabaseComplexService;
            _IMapper = IMapper;
        }
        public GetEmployeeLoginModel Execute(string Username, string Password)
        {
            var result = _IDatabaseComplexService.GetSingle<GetEmployeeLoginModel>("USP_LoginEmployee",new {Username, Password});

            GetEmployeeLoginModel getEmployeeLoginModel = _IMapper.Map<GetEmployeeLoginModel>(result);

            return getEmployeeLoginModel;
        }
    }
}
