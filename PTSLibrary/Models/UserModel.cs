using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.Models
{
    public class UserModel
    {
        /// <summary>
        /// Represents the user Id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the user code
        /// </summary>
        public string? UserID { get; set; }

        /// <summary>
        /// Represents user first name
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Represents user last name
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Represents user phone number
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Represents user email
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Represents user physical address
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Represents user role (teamleader, student, or both)
        /// </summary>
        public string Role { get; set; } = string.Empty;

        /// <summary>
        /// Represents user's cohort if is a student
        /// </summary>
        public int CohortID { get; set; }

        /// <summary>
        /// Represents user bio
        /// </summary>
        public string? Bio { get; set; }

        /// <summary>
        /// Represents user github link
        /// </summary>
        public string? Github { get; set; }

        /// <summary>
        /// Represents user linkedin link
        /// </summary>
        public string? Linkedin { get; set; }

        /// <summary>
        /// Represents user twitter link
        /// </summary>
        public string? Twitter { get; set; }
    }
}
