using System;
using System.Drawing;
using System.Drawing.Imaging;

public class Generator
{
    public void Generate()
    {
        var image = new Bitmap("./src/image.jpg");
        var alpha = new Bitmap("./src/alpha.png");

        if (image.Width != alpha.Width || image.Height != alpha.Height)
        {
            Console.Error.WriteLine("The both image must have the same area.");

            return;
        }

        var output = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);

        for (var y = 0; y < image.Height; ++y)
        {
            for (var x = 0; x < image.Width; ++x)
            {
                output.SetPixel(
                    x,
                    y,
                    Color.FromArgb(
                        byte.MaxValue - alpha.GetPixel(x, y).A / byte.MaxValue,
                        image.GetPixel(x, y)
                    )
                );
            }
        }

        output.Save("./dist/christmas.png");
    }
}
