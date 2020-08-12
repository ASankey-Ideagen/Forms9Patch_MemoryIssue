using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryAllocationTest.ViewModels
{
    public class F9PImageViewModel : BaseViewModel
    {
        byte[] data = new byte[1024 * 1024 * 20]; //Allocate 20MB of data for visibility in profiler

        public F9PImageViewModel()
        {
            Title = "Forms9Patch Image";
        }

        ~F9PImageViewModel()
        {
            data = null;
        }
    }
}
