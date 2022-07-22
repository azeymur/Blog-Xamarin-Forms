using System;
using BlogTemplate.Models;
using Xamarin.Forms;
using BlogTemplate.Services;
using System.Threading.Tasks;
using BlogTemplate.Views;

namespace BlogTemplate.ViewModels
{
    public class PostViewModel : BaseViewModel
    {
        public Command<PostViewModel> PostCommand { get; }

        public string Id { get; }

        public DateTime DateGmt { get; }

        public string Content { get; }

        public string FirstImage { get; }

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

        public PostViewModel(Post post)
        {
            Id = post.Id;
            DateGmt = post.DateGmt;
            Title = post.Title;
            Content = post.Content;
            FirstImage = post.FirstImage;
            IsBookmarked = post.IsBookmarked;
            CommentsCount = post.CommentsCount;
            BookmarksCount = post.BookmarksCount;

            PostCommand = new Command<PostViewModel>(OnPostSelected);
        }

        async void OnPostSelected(PostViewModel item)
        {
            if (item == null) return;

            await Shell.Current.GoToAsync($"{nameof(PostDetailPage)}" +
                                          $"?{nameof(PostDetailViewModel.PostId)}={item.Id}");
        }

    }
}
