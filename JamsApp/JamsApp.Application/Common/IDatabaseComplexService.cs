using System;
using System.Collections.Generic;
using System.Text;

namespace JamsApp.Application.Common
{
    public interface IDatabaseComplexService
    {
        T GetSingle<T>(string spName, object parameters = null) where T : class;

        List<T> GetList<T>(string spName, object parameters = null) where T : class;
    }
}
