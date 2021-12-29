using BasicBinding.View;
using MvvmHelpers;
using System.Windows.Input;
using Xamarin.Forms;

namespace BasicBinding.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        Command bindingContextXamlCommand;

        public ICommand BindingContextXamlCommand
        {
            get
            {
                if (bindingContextXamlCommand == null)
                {
                    bindingContextXamlCommand = new Command(BindingContextXaml);
                }

                return bindingContextXamlCommand;
            }
        }

        async void BindingContextXaml()
        {
            await App.Navigation.PushAsync(new BindingContextXamlPage());
        }
    }
}
