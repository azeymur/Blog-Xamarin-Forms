using System.Threading.Tasks;
using System.Windows.Input;
using BlogTemplate.Models;
using BlogTemplate.Resources;
using BlogTemplate.Services;
using BlogTemplate.Views;
using Xamarin.Forms;

namespace BlogTemplate.ViewModels
{
    public class MyAccountViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ICommand BookmarksCommand { get; }
        public ICommand CommentsCommand { get; }
        public ICommand AccountDetailsCommand { get; }
        public ICommand ChangePasswordCommand { get; }
        public ICommand LogoutCommand { get; }

        private string userImage;
        public string UserImage
        {
            get => userImage;
            set => SetProperty(ref userImage, value);
        }

        private string userName;
        public string UserName
        {
            get => userName;
            set => SetProperty(ref userName, value);
        }

        public MyAccountViewModel()
        {
            Title = AppResources.MyAccount;

            var u = service.GetUserAsync(Globals.LoggedUserId).Result;
            userImage = u.Image;
            UserName = u.FullName;

            BookmarksCommand = new Command(() => { });

            CommentsCommand = new Command(() => { });

            AccountDetailsCommand = new Command(() => { });

            ChangePasswordCommand = new Command(() => { });

            LogoutCommand = new Command(() => { });

        }
    }
}
