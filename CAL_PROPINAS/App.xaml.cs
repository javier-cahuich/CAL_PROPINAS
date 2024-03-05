using CAL_PROPINAS.View;

namespace CAL_PROPINAS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TabbedPageMain());
        }
    }
}