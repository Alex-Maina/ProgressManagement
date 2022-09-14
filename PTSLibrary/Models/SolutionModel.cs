using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.Models
{
    internal class SolutionModel
    {
        /// <summary>
        /// Represents the id of the completed solution
        /// </summary>
        public int SolutionID { get; set; }

        /// <summary>
        /// Represents the name given to the completed solution
        /// </summary>
        public string SolutionName { get; set; } = string.Empty;

        /// <summary>
        /// Represents the description of the completed solution
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Represents the student (UID) who completed the solution
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Represents the project to which the solution is part of
        /// </summary>
        public int AssignedProjectID { get; set; }
    }
}
