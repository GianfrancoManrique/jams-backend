using JamsApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Data
{
    public class JamsContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Assistance> Assistances { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:jamsdes.database.windows.net,1433;Initial Catalog=JamsDB;Persist Security Info=False;User ID=jamsadmin;Password=Qazw3579@_;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
