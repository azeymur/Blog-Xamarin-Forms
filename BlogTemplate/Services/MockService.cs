using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTemplate.DataStores;
using BlogTemplate.Models;
using Xamarin.Forms;

namespace BlogTemplate.Services
{
    /// <summary>
    /// Mock service that works with mock data stores for testing.
    /// </summary>
    public class MockService : IService
    {
        ICategoryDataStore dataCategory = DependencyService.Get<ICategoryDataStore>();
        ICommentDataStore dataComment = DependencyService.Get<ICommentDataStore>();
        IBookmarkDataStore dataBookmark = DependencyService.Get<IBookmarkDataStore>();
        IPostDataStore dataPost = DependencyService.Get<IPostDataStore>();
        IUserDataStore dataUser = DependencyService.Get<IUserDataStore>();

        // Methods for Comment entity

        public async Task<Comment> AddCommentAsync(Comment comment)
        {
            return await dataComment.AddAsync(comment);
        }

        public async Task<IEnumerable<Comment>> GetCommentsAsync(string postId, string userId)
        {
            return (await dataComment.GetByAsync(c => (postId == null || c.PostId == postId) &&
                                                      (userId == null || c.UserId == userId))).ToList()
                            .Select(i => {
                                i.UserFullName = dataUser.GetAsync(i.UserId).Result.FullName;
                                var p = dataPost.GetAsync(i.PostId).Result;
                                i.PostTitle = p.Title;
                                i.PostImage = p.FirstImage;
                                i.PostDateGmt = p.DateGmt;
                                i.AuthorName = dataUser.GetAsync(p.AuthorId).Result.FullName;
                                return i;
                            }).OrderByDescending(t => t.DateGmt);
        }

        public async Task<int> GetCommentCountAsync(string postId)
        {
            return (await dataComment.GetByAsync(f => f.PostId == postId)).Count();
        }

        // Methods for Bookmark entity

        public async Task<Bookmark> AddBookmarkAsync(Bookmark bookmark)
        {
            return await dataBookmark.AddAsync(bookmark);
        }

        public async Task<bool> DeleteBookmarkAsync(string id)
        {
            return await dataBookmark.DeleteAsync(id);
        }

        public async Task<Bookmark> GetBookmarkAsync(string userId, string postId)
        {
            return (await dataBookmark.GetByAsync(f => f.UserId == userId && f.PostId == postId))
                        .FirstOrDefault();
        }

        public async Task<bool> IsBookmarkedAsync(string userId, string postId)
        {
            return await dataBookmark.IsExistAsync(f => f.UserId == userId && f.PostId == postId);
        }

        public async Task<int> GetBookmarkCountAsync(string userId, string postId)
        {
            return (await dataBookmark.GetByAsync(f => f.PostId == postId && f.UserId == userId)).Count();
        }

        // Methods for Tag entity

        public async Task<IEnumerable<string>> GetAllTagsAsync()
        {
            return (await dataPost.GetAllAsync()).SelectMany(i => i.Tags).Distinct().OrderBy(t => t);
        }

        // Methods for Category entity

        public async Task<IEnumerable<Category>> GetCategoriesAsync(string name)
        {
            var result = await dataCategory.GetByAsync(i => name == null || i.Name.Contains(name));

            return await Task.FromResult(result);
        }

        // Methods for Post entity

        public async Task<Post> GetPostAsync(string id)
        {
            return await dataPost.GetAsync(id);
        }

        public async Task<IEnumerable<Post>> GetPostsAsync(string[] categoriIds = null,
                            string[] tags = null, string[] postIds = null, string key = null,
                            bool onlyBookmarkeds = false, SortBy sortBy = SortBy.Unsorted)
        {
            var result = (await dataPost.GetByAsync(p => (categoriIds == null || p.CategoryIds.Any(c => categoriIds.Contains(c))) &&
                                           (tags == null || p.Tags.Any(t => tags.Contains(t))) &&
                                           (postIds == null || postIds.Contains(p.Id)) &&
                                           (key == null || p.Title.ToLower().Contains(key.ToLower())))).ToList()
                                .Select(i =>
                                {
                                    i.CommentsCount = dataComment.GetByAsync(c => c.PostId == i.Id).Result.Count();
                                    i.BookmarksCount = dataBookmark.GetByAsync(f => f.PostId == i.Id).Result.Count();
                                    i.IsBookmarked = dataBookmark.IsExistAsync(f => f.PostId == i.Id && f.UserId == Globals.LoggedUserId).Result;
                                    i.AuthorName = dataUser.GetAsync(i.AuthorId).Result.FullName;
                                    return i;
                                }).Where(p => (onlyBookmarkeds == false || p.IsBookmarked == true));

            switch (sortBy)
            {

                case SortBy.NewToOld: result = result.OrderByDescending(i => i.DateGmt); break;
                case SortBy.OldToNew: result = result.OrderBy(i => i.DateGmt); break;
                case SortBy.MostComments: result = result.OrderByDescending(i => i.CommentsCount); break;
                case SortBy.MostBookmarked: result = result.OrderByDescending(i => i.BookmarksCount); break;
            };

            return await Task.FromResult(result);
        }

        // Method for User entity
         
        public async Task<User> GetUserAsync(string id)
        {
            return await dataUser.GetAsync(id);
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            return await dataUser.UpdateAsync(user);
        }
    }
}
