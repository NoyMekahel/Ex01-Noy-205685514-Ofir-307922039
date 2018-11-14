using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace UI
{
	public partial class PhotoInfo : Form
	{
		public PhotoInfo(PhotoPictureBox i_photo)
		{
			InitializeComponent();
			initPhotoInfo(i_photo);
		}

		private void initPhotoInfo(PhotoPictureBox i_photo)
		{
			photoPictureBox.Image = i_photo.Image;
			photoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			likesPictureBox.Image = global::UI.Properties.Resources.like;
			likesLabel.Text = string.Format("Your photo liked by {0} people", i_photo.Photo.LikedBy.Count);
			foreach (Comment comment in i_photo.Photo.Comments)
			{
				commentsListBox.Items.Add(comment.Message);
			}		
		}
	}
}
