using System;
using System.Collections.Generic;
using BlogTemplate.ViewModels;
using Xamarin.Forms;

namespace BlogTemplate.Views
{
    public partial class PostDetailPage : ContentPage
    {
        PostDetailViewModel viewModel;

        public PostDetailPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PostDetailViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();
        }

    }
}
