using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using NReco.VideoConverter;
using ImageMagick;

namespace Model
{
	public class VideoCreator
	{
		public static void createVideo(ICollection<Image> i_ImagesCollection, string i_FileURL, string i_SongURL)
		{
			if (i_ImagesCollection == null || i_ImagesCollection.Count == 0)
			{
				throw new Exception("You didn't sent any images");
			}

			try
			{
				TagLib.File songFile = TagLib.File.Create(i_SongURL, TagLib.ReadStyle.Average);
				int animationDelay = (int)songFile.Properties.Duration.TotalSeconds * 100 / i_ImagesCollection.Count;

				using (MagickImageCollection imageCollection = new MagickImageCollection())
				{
					createImageCollection(i_ImagesCollection, imageCollection, animationDelay);

					FFMpegConverter converter = new NReco.VideoConverter.FFMpegConverter();
					converter.ConvertMedia(
						"video.gif",
						null,
						"video.mp4",
						Format.mp4,
						new ConvertSettings()
					{
						VideoCodec = "libx264"
					});

					converter.ConvertMedia(
						new[] { new FFMpegInput("video.mp4"), new FFMpegInput(i_SongURL) },
						i_FileURL,
						null,
					  new ConvertSettings()
					  {
						  AudioCodec = "copy",
						  VideoCodec = "libx264",
						  CustomInputArgs = "-framerate 25",
						  CustomOutputArgs = " -map 0:v:0 -map 1:a:0 "
					  });
				}
			}
			finally
			{
				File.Delete("video.gif");
				File.Delete("video.mp4");
			}
		}

		public static void createVideo(ICollection<Image> i_ImagesCollection, string i_FileURL)
		{
			if (i_ImagesCollection == null || i_ImagesCollection.Count == 0)
			{
				throw new Exception("You didn't sent any images");
			}

			try
			{
				using (MagickImageCollection imageCollection = new MagickImageCollection())
				{
					createImageCollection(i_ImagesCollection, imageCollection, 600);

					FFMpegConverter converter = new NReco.VideoConverter.FFMpegConverter();
					converter.ConvertMedia(
						"video.gif",
						null,
						i_FileURL,
						Format.mp4,
						new ConvertSettings()
					{
						VideoCodec = "libx264"
					});
				}
			}
			finally
			{
				File.Delete("video.gif");
			}
		}

		private static void createImageCollection(ICollection<Image> i_ImagesCollection, MagickImageCollection imageCollection, int i_AnimationDelay)
		{
			int counter = 0;
			foreach (Image image in i_ImagesCollection)
			{
				imageCollection.Add(new MagickImage(new Bitmap(image, new Size(300, 300))));
				imageCollection[counter].AnimationDelay = i_AnimationDelay;
				counter++;
			}

			QuantizeSettings settings = new QuantizeSettings();
			settings.Colors = 256;
			imageCollection.Quantize(settings);

			imageCollection.Optimize();

			imageCollection.Write("video.gif");
		}
	}
}
