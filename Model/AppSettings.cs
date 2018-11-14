using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Model
{
	public class AppSettings
	{
		public string LastAccessToken { get; set; }
		public Point Location { get; set; }
		public bool RememberUser { get; set; }

		private AppSettings() { }

		public static AppSettings LoadFromFile()
		{
			AppSettings appSettings = new AppSettings();

			if (File.Exists("appSettings.xml"))
			{
				using (Stream stream = new FileStream("appSettings.xml", FileMode.Open))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
					appSettings = serializer.Deserialize(stream) as AppSettings;
				}
			}

			return appSettings;
		}

		public void SaveToFile()
		{
			using (Stream stream = new FileStream("appSettings.xml", FileMode.Create))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
				serializer.Serialize(stream, this);
			}
		}
	}
}
