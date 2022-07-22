using System;

namespace BlogTemplate.Models
{
    /// <summary>
    /// Type represent favorite entity
    /// </summary>
    public class Bookmark : Entity
    {
        /// <summary>
        /// The id of the associated user
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The id of the associated post
        /// </summary>
        public string PostId { get; set; }
    }
}
