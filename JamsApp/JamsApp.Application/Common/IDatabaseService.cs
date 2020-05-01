using JamsApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Common
{
    public interface IDatabaseService
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Assistance> Assistances { get; set; }
        DbSet<Schedule> Schedules { get; set; }
        void Save();
    }
}
