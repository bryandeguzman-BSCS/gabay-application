using GABAY_APPLICATION.Views;

namespace GABAY_APPLICATION
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(
                new NavigationPage(
                    new LoginPage()));
        }
    }
}