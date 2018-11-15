using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	class FiveImagesCollage : ICollageble
	{
		private CollageData m_CollageData = new CollageData();
		private static Bitmap s_CollageSkeleton;
		private static List<SubFramePosition> s_SubFramePositionList;

		public Bitmap Collage
		{
			get
			{
				return m_CollageData.Collage;
			}
		}

		public Bitmap GetSkeleton()
		{
			if (s_CollageSkeleton == null)
			{
				createSkeleton();
			}
			return s_CollageSkeleton;
		}

		private void createSkeleton()
		{
			createSubFramePositions();
			s_CollageSkeleton = new Bitmap(m_CollageData.Size, m_CollageData.Size);
			using (Graphics g = Graphics.FromImage(s_CollageSkeleton))
			{
				foreach(SubFramePosition subFramePosition in s_SubFramePositionList)
				{
					g.FillRectangle(Brushes.LightGray, new Rectangle(subFramePosition.Point, subFramePosition.Size));
					g.DrawRectangle(new Pen(Color.Black), new Rectangle(subFramePosition.Point, subFramePosition.Size));
				}

				g.DrawImage(s_CollageSkeleton, new Point(0, 0));
			}
		}

		private void createSubFramePositions()
		{
			s_SubFramePositionList = new List<SubFramePosition>();
			s_SubFramePositionList.Add(new SubFramePosition(new Point(0, 0), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 2, 0), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(0, m_CollageData.Size / 2), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 2, m_CollageData.Size / 2), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 4, m_CollageData.Size / 4), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
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
