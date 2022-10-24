using System.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using TwitterUCU;
using System;

namespace CompAndDel
{
    /// <summary>
    /// Esta clase permite leer y guardar imágenes desde archivos.
    /// </summary>
    public class FilterPicturePublisher: IFilter
    {
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter(image, @"PathToImage.png"));
            return image;
        }
        
    }
}