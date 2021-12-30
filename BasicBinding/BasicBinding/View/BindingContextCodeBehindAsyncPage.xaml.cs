using BasicBinding.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicBinding.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingContextCodeBehindAsyncPage : ContentPage
    {
        public BindingContextCodeBehindAsyncPage()
        {
            InitializeComponent();
            BindingContext = new BindingContextAsyncViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ((BindingContextAsyncViewModel)BindingContext).Init();
        }
    }
}