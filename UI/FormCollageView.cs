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
	public partial class FormCollageView : Form
	{
		private CollageBase m_Collage;

		public FormCollageView(CollageBase i_Collage)
		{
			InitializeComponent();
			m_Collage = i_Collage;
			showCollage();
		}

		private void showCollage()
		{
			pictureBoxCollageView.Image = m_Collage.Collage;
			pictureBoxCollageView.SizeMode = PictureBoxSizeMode.StretchImage;
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
					FormFacebookApp.showFacebookError(ex.Message);
				}
			}

			MessageBox.Show("Your collage saved!");
			this.Close();
		}
	}
}
