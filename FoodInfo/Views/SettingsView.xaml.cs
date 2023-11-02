namespace FoodInfo.Views;
using FoodInfo.Services;

public partial class SettingsView : ContentPage
{
	public SettingsView()
	{
		InitializeComponent();
	}

    private void LightThemeChecked(object sender, CheckedChangedEventArgs e)
    {
        SettingsManager.ApplyTheme(SettingsManager.SettingTheme.Light);
    }

    private void DarkThemeChecked(object sender, CheckedChangedEventArgs e)
    {
        SettingsManager.ApplyTheme(SettingsManager.SettingTheme.Dark);
    }

    private void SystemThemeChecked(object sender, CheckedChangedEventArgs e)
    {
        SettingsManager.ApplyTheme(SettingsManager.SettingTheme.System);
    }
}