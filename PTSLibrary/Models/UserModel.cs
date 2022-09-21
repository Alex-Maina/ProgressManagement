using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public string UserID { get; set; }

        /// <summary>
        /// Represents user first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents user last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents user phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Represents user email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Represents user password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Represents user role (teamleader, student, or both)
        /// </summary>
        public string Role { get; set; }

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

        public UserModel()
        {

        }

        public UserModel(string firstname, string lastname, int id)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
        }

        public string Username { get { return FirstName + " " + LastName; } }

    }
}
