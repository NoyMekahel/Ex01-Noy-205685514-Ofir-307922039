using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	public class SixImagesCollage : CollageBase
	{
		public override void createSubFramePositions()
		{
			s_SubFramePositionList = new List<SubFramePosition>();
			s_SubFramePositionList.Add(new SubFramePosition(new Point(0, 0), new Size(m_CollageData.Size / 3, 2 * m_CollageData.Size / 5)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(0, 2 * m_CollageData.Size / 5), new Size(m_CollageData.Size / 3, 3 * m_CollageData.Size / 5)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 3, 0), new Size(m_CollageData.Size / 3, 3 * m_CollageData.Size / 5)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 3, 3 * m_CollageData.Size / 5), new Size(m_CollageData.Size / 3, 2 * m_CollageData.Size / 5)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(2 * m_CollageData.Size / 3, 0), new Size(m_CollageData.Size / 3, m_CollageData.Size / 2)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(2 * m_CollageData.Size / 3, m_CollageData.Size / 2), new Size(m_CollageData.Size / 3, m_CollageData.Size / 2)));
		}
	}
}
