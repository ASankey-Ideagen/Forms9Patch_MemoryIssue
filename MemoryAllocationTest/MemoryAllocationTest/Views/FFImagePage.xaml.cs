using MemoryAllocationTest.ViewModels;
using Xamarin.Forms.Xaml;

namespace MemoryAllocationTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FFImagePage : DisposableContentPage
    {
        FFImageViewModel viewModel;

        public FFImagePage(FFImageViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}