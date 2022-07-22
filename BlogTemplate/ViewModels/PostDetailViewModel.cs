using BlogTemplate.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using BlogTemplate.Services;
using System.Threading.Tasks;
using BlogTemplate.Views;
using BlogTemplate.Resources;

namespace BlogTemplate.ViewModels
{
    [QueryProperty(nameof(PostId), nameof(PostId))]
    public class PostDetailViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<Post> RelatedItems { get; }

        public Command ImageChangedCommand { get; }
        public Command PhotoCommand { get; }
        public Command CommentsCommand { get; }
        public Command BookmarkCommand { get; }
        public Command ShareCommand { get; }
        public Command<Post> RelatedItemCommand { get; }

        private string postId;
        public string PostId
        {
            get => postId;
            set
            {
                postId = value;
                LoadPost();
            }
        }

        private DateTime dateGmt;
        public DateTime DateGmt
        {
            get => dateGmt;
            set => SetProperty(ref dateGmt, value);
        }

        private string content;
        public string Content
        {
            get => content;
            set => SetProperty(ref content, value);
        }

        private string authorName;
        public string AuthorName
        {
            get => authorName;
            set => SetProperty(ref authorName, value);
        }

        private string[] images;
        public string[] Images
        {
            get => images;
            set => SetProperty(ref images, value);
        }

        private int commentsCount;
        public int CommentsCount
        {
            get => commentsCount;
            set => SetProperty(ref commentsCount, value);
        }

        private int bookmarksCount;
        public int BookmarksCount
        {
            get => bookmarksCount;
            set => SetProperty(ref bookmarksCount, value);
        }

        private bool isBookmarked;
        public bool IsBookmarked
        {
            get => isBookmarked;
            set => SetProperty(ref isBookmarked, value);
        }

        private Comment recentComment;
        public Comment RecentComment
        {
            get => recentComment;
            set
            {
                SetProperty(ref recentComment, value);
                OnPropertyChanged(nameof(HasRecentComment));
            }
        }

        public bool HasRecentComment
        {
            get => recentComment != null ? true : false;
        }

        private string currentImage;

        public PostDetailViewModel()
        {
            RelatedItems = new ObservableCollection<Post>();

            ImageChangedCommand = new Command<string>((i) => currentImage = i);

            PhotoCommand = new Command(OnPhotoTapped);

            BookmarkCommand = new Command(OnBookmarkTapped);

            ShareCommand = new Command(async () =>
                await Shell.Current.DisplayAlert(AppResources.Info, AppResources.ShareTapped, AppResources.OK));

            RelatedItemCommand = new Command<Post>(OnRelatedItemTapped);

            CommentsCommand = new Command(() => { });
        }

        public void OnAppearing()
        {
            LoadPost();
        }

        public async void LoadPost()
        {
            if (postId == null) return;

            RecentComment = (await service.GetCommentsAsync(postId)).FirstOrDefault();

            var p = await service.GetPostAsync(postId);
            Title = p.Title;
            Content = p.Content;
            AuthorName = p.AuthorName;
            DateGmt = p.DateGmt;
            Images = p.Images;
            BookmarksCount = p.BookmarksCount;
            CommentsCount = p.CommentsCount;
            IsBookmarked = p.IsBookmarked;

            RelatedItems.Clear();

            var relatedItems = await service.GetPostsAsync(postIds: p.RelatedIds);

            foreach (var post in relatedItems)
                RelatedItems.Add(post);
        }

        async void OnPhotoTapped()
        {
            await Shell.Current.GoToAsync($"{nameof(PhotoBrowserPage)}" +
                                          $"?{nameof(PhotoBrowserViewModel.ParamImages)}={string.Join(",", Images)}" +
                                          $"&{nameof(PhotoBrowserViewModel.Image)}={currentImage}");
        }

        async void OnRelatedItemTapped(Post item)
        {
            if (item == null) return;

            await Shell.Current.GoToAsync($"{nameof(PostDetailPage)}?" +
                                          $"{nameof(PostDetailViewModel.PostId)}={item.Id}");
        }

        async void OnBookmarkTapped()
        {
            var fav = await service.GetBookmarkAsync(Globals.LoggedUserId, postId);

            if (fav != null)
            {
                await service.DeleteBookmarkAsync(fav.Id);
                IsBookmarked = false;
            }
            else
            {
                await service.AddBookmarkAsync(new Bookmark
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = Globals.LoggedUserId,
                    PostId = postId
                });

                IsBookmarked = true;
            }
        }

    }
}
