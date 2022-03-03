using BindingDotListView.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BindingDotListView.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext=new ItemDetailViewModel();
        }
    }
}