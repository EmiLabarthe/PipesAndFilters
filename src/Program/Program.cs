using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PipeNull pipeNull = new PipeNull();
            FilterNegative filterNegative = new FilterNegative();
            PipeSerial pipeSerial = new PipeSerial(filterNegative, pipeNull);
            FilterGreyscale filterGreyscale = new FilterGreyscale();
            PipeSerial pipeSerial1 = new PipeSerial(filterGreyscale, pipeSerial);

            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"PathToImageToLoad.jpg");
            IPicture pictureAfterPipes = pipeSerial1.Send(picture);
            provider.SavePicture(pictureAfterPipes, @"PathToImageToSave.jpg");
            provider.SavePicture(pictureAfterPipes, "PathToNewImage.jpg");

            
        }
    }
}
