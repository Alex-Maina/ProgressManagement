using PTSLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    public static class GlobalConfig
    {
        public static List <IDataConnection> connections { get; set; } = new List <IDataConnection> ();

        public static void InitializeConnections(bool database)
        {
            if (database)
            {
                //TODO - Create SQL connection
                SqlConnector sql = new SqlConnector();
                connections.Add (sql);
            }
        }
    }
}
