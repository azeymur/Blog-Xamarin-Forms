using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BlogTemplate.Models;
using Xamarin.Forms;
using BlogTemplate.Services;
using BlogTemplate.DataStores;
using System.Diagnostics;
using BlogTemplate.Views;

namespace BlogTemplate.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        IService service = DependencyService.Get<IService>();

        public ObservableCollection<Category> Categories { get; }
        public ObservableCollection<PostViewModel> Posts { get; }

        public Command LoadPageCommand { get; }
        public Command<Category>  CategoryCommand { get; }

        private PostViewModel firstPost;
        public PostViewModel FirstPost
        {
            get => firstPost;
            set => SetProperty(ref firstPost, value);
        }

        private PostViewModel secondPost;
        public PostViewModel SecondPost
        {
            get => secondPost;
            set => SetProperty(ref secondPost, value);
        }

        private PostViewModel thirdPost;
        public PostViewModel ThirdPost
        {
            get => thirdPost;
            set => SetProperty(ref thirdPost, value);
        }

        public HomeViewModel()
        {
            Categories = new ObservableCollection<Category>();
            Posts = new ObservableCollection<PostViewModel>();

            LoadPageCommand = new Command(async () => await ExecuteLoadPageCommand());
            CategoryCommand = new Command<Category>((cat) => { });
        }

        public async void OnAppearing()
        {
            await ExecuteLoadPageCommand();
        }

        async Task ExecuteLoadPageCommand()
        {
            IsBusy = true;

            Categories.Clear();
            var categories = await service.GetCategoriesAsync(null);
            foreach (var item in categories)
                Categories.Add(item);

            Posts.Clear();
            var posts = await service.GetPostsAsync(sortBy: SortBy.NewToOld);

            int i = 0;
            foreach (var post in posts)
            {
                switch (i++)
                {
                    case 0: FirstPost = new PostViewModel(post); break;
                    case 1: SecondPost = new PostViewModel(post); break;
                    case 2: ThirdPost = new PostViewModel(post); break;
                    default: Posts.Add(new PostViewModel(post)); break;
                }
            }

            IsBusy = false;
        }

    }
}
