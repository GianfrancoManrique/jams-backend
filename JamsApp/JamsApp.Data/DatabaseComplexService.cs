using JamsApp.Application.Common;
using JamsApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Linq;

namespace JamsApp.Data
{
    public class DatabaseComplexService: DatabaseConnection, IDatabaseComplexService
    {
        
        public DatabaseComplexService(IConfiguration configuration) : base(configuration)
        {
            
        }

        public List<T> GetList<T>(string spName, object parameters = null) where T : class
        {
            List<T> list;
            using (System.Data.IDbConnection cn = Connection)
            {
                cn.Open();
                list = cn.Query<T>(spName, parameters, commandType: CommandType.StoredProcedure).ToList();
            }

            return list;
        }

        public T GetSingle<T>(string spName, object parameters = null) where T : class
        {
            T item;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                item = cn.Query<T>(spName, parameters, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }

            return item;
        }

        public int Insert(string spName, object parameters = null)
        {
            int id;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                id = cn.Query<int>(spName, parameters, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }

            return id;
        }
    }
}
