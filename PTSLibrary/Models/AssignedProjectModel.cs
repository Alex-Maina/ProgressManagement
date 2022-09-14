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
        public string StartDate { get; set; } = string.Empty;

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
        public int AdminID { get; set; }
    }
}
