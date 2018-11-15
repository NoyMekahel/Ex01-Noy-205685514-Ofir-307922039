using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	class ThreeImagesCollage : ICollageble
	{
		private CollageData m_CollageData = new CollageData();
		private static Bitmap s_CollageSkeleton;

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
			s_CollageSkeleton = new Bitmap(m_CollageData.Size, m_CollageData.Size);
			using (Graphics g = Graphics.FromImage(s_CollageSkeleton))
			{
				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(0, 0), new Size(m_CollageData.Size / 2, m_CollageData.Size)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(0, 0), new Size(m_CollageData.Size / 2, m_CollageData.Size)));
				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(m_CollageData.Size / 2, 0), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(m_CollageData.Size / 2, 0), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(m_CollageData.Size / 2, m_CollageData.Size / 2), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(m_CollageData.Size / 2, m_CollageData.Size / 2), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
				
				g.DrawImage(s_CollageSkeleton, new Point(0, 0));
			}
		}

		public void CreateCollage(ICollection<Image> i_SelectedImages)
		{
			throw new NotImplementedException();
		}

		public void Save(string i_FilePath)
		{
			throw new NotImplementedException();
		}
	}
}
