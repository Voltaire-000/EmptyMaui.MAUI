namespace EmptyMaui.MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            App.Current.UserAppTheme = AppTheme.Light;
        }
    }
}