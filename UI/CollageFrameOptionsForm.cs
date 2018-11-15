using Model;
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
	public partial class CollageFrameOptionsForm : Form
	{
		private List<Panel> m_CollageFramePanelList = new List<Panel>();

		public CollageFrameOptionsForm(ICollection<CollageBase> i_AllCollagesCollection)
		{
			InitializeComponent();
			createCollageSkeletonPanels(i_AllCollagesCollection);
		}

		private void createCollageSkeletonPanels(ICollection<CollageBase> i_AllCollagesCollection)
		{
			// location of the panel
			int x = 25, y = 54;
			for(int collageIndex = 3; collageIndex <= 8; collageIndex++)
			{
				Panel panel = new Panel();
				panel.Size = new System.Drawing.Size(150, 150);
				panel.Location = new System.Drawing.Point(x, y);
				m_CollageFramePanelList.Add(panel);
				panelMain.Controls.Add(panel);
				if (x == 455)
				{
					x = 25;
					y += 200;
				}
				else
				{
					x += 215;
				}
			}

			showSkeletons(i_AllCollagesCollection);
		}

		private void showSkeletons(ICollection<CollageBase> i_AllCollagesCollection)
		{

			int index = 0;
			foreach(CollageBase collage in i_AllCollagesCollection)
			{
				PictureBox pb = new PictureBox();
				pb.Location = new Point(0, 0);
				pb.Image = new Bitmap(
					collage.GetSkeleton(),
					new Size(
						m_CollageFramePanelList[index].Width,
						m_CollageFramePanelList[index].Height));

				pb.Size = new Size(
						m_CollageFramePanelList[index].Width,
						m_CollageFramePanelList[index].Height);
				pb.SizeMode = PictureBoxSizeMode.StretchImage;
				pb.BorderStyle = BorderStyle.FixedSingle;
				m_CollageFramePanelList[index].Controls.Add(pb);
				index++;
			}
		}

		internal CollageData.eFrameCollage GetUserChoice()
		{
			return (CollageData.eFrameCollage) panelMain.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).TabIndex;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
