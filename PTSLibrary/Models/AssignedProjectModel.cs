using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.Models
{
    public class AssignedProjectModel
    {
        /// <summary>
        /// Represents the ID of the project assignment
        /// </summary>
        public int AssignedProjectID { get; set; }

        /// <summary>
        /// Represents the start date of the assigned project
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Represents the project ID of the assigned project
        /// </summary>
        public int ProjectID { get; set; }

        /// <summary>
        /// Represents the cohort ID that has been assigned the project
        /// </summary>
        public int CohortID { get; set; }

        /// <summary>
        /// Represents the teamleader (UID) that is incharge of the project
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Represents the admin (ID) that assigned the project
        /// </summary>
        public string Status { get; set; }

        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string Level { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Name { get { return Fname + " " + Lname; } }
        public string Display { get { return ProjectName +"    "+Level+ "     Teamleader :  " + Name; } }


        public AssignedProjectModel() { }

        public AssignedProjectModel(int assignedProjectID, DateTime startDate, int projectID, int cohortID, int userID, string status,
            string projectCode, string projectName, string level, string fname, string lname)
        {
            AssignedProjectID = assignedProjectID;
            StartDate = startDate.ToString("dd/MM/yyyy");
            ProjectID = projectID;
            CohortID = cohortID;
            UserID = userID;
            Status = status;
            ProjectCode = projectCode;
            ProjectName = projectName;
            Level = level;
            Fname = fname;
            Lname = lname;
        }
    }
}