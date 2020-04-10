using JamsApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JamsApp.Data
{
    public static class DatabaseInitializer
    {
        public static void Seed(DatabaseService database)
        {
            if (!database.Schedules.Any())
            {
                database.AddRange( 
                new Schedule{Description = "Horario-1",Start=DateTime.Now,End=DateTime.Now,State=true},
                new Schedule { Description = "Horario-1", Start = DateTime.Now, End = DateTime.Now, State = true },
                new Schedule { Description = "Horario-1", Start = DateTime.Now, End = DateTime.Now, State = true }
                );
            }

            database.SaveChanges();
        }
    }
}
