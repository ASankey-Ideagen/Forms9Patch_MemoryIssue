using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryAllocationTest.ViewModels
{
    public class XFImageViewModel : BaseViewModel
    {
        byte[] data = new byte[1024 * 1024 * 20]; //Allocate 20MB of data for visibility in profiler

        public XFImageViewModel()
        {
            Title = "Xamarin Forms Image";

            System.Diagnostics.Debug.WriteLine("XFImageViewModel Creator");
        }

        ~XFImageViewModel()
        {
            data = null;
            System.Diagnostics.Debug.WriteLine("XFImageViewModel Destructor");

        }
    }
}
