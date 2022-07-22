using System;

namespace BlogTemplate.Models
{
    /// <summary>
    /// Type represent comment entity
    /// </summary>
    public class Comment : Entity
    {
        /// <summary>
        /// The date of the comment
        /// </summary>
        public DateTime DateGmt { get; set; }

        /// <summary>
        /// Content of the comment
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The id of the associated post
        /// </summary>
        public string PostId { get; set; }

        /// <summary>
        /// The title of the associated post
        /// </summary>
        public string PostTitle { get; set; }

        /// <summary>
        /// The image of the associated post
        /// </summary>
        public string PostImage { get; set; }

        /// <summary>
        /// The date of the post
        /// </summary>
        public DateTime PostDateGmt { get; set; }

        /// <summary>
        /// Author name of the post
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// The id of the associated user
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The name of the associated user
        /// </summary>
        public string UserFullName { get; set; }
    }
}
