using MvvmHelpers;
using System;
using System.Threading.Tasks;

namespace BasicBinding.ViewModel
{
    public class BindingContextAsyncViewModel : BaseViewModel
    {
        bool initialized;

        public async Task Init()
        {
            if (initialized)
            {
                return;
            }

            initialized = true;

            IsBusy = true;
            await Task.Delay(2000); // Simulate long async initialization task
            Now = DateTime.Now;
            IsBusy=false;
        }

        DateTime now;

        public DateTime Now
        {
            get => now;
            set => SetProperty(ref now, value);
        }

    }
}
