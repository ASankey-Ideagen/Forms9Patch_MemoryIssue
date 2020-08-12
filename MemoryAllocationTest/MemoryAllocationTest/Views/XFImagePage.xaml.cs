using MemoryAllocationTest.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemoryAllocationTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XFImagePage : ContentPage
    {
        XFImageViewModel viewModel;

        public XFImagePage(XFImageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        ~XFImagePage()
        {
            BindingContext = null;
        }
    }
}