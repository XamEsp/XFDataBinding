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

        Command bindingContextCodeBehindCommand;

        public ICommand BindingContextCodeBehindCommand
        {
            get
            {
                if (bindingContextCodeBehindCommand == null)
                {
                    bindingContextCodeBehindCommand = new Command(BindingContextCodeBehind);
                }

                return bindingContextCodeBehindCommand;
            }
        }
        async void BindingContextCodeBehind()
        {
            await App.Navigation.PushAsync(new BindingContextCodeBehindPage());
        }

        Command bindingContextCodeBehindAsyncCommand;

        public ICommand BindingContextCodeBehindAsyncCommand
        {
            get
            {
                if (bindingContextCodeBehindAsyncCommand == null)
                {
                    bindingContextCodeBehindAsyncCommand = new Command(BindingContextCodeBehindAsync);
                }

                return bindingContextCodeBehindAsyncCommand;
            }
        }
        async void BindingContextCodeBehindAsync()
        {
            await App.Navigation.PushAsync(new BindingContextCodeBehindAsyncPage());
        }

    }
}
