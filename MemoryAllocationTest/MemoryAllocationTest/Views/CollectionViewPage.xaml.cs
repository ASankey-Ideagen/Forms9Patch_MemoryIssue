using MemoryAllocationTest.ViewModels;
using Xamarin.Forms.Xaml;

namespace MemoryAllocationTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewPage : DisposableContentPage
    {
        CollectionViewViewModel viewModel;

        public CollectionViewPage(CollectionViewViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;            
        }
    }
}