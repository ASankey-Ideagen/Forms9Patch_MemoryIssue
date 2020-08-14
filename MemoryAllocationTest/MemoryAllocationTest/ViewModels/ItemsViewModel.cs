using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MemoryAllocationTest.Models;
using MemoryAllocationTest.Views;

namespace MemoryAllocationTest.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public bool F9PImageDisposalEnabled
        {
            get => ((App)Application.Current).IsF9PImageDisposalEnabled;
            set => ((App)Application.Current).IsF9PImageDisposalEnabled = value;
        }
        public ItemsViewModel()
        {
            Title = "Browse";
        }
    }
}