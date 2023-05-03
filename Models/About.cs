using System;
namespace Notes.Models
{
	public class About
	{
		public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "App de concepto de prueba";

        public About()
		{
		}
	}
}

