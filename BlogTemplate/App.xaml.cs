using Xamarin.Forms;
using BlogTemplate.Services;
using BlogTemplate.DataStores.MockDataStore;

namespace BlogTemplate
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.RegisterSingleton(new CategoryDataStore());
            DependencyService.RegisterSingleton(new CommentDataStore());
            DependencyService.RegisterSingleton(new BookmarkDataStore());
            DependencyService.RegisterSingleton(new PostDataStore());
            DependencyService.RegisterSingleton(new UserDataSource());

            DependencyService.Register<IService, MockService>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
