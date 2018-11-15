using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	public class SevenImagesCollage : CollageBase
	{
		public override void createSubFramePositions()
		{
			s_SubFramePositionList = new List<SubFramePosition>();
			s_SubFramePositionList.Add(new SubFramePosition(new Point(0, 0), new Size(2 * m_CollageData.Size / 3, 2 * m_CollageData.Size / 3)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(2 * m_CollageData.Size / 3, 0), new Size(m_CollageData.Size / 3, m_CollageData.Size / 3)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(2 * m_CollageData.Size / 3, m_CollageData.Size / 3), new Size(m_CollageData.Size / 3, m_CollageData.Size / 3)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(2 * m_CollageData.Size / 3, 2 * m_CollageData.Size / 3), new Size(m_CollageData.Size / 6, m_CollageData.Size / 3)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(5 * m_CollageData.Size / 6, 2 * m_CollageData.Size / 3), new Size(m_CollageData.Size / 6, m_CollageData.Size / 3)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(0, 2 * m_CollageData.Size / 3), new Size(m_CollageData.Size / 3, m_CollageData.Size / 3)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 3, 2 * m_CollageData.Size / 3), new Size(m_CollageData.Size / 3, m_CollageData.Size / 3)));
		}
	}
}
