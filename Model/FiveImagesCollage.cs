using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	public class FiveImagesCollage : CollageBase
	{
		public override void createSubFramePositions()
		{
			s_SubFramePositionList = new List<SubFramePosition>();
			s_SubFramePositionList.Add(new SubFramePosition(new Point(0, 0), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 2, 0), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(0, m_CollageData.Size / 2), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 2, m_CollageData.Size / 2), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
			s_SubFramePositionList.Add(new SubFramePosition(new Point(m_CollageData.Size / 4, m_CollageData.Size / 4), new Size(m_CollageData.Size / 2, m_CollageData.Size / 2)));
		}
	}
}
