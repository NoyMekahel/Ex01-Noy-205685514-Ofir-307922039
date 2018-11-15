﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	class EightImagesCollage : ICollageble
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
				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(0, 0), new Size(3 * m_CollageData.Size / 4, 3 * m_CollageData.Size / 4)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(0, 0), new Size(3 * m_CollageData.Size / 4, 3 * m_CollageData.Size / 4)));

				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(3 * m_CollageData.Size / 4, 0), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(3 * m_CollageData.Size / 4, 0), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(3 * m_CollageData.Size / 4, m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(3 * m_CollageData.Size / 4, m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(3 * m_CollageData.Size / 4, m_CollageData.Size / 2), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(3 * m_CollageData.Size / 4, m_CollageData.Size / 2), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(3 * m_CollageData.Size / 4, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(3 * m_CollageData.Size / 4, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));

				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(0, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(0, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(m_CollageData.Size / 4, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(m_CollageData.Size / 4, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.FillRectangle(Brushes.LightGray, new Rectangle(new Point(m_CollageData.Size / 2, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));
				g.DrawRectangle(new Pen(Color.Black), new Rectangle(new Point(m_CollageData.Size / 2, 3 * m_CollageData.Size / 4), new Size(m_CollageData.Size / 4, m_CollageData.Size / 4)));

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
