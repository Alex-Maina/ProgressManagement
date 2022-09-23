using PTSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.DataAccess
{
    public class SuperDAO
    {

        protected UserModel GetUser(int ID)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            SqlDataReader dr;
            UserModel user;

            sql = "SELECT * FROM customer WHERE CustomerID = " + ID;

            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                dr.Read();
                user = new(dr["FirstName"].ToString(), dr["LastName"].ToString(), (int)dr["ID"]);
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Getting Customer", ex);
            }
            finally
            {
                con.Close();
            }
            return user;
        }

        //List the tasks
        public List<TaskModel> GetListOfTasks(int ProjectID)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            SqlDataReader dr;
            List<TaskModel> tasks;
            tasks = new List<TaskModel>();
            sql = "SELECT * FROM Tasks WHERE ProjectID = '" + ProjectID + "'";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TaskModel t = new((int)dr["ID"], dr["Task"].ToString());
                    tasks.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting task list", ex);
            }
            finally
            {
                con.Close();
            }
            return tasks;
        }
    }
}
