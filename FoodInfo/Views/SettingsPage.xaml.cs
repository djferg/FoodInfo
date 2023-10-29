namespace FoodInfo.Views;
using FoodInfo.Services;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private void LightThemeChecked(object sender, CheckedChangedEventArgs e)
    {
        SettingsManager.CurrentTheme = AppTheme.Light;
    }

    private void DarkThemeChecked(object sender, CheckedChangedEventArgs e)
    {
        SettingsManager.CurrentTheme = AppTheme.Dark;
    }

    private void SystemThemeChecked(object sender, CheckedChangedEventArgs e)
    {
        SettingsManager.CurrentTheme = AppTheme.System;
    }
}