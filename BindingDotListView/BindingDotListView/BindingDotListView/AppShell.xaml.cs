using BindingDotListView.ViewModels;
using BindingDotListView.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BindingDotListView
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
