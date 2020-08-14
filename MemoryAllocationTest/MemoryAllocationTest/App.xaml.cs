using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MemoryAllocationTest.Services;
using MemoryAllocationTest.Views;

namespace MemoryAllocationTest
{
    public partial class App : Application
    {
        public bool IsF9PImageDisposalEnabled = false;

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
