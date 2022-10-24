using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna un save.
    /// </remarks>
    public class FilterSaver : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            PictureProvider provider1 = new PictureProvider();
            provider1.SavePicture(image, "PathToNewImage.jpg");
            return image;
        }
    }
}