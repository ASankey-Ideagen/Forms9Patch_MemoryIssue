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
    public partial class FFImageCollectionViewPage : DisposableContentPage
    {
        FFImageCollectionViewViewModel viewModel;

        public FFImageCollectionViewPage(FFImageCollectionViewViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}