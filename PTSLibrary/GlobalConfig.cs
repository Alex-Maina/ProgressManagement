using PTSLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection connection { get; private set; }

        public static void InitializeConnections()
        {
                //TODO - Create SQL connection
                SqlConnector sql = new SqlConnector();
                connection = sql;
        }

        public static string ConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
