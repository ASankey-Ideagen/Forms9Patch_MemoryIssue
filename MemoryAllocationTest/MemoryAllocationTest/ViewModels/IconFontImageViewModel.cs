using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryAllocationTest.ViewModels
{
    public class IconFontImageViewModel : BaseViewModel
    {
        byte[] data = new byte[1024 * 1024 * 20]; //Allocate 20MB of data for visibility in profiler

        public IconFontImageViewModel()
        {
            Title = "Icon Font Image";

        }
    }
}
