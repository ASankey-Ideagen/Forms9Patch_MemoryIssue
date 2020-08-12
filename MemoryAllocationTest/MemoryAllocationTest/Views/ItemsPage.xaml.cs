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

        async void OnStandardXFImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XFImagePage(new XFImageViewModel()));
        }

        async void OnF9PImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new F9PImagePage(new F9PImageViewModel()));
        }

        //async void OnUsingF9PMultiResourceButtonClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new UseF9PMultiResourcePage(new UseF9PMultiResourceViewModel()));
        //}

        //async void OnUsingStylesAndF9PButtonClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new F9PImagePage(new F9PImageViewModel()));
        //}
    }
}