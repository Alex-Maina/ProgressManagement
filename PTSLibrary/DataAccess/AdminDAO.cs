using PTSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.DataAccess
{
    internal class AdminDAO : SuperDAO
    {
        //Authenticate Admin
        public int Authenticate (string email, string password)
        {
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            string sql = String.Format("SELECT AdminID from Admin WHERE email='0' and pwd='1'", email, password);
            SqlCommand cmd = new(sql, con);
            int id = 0;

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = (int)dr["AdminID"];
                } else {
                    Console.WriteLine("Incorrect email or password!");
                        }
                dr.Close();
            }
            catch(SqlException ex)
            {
                throw new Exception("Error accessing database", ex);    
            }
            finally { con.Close(); }

            return id;
        }

        //Add project to database
        public void CreateProject(string projectName, string projectDescription, string projectTasks, string level, int projectDuration, string github, string link)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = "INSERT INTO Projects (ProjectName, ProjectDescription, ProjectTasks, Duration, Level, Github, VideoLink)";
            sql += String.Format("VALUES ('{0}','{1}','{2}','{3}',{4},{5},{6},{7})", projectName, projectDescription, projectTasks, projectDuration, level, github, link);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error adding new project", ex);
            }
            finally
            {
                con.Close();
            }
        }

        //Create Cohort
        public void CreateCohort(DateTime startDate)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = "INSERT INTO Cohorts (StartDate)";
            sql += String.Format("VALUES ('{0}')", startDate);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error creating new cohort", ex);
            }
            finally
            {
                con.Close();
            }
        }

        //List the general users
        public List<UserModel> GetListOfUsers()
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            SqlDataReader dr;
            List<UserModel> users;
            users = new List<UserModel>();
            sql = "SELECT * FROM Users WHERE UserRole != teamleader";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UserModel c = new(dr["FirstName"].ToString(), dr["LastName"].ToString() ,(int)dr["ID"]);
                    users.Add(c);
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
            return users;
        }

        //List the teamleaders
        public List<UserModel> GetListOfTeamLeaders()
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            SqlDataReader dr;
            List<UserModel> users;
            users = new List<UserModel>();
            sql = "SELECT * FROM Users WHERE UserRole = teamleader";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UserModel c = new(dr["FirstName"].ToString(), dr["LastName"].ToString(), (int)dr["ID"]);
                    users.Add(c);
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
            return users;
        }

        //List of cohorts
        public List<CohortModel> GetListOfCohorts()
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            SqlDataReader dr;
            List<CohortModel> cohorts;
            cohorts = new List<CohortModel>();
            sql = "SELECT * FROM Cohorts";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CohortModel t = new( dr["CohortName"].ToString(), dr["Status"].ToString());
                    cohorts.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting team list", ex);
            }
            finally
            {
                con.Close();
            }
            return cohorts;
        }

        //Create a task for a given project
        public void CreateTask(string task, int projectID)
        {
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            Guid taskId = Guid.NewGuid();
            sql = "INSERT INTO Tasks (TaskName, ProjectID)";
            sql += String.Format("VALUES ('{0}','{1}')", task, projectID);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Inserting", ex);
            }
            finally
            {
                con.Close();
            }
        }

        //create a teamleader
        public void CreateTeamleader(string firstname, string lastname, string email, string tempPwd)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = "INSERT INTO Users (FirstName, LastName, Email, Pwd, Role)";
            sql += String.Format("VALUES ('{0}','{1}','{2}',teamleader)", firstname,lastname, email,tempPwd);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error adding teamleader", ex);
            }
            finally
            {
                con.Close();
            }
        }

        //Assign Project
        public void AsssignProject(DateTime startdate, int projectID, int cohortID, int teamleaderID, int adminID)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = "INSERT INTO AssignedProjects (StartDate, ProjectID, CohortID, UserID, AdminID)";
            sql += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", startdate, projectID, cohortID, teamleaderID, adminID);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Assigning Project", ex);
            }
            finally
            {
                con.Close();
            }
        }


    }

    






}
