using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullOrFallback.ViewModel;
using Xamarin.Forms;

namespace NullOrFallback
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext=new School();
            InitializeComponent();
        }

    }
}
