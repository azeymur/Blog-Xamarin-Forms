using System;

namespace BlogTemplate.Models
{
    /// <summary>
    /// Type represent post entity
    /// </summary>
    public class Post : Entity
    {
        /// <summary>
        /// The date of the post
        /// </summary>
        public DateTime DateGmt { get; set; }

        /// <summary>
        /// Title for the post
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Content for the post
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Author id of the post
        /// </summary>
        public string AuthorId { get; set; }

        /// <summary>
        /// Author name of the post
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// List of ids of associated categories
        /// </summary>
        public string[] CategoryIds { get; set; }

        /// <summary>
        /// List of associated tags
        /// </summary>
        public string[] Tags { get; set; }

        /// <summary>
        /// List of images
        /// </summary>
        public string[] Images { get; set; }

        /// <summary>
        /// List of ids of related posts
        /// </summary>
        public string[] RelatedIds { get; set; }

        /// <summary>
        /// Number of comments
        /// </summary>
        public int CommentsCount { get; set; }

        /// <summary>
        /// Number of users who added it to favorites
        /// </summary>
        public int BookmarksCount { get; set; }

        /// <summary>
        /// True if it is bookmared item for the logged customer 
        /// </summary>
        public bool IsBookmarked { get; set; }

        /// <summary>
        /// Calculated field: Get the first image of the post
        /// </summary>
        public string FirstImage
        {
            get
            {
                return Images[0];
            }
        }

    }
}
