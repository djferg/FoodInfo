namespace FoodInfo.Views;
using FoodInfo.Services;

public partial class SettingsView : ContentPage
{
    bool isInitializing = true;
    public SettingsView()
    {
        isInitializing = true;

        InitializeComponent();

        InitializePreferences();

        isInitializing = false;
    }

    private void InitializePreferences()
    {
        if (SettingsManager.CurrentTheme == SettingsManager.SettingTheme.Light)
        {
            ThemeLight.IsChecked = true;
        }
        else if (SettingsManager.CurrentTheme == SettingsManager.SettingTheme.Dark)
        {
            ThemeDark.IsChecked = true;
        }
        else
        {
            ThemeSystem.IsChecked = true;
        }
    }
    private void ThemeChanged(object sender, CheckedChangedEventArgs e)
    {
        if (isInitializing) return;

        RadioButton radioButton = (RadioButton)sender;

        if (radioButton.Content.ToString() == "Light")
        {
            SettingsManager.ApplyTheme(SettingsManager.SettingTheme.Light);
        }
        else if (radioButton.Content.ToString() == "Dark")
        {
            SettingsManager.ApplyTheme(SettingsManager.SettingTheme.Dark);
        }
        else
        {
            SettingsManager.ApplyTheme(SettingsManager.SettingTheme.System);
        }
    }

    private void ModeChanged(object sender, CheckedChangedEventArgs e)
    {
        if (isInitializing) return;

        RadioButton radioButton = (RadioButton)sender;

        if (radioButton.Content.ToString() == "Production")
        {
            SettingsManager.ApplyMode(SettingsManager.AppMode.Production);
        }
        else if (radioButton.Content.ToString() == "Developer")
        {
            SettingsManager.ApplyMode(SettingsManager.AppMode.Developer);
        }
    }
}