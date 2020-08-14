using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MemoryAllocationTest.Models;
using MemoryAllocationTest.Views;
using MemoryAllocationTest.ViewModels;

namespace MemoryAllocationTest.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            GC.Collect();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();


        }

        async void OnStandardXFImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XFImagePage(new XFImageViewModel()));
        }

        async void OnF9PImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new F9PImagePage(new F9PImageViewModel()));
        }

        async void OnCollectionViewButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CollectionViewPage(new CollectionViewViewModel()));
        }

        async void OnFFImageLoadingButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FFImagePage(new FFImageViewModel()));
        }

        async void OnFFImageCollectionViewButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FFImageCollectionViewPage(new FFImageCollectionViewViewModel()));
        }

        async void OnIconFontImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IconFontImagePage(new IconFontImageViewModel()));
        }

    }
}