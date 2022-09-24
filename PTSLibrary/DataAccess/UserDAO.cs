using PTSLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTSLibrary.Models;

namespace PTSLibrary.DataAccess
{
    internal class UserDAO: SuperDAO
    {
        public int Authenticate(string email, string password)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            SqlDataReader dr;
            sql = String.Format("SELECT ID FROM Users WHERE Email='{0}' AND Pwd='{1}'", email, password); 

            cmd = new SqlCommand(sql,con);
            int id = 0;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = (int)dr["ID"];
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Accessing Database", ex);
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        //List of the projects
        public List<ProjectModel> GetListOfProjects()
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            SqlDataReader dr;
            List<ProjectModel> projects;
            projects = new List<ProjectModel>();
            sql = "SELECT * FROM project";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProjectModel p = new(dr["ProjectCode"].ToString(), dr["ProjectName"].ToString());
                    projects.Add(p);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Getting list", ex);
            }
            finally
            {
                con.Close();
            }
            return projects;
        }

        //List of cohort members
        public List<UserModel> GetListOfCohortMembers(int cohortID)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            SqlDataReader dr;
            List<UserModel> members;
            members = new List<UserModel>();
            sql = String.Format("SELECT * FROM Users WHERE CohortID = '{0}'", cohortID);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UserModel c = new(dr["FirstName"].ToString(), dr["LastName"].ToString(), (int)dr["ID"]);
                    members.Add(c);
            }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Getting list of users", ex);
            }
            finally
            {
                con.Close();
            }
            return members;
        }

        public List<project> GetListOfProjects()// int adminId
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<project> projects;
            projects = new List<project>();
            sql = "SELECT * FROM project"; //WHERE AdministratorID = adminId
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    customer cust = GetCustomer((int)dr["CustomerID"]);
                    project p = new project(dr["ProjectName"].ToString(), (DateTime)dr["ExpectedStartDate"], (DateTime)dr["ExpectedEndDate"], (Guid)dr["ProjectID"], cust);
                    projects.Add(p);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Getting list", ex);
            }
            finally
            {
                cn.Close();
            }
            return projects;
        }
        public List<team> GetListOfTeams()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<team> teams;
            teams = new List<team>();
            sql = "SELECT * FROM team";
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    team t = new team((int)dr["TeamID"], dr["Team_Location"].ToString(), dr["TeamName"].ToString(), null);
                    teams.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting team list", ex);
            }
            finally
            {
                cn.Close();
            }
            return teams;
        }
        public void CreateTask(string name, DateTime startDate, DateTime endDate, int teamId, Guid projectId)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            Guid taskId = Guid.NewGuid();
            sql = "INSERT INTO task (TaskID, TaskName, ExpectedStartDate, ExpectedEndDate, ProjectID, TeamID, StatusID)";
            sql += String.Format("VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6})", taskId, name, startDate, endDate, projectId, teamId, 1);
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Inserting", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
