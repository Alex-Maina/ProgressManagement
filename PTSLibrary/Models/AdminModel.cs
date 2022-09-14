using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.Models
{
    internal class AdminModel
    {
        /// <summary>
        /// Represents the Admin Id
        /// </summary>
        public int AdminID { get; set; }

        /// <summary>
        /// Represents admin first name
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Represents admin last name
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Represents admin phone number
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Represents admin email
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Represents admin physical address
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Represents user bio
        /// </summary>
        public string? Bio { get; set; }

        /// <summary>
        /// Represents admin github link
        /// </summary>
        public string? Github { get; set; }

        /// <summary>
        /// Represents adnin linkedin link
        /// </summary>
        public string? Linkedin { get; set; }

        /// <summary>
        /// Represents admin twitter link
        /// </summary>
        public string? Twitter { get; set; }
    }
}
