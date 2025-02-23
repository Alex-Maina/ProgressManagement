﻿using System;
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
        public string? ProjectName { get; set; }

        /// <summary>
        /// Represents the Project Description
        /// </summary>
        public string ProjectDescription { get; set; }

        /// <summary>
        /// Represents the Project Tasks
        /// </summary>
        public string ProjectTasks { get; set; }

        /// <summary>
        /// Represents the project difficulty level (Beginner, Intermidiate, Expert)
        /// </summary>
        public string Level { get; set; } 

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

        /// <summary>
        /// Combination of the Project Code and Name.
        /// </summary>
        public string DisplayProject { get { return ProjectCode + "   -   " + ProjectName + "   -   " + Level; } }

        public ProjectModel()
        {

        }

        public ProjectModel(int projectID, string projectCode, string projectName, string projectDescription, 
            string projectTasks, string level, int projectDuration, string github, string link)
        {
            ProjectID = projectID;
            ProjectCode = projectCode;
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            ProjectTasks = projectTasks;
            Level = level;
            ProjectDuration = projectDuration;
            Github = github;
            Link = link;
        }


        public ProjectModel(string projectName, string projectDescription, string projectTasks, string level, int projectDuration, string github, string link)
        {
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            ProjectTasks = projectTasks;
            Level = level;
            ProjectDuration = projectDuration;
            Github = github;
            Link = link;
        }

        public ProjectModel(string projectCode, string projectName)
        {
            ProjectCode = projectCode;
            ProjectName = projectName;
        }

    }
}
