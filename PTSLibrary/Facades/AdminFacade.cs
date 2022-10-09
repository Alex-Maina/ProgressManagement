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
        //Create project
        public void CreateProject(string projectName, string projectDescription, string level, int projectDuration, string github, string link)
        {
            if (projectName == null || projectDescription == "" || level == null)
            {
                throw new Exception("Please fill in all fields with * ");
            }
            dao.CreateProject(projectName, projectDescription, level, projectDuration, github, link);
        }
        //Delete project
        public void DeleteProject(int id)
        {
            dao.DeleteProject(id);
        }
        //Edit project
        public void UpdateProject(string projectName, string description, string level, int duration, string github, string link, int projectID)
        {
            if (projectName == null || description == "" || level == "" || duration == 0 || link == null)
            {
                throw new Exception("Please fill in all fields with * ");
            }
            dao.UpdateProject(projectName, description, level, duration, github, link, projectID);
        }
        //General Users
        public UserModel[] GetListOfUsers()
        {
            return (dao.GetListOfUsers()).ToArray();
        }
        //Teamleaders
        public UserModel[] GetListOfTeamLeaders()
        {
            return (dao.GetListOfTeamLeaders()).ToArray();
        }
        //Create Cohort
        public void CreateCohort(DateTime startDate)
        {
            dao.CreateCohort(startDate);
        }
        //Edit cohort
        public void editCohort(DateTime startDate, int id)
        {
            dao.editCohort(startDate, id);
        }
        //Graduate cohort
        public void graduateCohort(int id)
        {
            dao.graduateCohort(id);
        }
        //Delete cohort
        public void DeleteCohort(int id)
        {
            dao.DeleteCohort(id);
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
        public void CreateTeamleader(string firstname, string lastname, string phone, string email)
        {
            if (firstname == null || lastname == "" || phone == null || email == null)
            {
                throw new Exception("Missing Data");
            }
            dao.CreateTeamleader(firstname,lastname,phone,email);
        }
        //Add teamleader from users
        public void elevateUserRole(int id)
        {
            dao.elevateUserRole(id);
        }
        //delete teamleader
        public void demoteUserRole(int id)
        {
            dao.demoteUserRole(id);
        }
        //AssignProject
        public void AssignProject(DateTime startdate, int projectID, int cohortID, int teamleaderID)
        {
            if (projectID == 0 || cohortID == 0 || teamleaderID == 0)
            {
                throw new Exception("Missing Data");
            }
            dao.AsssignProject(startdate, projectID, cohortID, teamleaderID);
        }
        //Edit assigned project
        public void EditAssignedProject(DateTime startdate, int projectID, int cohortID, int teamleaderID, int assignedID)
        {
            if (startdate == null || projectID == 0 || cohortID == 0 || teamleaderID == 0)
            {
                throw new Exception("Missing Data");
            }
            dao.EditAssignedProject(startdate, projectID, cohortID, teamleaderID, assignedID);
        }
        //Delete assigned project
        public void DeleteAssignedProject(int id)
        {
            dao.DeleteAssignedProject(id);
        }
    }
}
