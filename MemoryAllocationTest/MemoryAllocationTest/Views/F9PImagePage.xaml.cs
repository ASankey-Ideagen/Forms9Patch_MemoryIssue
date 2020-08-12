using MemoryAllocationTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemoryAllocationTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class F9PImagePage : ContentPage
    {
        F9PImageViewModel viewModel;
        
        public F9PImagePage(F9PImageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}