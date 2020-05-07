using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Common
{
    public interface IDatabaseComplexService
    {
        List<T> GetList<T>(string spName, object parameters = null) where T : class;

        T GetSingle<T>(string spName, object parameters = null) where T : class;

        int Insert(string spName, object parameters = null);
    }
}
