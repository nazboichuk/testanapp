using System.Configuration;

namespace CalculatorTest
{
	public class Config
	{
		public static string WindowsApplicationDriverUrl { get => GetConfigValue("DriverURL"); }
		public static string CalculatorAppId { get => GetConfigValue("AppID"); }
		public static double ImplicitTimeout { get => double.Parse(GetConfigValue("ImplicitTimeout")); }
		

		public static string GetConfigValue(string key)
		{
			var appSettings = ConfigurationManager.AppSettings;
			return appSettings[key];
		}
	}
}
