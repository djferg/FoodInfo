using Java.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodInfo.Services
{
    internal class SettingsManager
    {
		static public AppTheme CurrentTheme
		{
			get 
            { 
                string themeString = Preferences.Get("AppTheme", AppTheme.System.ToString());
                if (Enum.TryParse(themeString, out AppTheme theme))
                {
                    return theme;
                }
                return AppTheme.System;
            }
			set { Preferences.Set("AppTheme", value.ToString()); }
		}

    }

    public enum AppTheme
    {
        Light,
        Dark,
        System
    }
}
