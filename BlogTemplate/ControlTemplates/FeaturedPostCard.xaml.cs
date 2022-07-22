using BlogTemplate.Models;
using BlogTemplate.ViewModels;
using Xamarin.Forms;

namespace BlogTemplate.ControlTemplates
{
    public partial class FeaturedPostCard : ContentView
    {
        public static readonly BindableProperty ItemProperty =
            BindableProperty.Create(nameof(Item), typeof(PostViewModel), typeof(FeaturedPostCard), null);

        public static readonly BindableProperty FetchCommandProperty =
            BindableProperty.Create(nameof(FetchCommand), typeof(Command<PostViewModel>), typeof(FeaturedPostCard), null);

        public PostViewModel Item
        {
            get => (PostViewModel)GetValue(ItemProperty) ;
            set => SetValue(ItemProperty, value);
        }

        public Command<PostViewModel> FetchCommand
        {
            get => (Command<PostViewModel>)GetValue(FetchCommandProperty);
            set => SetValue(FetchCommandProperty, value);
        }

        public FeaturedPostCard()
        {
            InitializeComponent();
        }
    }
}
