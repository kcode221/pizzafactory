using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PizzaFactory
{
    public static class Utils
    {
        public static int GetSettingInt(string key)
        {
            int i;
            return int.TryParse(ConfigurationManager.AppSettings[key], out i) ? i : -1;
        }

        public static float GetSettingFloat(string key)
        {
            float i;
            return float.TryParse(ConfigurationManager.AppSettings[key], out i) ? i : -1;
        }

        public static string GetSettingString(string key)
        {
            
            return ConfigurationManager.AppSettings[key]??"".ToString();
        }
    }
}
