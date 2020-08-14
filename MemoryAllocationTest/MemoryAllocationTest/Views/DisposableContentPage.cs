using System;
using Xamarin.Forms;

namespace MemoryAllocationTest.Views
{
    public partial class DisposableContentPage : ContentPage, IDisposable
    {
        protected override void OnParentSet()
        {
            base.OnParentSet();

            if (Parent == null)
            {
                Dispose();
            }
        }

        public void Dispose()
        {
            if (((App)Application.Current).IsF9PImageDisposalEnabled)
            {
                if (Content is Layout layout)
                    DisposeLayoutF9PImages(layout);

                if (Content is ItemsView itemsView)
                    DisposeItemsViewF9PImages(itemsView);
            }
        }

        void DisposeLayoutF9PImages(Layout layout)
        {
            foreach (var child in layout.Children)
            {
                DisposeElement(child);
            }
        }

        void DisposeItemsViewF9PImages(ItemsView itemsView)
        {
            foreach (var child in itemsView.LogicalChildren)
            {
                DisposeElement(child);
            }
        }

        void DisposeElement(Element element)
        {
            if (element is Layout layout)
            {
                DisposeLayoutF9PImages(layout);
            }
            else if (element is ItemsView itemsView)
            {
                DisposeItemsViewF9PImages(itemsView);
            }
            else if (element is Forms9Patch.Image f9pImage)
            {
                f9pImage.Dispose();
            }
        }
    }
}
