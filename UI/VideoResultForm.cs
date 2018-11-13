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
	public partial class VideoResultForm : Form
	{
		public VideoResultForm(string i_VideoURL)
		{
			InitializeComponent();
			videoResultWindowsMediaPlayer.URL = i_VideoURL;
		}


		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			videoResultWindowsMediaPlayer.Ctlcontrols.stop();
		}
	}
}
