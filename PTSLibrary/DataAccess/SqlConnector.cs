using Dapper;
using PTSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public ProjectModel CreateProject(ProjectModel model)
        {
            //creates a connection to the sql db and destroys the connection upon exit - prevents memory leaks 
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("PTS_db")))
            {
                var param = new DynamicParameters();

                param.Add("@ProjectName", model.ProjectName);
                param.Add("@ProjectDescription", model.ProjectDescription);
                param.Add("@ProjectDuration", model.ProjectDuration);
                param.Add("ProjectVideoLink", model.Link);
                param.Add("@ProjectGithubRepo", model.Github);
                param.Add("@ProjectLevel", model.Level);
                param.Add("@ProjectID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                param.Add("@ProjectCode", 0, dbType: DbType.String, direction: ParameterDirection.Output);

                connection.Execute("dbo.spProjects_Insert", param, commandType: CommandType.StoredProcedure);

                model.ProjectID = param.Get<int>("@ProjectID");
                model.ProjectCode = param.Get<string>("@ProjectCode");

                return model;
            }

        }
    }
}
