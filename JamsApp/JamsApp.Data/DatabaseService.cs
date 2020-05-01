using JamsApp.Application.Common;
using JamsApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Data
{
    public class DatabaseService:DbContext, IDatabaseService
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Assistance> Assistances { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
        {
            this.Database.AutoTransactionsEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
