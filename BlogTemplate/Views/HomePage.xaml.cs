using BlogTemplate.ViewModels;
using Xamarin.Forms;

namespace BlogTemplate.Views
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel viewModel;

        public HomePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new HomeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.OnAppearing();
        }

    }
}
