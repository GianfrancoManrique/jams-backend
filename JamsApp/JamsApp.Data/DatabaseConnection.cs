﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace JamsApp.Data
{
    public class DatabaseConnection
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(@"Server=tcp:jamsdes.database.windows.net,1433;Initial Catalog=JamsDB;Persist Security Info=False;User ID=jamsadmin;Password=Qazw3579@_;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                //return new SqlConnection(Configuration.GetConnectionString("Devmaster"));
            }
        }
    }
}
