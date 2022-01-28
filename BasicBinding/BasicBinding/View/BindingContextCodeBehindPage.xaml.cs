using BasicBinding.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicBinding.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingContextCodeBehindPage : ContentPage
    {
        public BindingContextCodeBehindPage()
        {
            InitializeComponent();
            BindingContext = new BindingContextViewModel();
        }
    }
}