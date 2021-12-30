using MvvmHelpers;
using System;

namespace BasicBinding.ViewModel
{
    public class BindingContextViewModel : BaseViewModel
    {
        public BindingContextViewModel()
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
