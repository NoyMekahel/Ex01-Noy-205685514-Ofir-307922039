using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Model
{
	public interface ICollageble
	{
		Bitmap GetSkeleton();
		void CreateCollage(ICollection<Image> i_SelectedImages);
		void Save(string i_FilePath);
		Bitmap Collage { get; }
	}
}
