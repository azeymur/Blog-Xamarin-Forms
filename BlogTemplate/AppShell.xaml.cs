using BlogTemplate.Views;
using Xamarin.Forms;

namespace BlogTemplate
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(PhotoBrowserPage), typeof(PhotoBrowserPage));
            Routing.RegisterRoute(nameof(PostDetailPage), typeof(PostDetailPage));
            Routing.RegisterRoute(nameof(MyAccountPage), typeof(MyAccountPage));
        }

    }
}
