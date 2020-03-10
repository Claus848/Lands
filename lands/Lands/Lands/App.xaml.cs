
namespace Lands
{
    using Views;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    public partial class App : Application
    {
        #region Constructors
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new LoginPage());
        }
        #endregion
        #region methods
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        #endregion
    }
}
