using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Model
{
	public sealed class AppSettings
	{
		private static readonly object	sr_ContextLock = new object();
		private static AppSettings		m_AppSettings;

		public string LastAccessToken { get; set; }

		public Point Location { get; set; }

		public bool RememberUser { get; set; }

		public static AppSettings Instance
		{
			get
			{
				return LoadFromFile();
			}
		}

		private AppSettings()
		{
		}

		private static AppSettings LoadFromFile()
		{
			if (m_AppSettings == null)
			{
				lock (sr_ContextLock)
				{
					if (m_AppSettings == null)
					{
						m_AppSettings = new AppSettings();
					}
				}
			}

			if (File.Exists("AppSettings.xml"))
			{
				using (Stream stream = new FileStream("AppSettings.xml", FileMode.Open))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
					m_AppSettings = serializer.Deserialize(stream) as AppSettings;
				}
			}

			return m_AppSettings;
		}

		public void SaveToFile()
		{
			using (Stream stream = new FileStream("AppSettings.xml", FileMode.Create))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
				serializer.Serialize(stream, this);
			}
		}
	}
}
