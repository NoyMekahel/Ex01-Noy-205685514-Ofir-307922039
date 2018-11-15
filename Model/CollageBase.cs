using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	public abstract class CollageBase
	{
		protected CollageData m_CollageData = new CollageData();
		protected Bitmap s_CollageSkeleton;
		protected List<SubFramePosition> s_SubFramePositionList;

		public abstract void createSubFramePositions();

		public Bitmap Collage
		{
			get
			{
				return m_CollageData.Collage;
			}
		}

		public Bitmap GetSkeleton()
		{
			createSkeleton();
			return s_CollageSkeleton;
		}

		protected void createSkeleton()
		{
			createSubFramePositions();
			s_CollageSkeleton = new Bitmap(m_CollageData.Size, m_CollageData.Size);
			using (Graphics g = Graphics.FromImage(s_CollageSkeleton))
			{
				foreach (SubFramePosition subFramePosition in s_SubFramePositionList)
				{
					g.FillRectangle(Brushes.LightGray, new Rectangle(subFramePosition.Point, subFramePosition.Size));
					g.DrawRectangle(new Pen(Color.Black), new Rectangle(subFramePosition.Point, subFramePosition.Size));
				}

				g.DrawImage(s_CollageSkeleton, new Point(0, 0));
			}
		}

		public void CreateCollage(ICollection<Image> i_SelectedImages)
		{
			m_CollageData.Collage = new Bitmap(m_CollageData.Size, m_CollageData.Size);
			using (Graphics g = Graphics.FromImage(m_CollageData.Collage))
			{
				int counter = 0;
				foreach (SubFramePosition subFramePosition in s_SubFramePositionList)
				{
					g.DrawImage(
						i_SelectedImages.ElementAt(counter),
						subFramePosition.Point.X,
						subFramePosition.Point.Y,
						subFramePosition.Size.Width,
						subFramePosition.Size.Height);
					counter++;
				}

				g.DrawImage(m_CollageData.Collage, new Point(0, 0));
			}
		}

		public void Save(string i_FilePath)
		{
			m_CollageData.Collage.Save(i_FilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
		}
	}
}
