using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
	public class PhotoPictureBox : PictureBox
	{
		public Photo Photo { get; set; }
	}
}
