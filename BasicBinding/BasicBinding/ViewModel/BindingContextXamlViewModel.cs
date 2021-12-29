using MvvmHelpers;
using System;

namespace BasicBinding.ViewModel
{
    public class BindingContextXamlViewModel : BaseViewModel
    {
        public BindingContextXamlViewModel()
        {
            Now = DateTime.Now;
        }

        DateTime now;

        public DateTime Now
        {
            get => now;
            set => SetProperty(ref now, value);
        }

    }
}
