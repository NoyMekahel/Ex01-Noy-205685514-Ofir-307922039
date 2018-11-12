using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
	public partial class VideoCreatorControl : UserControl
	{
		public VideoCreatorControl()
		{
			InitializeComponent();
		}

		private void sharedPhotosRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if(sharedPhotosRadioButton.Checked == true)
			{

			}
			else
			{
				friendsCheckedListBox.Visible = false;
			}
		}

		private void albumsPhotosRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (albumsPhotosRadioButton.Checked == true)
			{

			}
			else
			{
				albumsCheckedListBox.Visible = false;
			}
		}

		private void createVideoButton_Click(object sender, EventArgs e)
		{

		}
	}
}
