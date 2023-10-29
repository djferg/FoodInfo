namespace FoodInfo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        Current.RequestedThemeChanged += Current_RequestedThemeChanged;
	}

    private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
    {
        throw new NotImplementedException();
    }
}
