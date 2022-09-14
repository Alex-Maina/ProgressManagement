using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.Models
{
    public class ProjectModel
    {
        /// <summary>
        /// Represents the Project ID
        /// </summary>
        public int ProjectID { get; set; }

        /// <summary>
        /// Represents the project code
        /// </summary>
        public string? ProjectCode { get; set; }

        /// <summary>
        /// Represents the Project Name
        /// </summary>
        public string ProjectName { get; set; } = string.Empty;

        /// <summary>
        /// Represents the Project Description
        /// </summary>
        public string ProjectDescription { get; set; } = string.Empty;

        /// <summary>
        /// Represents the project difficulty level (Beginner, Intermidiate, Expert)
        /// </summary>
        public string Level { get; set; } = string.Empty;

        /// <summary>
        /// Represents the Project Duration in weeks
        /// </summary>
        public int ProjectDuration { get; set; }

        /// <summary>
        /// Represents the project github repo
        /// </summary>
        public string Github { get; set; } = string.Empty;

        /// <summary>
        /// Represents the project video link
        /// </summary>
        public string Link { get; set; } = string.Empty;
    }
}
