using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using JamsApp.Application.Employees.Commands.PostEmployeeAssistance;
using JamsApp.Domain;

namespace JamsApp.Data.Profiles
{
    public class AssistancesProfile: Profile
    {
        public AssistancesProfile()
        {
            this.CreateMap<PostEmployeeAssistanceModel, Assistance>();
        }
    }
}
