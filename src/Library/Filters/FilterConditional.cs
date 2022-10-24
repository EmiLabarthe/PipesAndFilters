using System.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using CognitiveCoreUCU;
using System;

namespace CompAndDel
{
    /// <summary>
    /// Esta clase permite leer y guardar imágenes según su condición.
    /// </summary>
    public class FilterConditional
    {
        static void Main(string[] args)
        {
            CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow);
            cog.Recognize(@"bill.jpg");
            FoundFace(cog);
            cog.Recognize(@"yacht.jpg");
            FoundFace(cog);
            cog.Recognize(@"bill2.jpg");
            FoundFace(cog);
        }

        static void FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
            }
            else
                Console.WriteLine("No Face Found");
        }
    }
}