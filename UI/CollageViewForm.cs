using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace UI
{
	public partial class CollageViewForm : Form
	{
		private ICollageble m_Collage;

		public CollageViewForm(ICollageble i_Collage)
		{
			InitializeComponent();
			m_Collage = i_Collage;
			showCollage();
		}

		private void showCollage()
		{
			collageViewPictureBox.Image = m_Collage.Collage;
			collageViewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void saveAsButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "(*.Jpeg)|*.Jpeg";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					m_Collage.Save(saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					FacebookApp.showFacebookError(ex.Message);
				}
			}
		}

	}
}
