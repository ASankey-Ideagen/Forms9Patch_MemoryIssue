using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryAllocationTest.ViewModels
{
    public class CollectionViewViewModel : BaseViewModel
    {
        byte[] data = new byte[1024 * 1024 * 20]; //Allocate 20MB of data for visibility in profiler

        private IList<string> _items;
        public IList<string> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }


        public CollectionViewViewModel()
        {
            Title = "Forms9Patch Image within CollectionView";

            Items = new List<string>
            {
                "Item 1",
                "Item 2"
            };
        }

        ~CollectionViewViewModel()
        {
            data = null;
        }
    }
}
