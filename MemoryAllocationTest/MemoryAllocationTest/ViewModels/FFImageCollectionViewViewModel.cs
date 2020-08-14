using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryAllocationTest.ViewModels
{
    public class FFImageCollectionViewViewModel : BaseViewModel
    {
        byte[] data = new byte[1024 * 1024 * 20]; //Allocate 20MB of data for visibility in profiler

        private IList<string> _items;
        public IList<string> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public FFImageCollectionViewViewModel()
        {
            Title = "FFImageLoading Image within CollectionView";

            Items = new List<string>();
            for (var i=0; i<=10000; i++)
            {
                Items.Add(i.ToString());
            }
        }
    }
}
