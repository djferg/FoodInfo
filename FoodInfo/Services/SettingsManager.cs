using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodInfo.Services
{
    internal class SettingsManager
    {
        static public SettingTheme CurrentTheme
        {
            get
            {
                string themeString = Preferences.Get("SettingTheme", SettingTheme.System.ToString());
                if (Enum.TryParse(themeString, out SettingTheme theme))
                {
                    return theme;
                }
                return SettingTheme.System;
            }
            set { Preferences.Set("AppTheme", value.ToString()); }
        }

        public static void ApplyTheme(SettingTheme theme)
        {
            CurrentTheme = theme;

            Application.Current.Resources.MergedDictionaries.Clear();

            switch (theme)
            {
                case SettingTheme.Light:
                    Application.Current.Resources.MergedDictionaries.Add(new LightTheme());
                    break;
                case SettingTheme.Dark:
                    Application.Current.Resources.MergedDictionaries.Add(new DarkTheme());
                    break;
                case SettingTheme.System:
                    var requestedTheme = Application.Current.RequestedTheme;
                    if (requestedTheme.ToString() == "Dark")
                    {
                        Application.Current.Resources.MergedDictionaries.Add(new DarkTheme());
                        break;
                    } else
                    {
                        Application.Current.Resources.MergedDictionaries.Add(new LightTheme());
                        break;
                    }
                   
            }

        }

        public enum SettingTheme
        {
            Light,
            Dark,
            System
        }
    }
}
