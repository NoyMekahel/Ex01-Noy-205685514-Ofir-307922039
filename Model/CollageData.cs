using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	public class CollageData
	{
		private readonly Point r_InitPoint = new Point(0, 0);
		private const int k_Size = 600;
		public enum eFrameCollage { THREE_IMAGES, FOUR_IMAGES, FIVE_IMAGES, SIX_IMAGES, SEVEN_IMAGES, EIGHT_IMAGES }
		public Bitmap Collage { get; set; }
		public Bitmap CollageSkeleton { get; set; }
		public List<SubFramePosition> SubFramePositionList { get; set; }

		public int Size
		{
			get
			{
				return k_Size;
			}
		}

		public Point InitPoint
		{
			get
			{
				return r_InitPoint;
			}
		}
	}
}
