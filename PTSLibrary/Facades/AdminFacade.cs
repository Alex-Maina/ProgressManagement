using PTSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.Facades
{
    public class AdminFacade : SuperFacade
    {
        private new DataAccess.AdminDAO dao;

        public AdminFacade() : base(new DataAccess.AdminDAO())
        {
            dao = (DataAccess.AdminDAO)base.dao;
        }
        //Authenticate
        public int Authenticate(string email, string password)
        {
            if (email == "" || email == "" || password == "")
            {
                throw new Exception("All fields must be filled");
            }
            return dao.Authenticate(email, password);
        }
        public void CreateProject(string projectName, string projectDescription, string projectTasks, string level, int projectDuration, string github, string link)
        {
            if (projectName == null || projectDescription == "" || projectTasks == null || level == null || projectDuration == 0)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateProject(projectName,projectDescription,projectTasks,level,projectDuration,github,link);
        }
        //General Users
        public UserModel[] GetListOfUsers()
        {
            return (dao.GetListOfUsers()).ToArray();
        }
        //Teamleaders
        public UserModel[] GetListOfTeamLeaders()
        {
            return (dao.GetListOfUsers()).ToArray();
        }
        
        //Cohort list
        public CohortModel[] GetListOfCohorts()
        {
            return (dao.GetListOfCohorts()).ToArray();
        }
        //Create task
        public void CreateTask(string task, int projectID)
        {
            if (task == null || task == "" )
            {
                throw new Exception("Missing Data");
            }
            dao.CreateTask(task, projectID);
        }
        //Create Teamleader
        public void CreateTeamleader(string firstname, string lastname, string email, string tempPwd)
        {
            if (firstname == null || firstname == "" || lastname == null || email == null || tempPwd == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateTeamleader(firstname,lastname,email,tempPwd);
        }
        //AssignProject
        public void AssignProject(DateTime startdate, int projectID, int cohortID, int teamleaderID, int adminID)
        {
            if (startdate == null || projectID == null || cohortID == null || teamleaderID == null)
            {
                throw new Exception("Missing Data");
            }
            dao.AsssignProject(startdate,projectID,cohortID,teamleaderID,adminID);
        }
    }
}
