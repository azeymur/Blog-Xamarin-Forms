using System.Collections.Generic;
using System.Threading.Tasks;
using BlogTemplate.DataStores;
using BlogTemplate.Models;

namespace BlogTemplate.Services
{
    /// <summary>
    /// Interface with common tasks
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="id">User Id</param>
        /// <returns>User object or null</returns>
        Task<User> GetUserAsync(string id);

        /// <summary>
        /// Update the user
        /// </summary>
        /// <param name="user">User object</param>
        /// <returns>True, if successful</returns>
        Task<bool> UpdateUserAsync(User user);

        /// <summary>
        /// Get categories by name
        /// </summary>
        /// <param name="name">Keyword for category name</param>
        /// <returns>List of categories filtered by name</returns>
        Task<IEnumerable<Category>> GetCategoriesAsync(string name);

        /// <summary>
        /// Get the post by id
        /// </summary>
        /// <param name="id">Post id</param>
        /// <returns>Post object or null</returns>
        Task<Post> GetPostAsync(string id);

        /// <summary>
        /// Get posts by parameters
        /// </summary>
        /// <param name="categoriIds">Array of the category ids. Default is null.</param>
        /// <param name="tags">Array of the tag names. Default is null.</param>
        /// <param name="postIds">Array of the post ids. Default is null.</param>
        /// <param name="key">Keyword for post title. Default is null.</param>
        /// <param name="onlyBookmarkeds">Get only bookmarked posts. Default is false.</param>
        /// <param name="sortBy">SortBy enumaration. Default is unsorted.</param>
        /// <returns>List of posts filtered by parameters</returns>
        Task<IEnumerable<Post>> GetPostsAsync(string[] categoriIds = null, string[] tags = null,
                                              string[] postIds = null, string key = null,
                                              bool onlyBookmarkeds = false, SortBy sortBy = SortBy.Unsorted);

        /// <summary>
        /// Get all tags in the post data store by distinct
        /// </summary>
        /// <returns>All tag names</returns>
        Task<IEnumerable<string>> GetAllTagsAsync();

        /// <summary>
        /// Get list of comments by post id
        /// </summary>
        /// <param name="postId">Post id. Default is null.</param>
        /// <param name="userId">User id. Default is null.</param>
        /// <returns>List of comment objects filtered by parameters</returns>
        Task<IEnumerable<Comment>> GetCommentsAsync(string postId = null, string userId = null);

        /// <summary>
        /// Add the comment
        /// </summary>
        /// <param name="comment">Comment object</param>
        /// <returns>Added comment object</returns>
        Task<Comment> AddCommentAsync(Comment comment);

        /// <summary>
        /// Add the bookmark
        /// </summary>
        /// <param name="bookmark">Bookmark object</param>
        /// <returns>Added bookmark object</returns>
        Task<Bookmark> AddBookmarkAsync(Bookmark bookmarks);

        /// <summary>
        /// Delete the Bookmark
        /// </summary>
        /// <param name="id">Bookmark id</param>
        /// <returns>True, if successful</returns>
        Task<bool> DeleteBookmarkAsync(string id);

        /// <summary>
        /// Determine the post is bookmarked 
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="postId">Post id</param>
        /// <returns>True, if post has been added to bookmarks for logged user</returns>
        Task<bool> IsBookmarkedAsync(string userId, string postId);

        /// <summary>
        /// Get the Bookmark object by parameters
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="postId">Post id</param>
        /// <returns>Bookmark object or null</returns>
        Task<Bookmark> GetBookmarkAsync(string userId, string postId);

        /// <summary>
        /// Get number of the comments
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <param name="postId">Post Id</param>
        /// <returns>Comments count</returns>
        Task<int> GetCommentCountAsync(string postId);

        /// <summary>
        /// Get number of users who added it to bookmarks
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <param name="postId">Post Id</param>
        /// <returns>Bookmarks count</returns>
        Task<int> GetBookmarkCountAsync(string userId, string postId);
    }
}
