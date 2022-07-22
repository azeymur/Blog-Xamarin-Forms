using System;

namespace BlogTemplate.Models
{
    /// <summary>
    /// Type represent user entity
    /// </summary>
    public class User : Entity
    {
        /// <summary>
        /// First and last name of the user
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Short description for the user
        /// </summary>
        public string About { get; set; }

        /// <summary>
        /// The email address for user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Image for user
        /// </summary>
        public string Image { get; set; }
    }
}
