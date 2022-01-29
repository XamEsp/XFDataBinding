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
            // BindingContext = this;
            BindingContext =new BookStore();
        }

        private string _welcomeText = "Welcome to Basic DataBindings!";
        public string WelcomeText
        {
            get
            {
                return _welcomeText;
            }
            set { _welcomeText=value; }
        }

        private string _customerName;
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName=value; }
            
        }
    }
}
