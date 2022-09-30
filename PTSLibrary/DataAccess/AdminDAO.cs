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
        int id = 0;

        //Authenticate Admin
        public int Authenticate (string email, string password)
        {
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            string sql = String.Format("SELECT ID from dbo.Admin WHERE email='{0}' and pwd='{1}'", email, password);
            SqlCommand cmd = new(sql, con);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = (int)dr["ID"];
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
        public void CreateProject(string projectName, string projectDescription, 
            string level, int projectDuration, string github, string link)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = "INSERT INTO Projects (ProjectName, ProjectDescription, Duration, Level, GithubRepo, VideoLink, ProjectTasks)";
            sql += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',' ')", projectName, projectDescription, projectDuration, level, github, link);
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
        //Delete a project 
        public void DeleteProject(int id)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = String.Format("DELETE FROM projects WHERE ProjectID='{0}'", id);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error deleting project", ex);
            }
            finally
            {
                con.Close();
            }
        }
        //Edit existing project 
        public void UpdateProject(string projectName, string description,
            string level, int duration, string github, string link, int projectID)
        { 
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = String.Format("UPDATE Projects SET ProjectName = '{0}', ProjectDescription ='{1}', Duration='{2}', Level='{3}', " +
                "GithubRepo='{4}', VideoLink='{5}' WHERE ProjectID = '{6}'", projectName, description, duration, level, github, link, projectID);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating project", ex);
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
            sql = "INSERT INTO Cohort (StartDate)";
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
        //Edit Cohort
        public void editCohort(DateTime startDate, int id)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = String.Format("UPDATE Cohort SET StartDate = '{0}' WHERE CohortID = '{1}'", startDate, id);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating cohort", ex);
            }
            finally
            {
                con.Close();
            }
        }
        //Graduate Cohort
        public void graduateCohort(int id)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            DateTime endDate = DateTime.Now;
            sql = String.Format("UPDATE Cohort SET Status = 'Complete', EndDate = '{0}'  WHERE CohortID = '{1}'", endDate, id);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error graduating cohort", ex);
            }
            finally
            {
                con.Close();
            }
        }
        //Delete a cohort 
        public void DeleteCohort(int id)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = String.Format("DELETE FROM Cohort WHERE CohortID='{0}'", id);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error deleting cohort", ex);
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
            sql = "SELECT * FROM Cohort";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DateTime startDate = DateTime.Parse(dr["StartDate"].ToString());
                    CohortModel t = new((int)dr["CohortID"],dr["CohortName"].ToString(), startDate, dr["Status"].ToString());
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
                throw new Exception("Error inserting task", ex);
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
        public void AsssignProject(DateTime startdate, int projectID, int cohortID, int teamleaderID)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = "INSERT INTO AssignedProject (StartDate, ProjectID, CohortID, UserID, Status)";
            sql += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','Inprogress')", startdate, projectID, cohortID, teamleaderID);
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
        //Edit assigned project
        public void EditAssignedProject(DateTime startdate, int projectID, int cohortID, int teamleaderID,int assignedID)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = "INSERT INTO AssignedProject (StartDate, ProjectID, CohortID, UserID, Status)";
            sql = String.Format("UPDATE AssignedProject SET StartDate ='{0}', ProjectID ='{1}', CohortID ='{2}', UserID='{3}' " +
                "WHERE AssignedID = '{4}'", startdate, projectID, cohortID, teamleaderID,assignedID);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error updating the assignment", ex);
            }
            finally
            {
                con.Close();
            }
        }
        //Delete assigned project 
        public void DeleteAssignedProject(int id)
        {
            string sql;
            SqlConnection con = new(Properties.Settings.Default.PTSConnectionstring);
            SqlCommand cmd;
            sql = String.Format("DELETE FROM Assignedproject WHERE CohortID='{0}'", id);
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error deleting assigned project", ex);
            }
            finally
            {
                con.Close();
            }
        }



    }

    






}
