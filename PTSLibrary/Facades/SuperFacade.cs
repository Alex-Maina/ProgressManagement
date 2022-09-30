using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTSLibrary.Models;

namespace PTSLibrary.Facades
{
    public class SuperFacade : MarshalByRefObject
    {
        protected DataAccess.SuperDAO dao;

        public SuperFacade(DataAccess.SuperDAO dao)
        {
            this.dao = dao;
        }

        public ProjectModel[] GetListOfProjects()
        {
            return (dao.GetListOfProjects().ToArray());
        }

        public TaskModel[] GetListOfTasks(int projectID)
        {
            return (dao.GetListOfTasks(projectID).ToArray());
        }

        //List of assigned projects that are complete/cohort
        public AssignedProjectModel[] GetListOfCompletedProjects(int CohortID)
        {
            return (dao.GetListOfCompletedProjects(CohortID).ToArray());
        }
        //List of assigned projects that are inprogress/cohort
        public AssignedProjectModel[] GetListOfInprogressProjects(int CohortID)
        {
            return (dao.GetListOfInprogressProjects(CohortID).ToArray());
        }
    }
}
