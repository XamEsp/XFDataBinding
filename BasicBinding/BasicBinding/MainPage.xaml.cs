using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicBinding.Model;
using Xamarin.Forms;

namespace BasicBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public string WelcomeText { get; set; } = "Welcome to Basic DataBindings!";

    }
}
