using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
	public partial class MapForm : Form
	{
		public MapForm()
		{
			InitializeComponent();
		}

		internal void ShowLocationOnMap(string i_Location)
		{
			string url = "http://maps.google.com/maps?q=" + i_Location;
			googleMapWebBrowser.Navigate(url);
		}

		private void googleMapWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			googleMapWebBrowser.Document.Body.Style = "overflow:auto";
		}
	}
}
