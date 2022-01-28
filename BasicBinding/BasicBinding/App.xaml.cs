using Xamarin.Forms;

namespace BasicBinding
{
    public partial class App : Application
    {
        public static INavigation Navigation { get; private set; }

        public App()
        {
            InitializeComponent();
            var rootPage = new NavigationPage(new MainPage());
            Navigation = rootPage.Navigation;
            MainPage = rootPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
