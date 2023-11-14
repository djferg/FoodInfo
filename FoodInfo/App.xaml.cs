using FoodInfo.Services;

namespace FoodInfo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        if (SettingsManager.CurrentTheme == SettingsManager.SettingTheme.System)
        {
            AppTheme systemTheme = Application.Current.RequestedTheme;
            if (systemTheme == AppTheme.Light)
            {
                SettingsManager.ApplyTheme(SettingsManager.SettingTheme.Light);
            }
            else if (systemTheme == AppTheme.Dark)
            {
                SettingsManager.ApplyTheme(SettingsManager.SettingTheme.Dark);
            }
            else
            {
                SettingsManager.ApplyTheme(SettingsManager.SettingTheme.System);
            }
        }
        else if (SettingsManager.CurrentTheme == SettingsManager.SettingTheme.Light)
        {
            SettingsManager.ApplyTheme(SettingsManager.SettingTheme.Light);
        }
        else
        {
            SettingsManager.ApplyTheme(SettingsManager.SettingTheme.Dark);
        }
    }
}
