using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.Models
{
    public class CohortModel
    {
        /// <summary>
        /// Represents the cohort ID
        /// </summary>
        public int CohortID { get; set; }

        /// <summary>
        /// Represents the cohort name
        /// </summary>
        public string CohortName { get; set; } = string.Empty;

        /// <summary>
        /// Represents the cohort's start date
        /// </summary>
        public string StartDate { get; set; } = string.Empty;

        /// <summary>
        /// Represents the cohort's end date
        /// </summary>
        public string? EndDate { get; set; } 

        /// <summary>
        /// Represents the cohort's completion status (incomplete or complete)
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Represents a list of the cohort member
        /// </summary>
        public List<UserModel> Members { get; set; } = new List<UserModel>();

        public CohortModel()
        {
        }

        public CohortModel(string cohortName, string status)
        {
            CohortName = cohortName;
            Status = status;
        }

        public CohortModel(int cohortID, string cohortName, string startDate, string status)
        {
            CohortID = cohortID;
            CohortName = cohortName;
            StartDate = startDate;
            Status = status;
        }
    }
}
