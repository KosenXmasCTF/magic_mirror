using System.Drawing;
using System.Drawing.Imaging;

public class Solver
{
    public void Solve()
    {
        var image = new Bitmap("./dist/christmas.png");
        var output = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);

        for (var y = 0; y < image.Height; ++y)
        {
            for (var x = 0; x < image.Width; ++x)
            {
                output.SetPixel(
                    x,
                    y,
                    image.GetPixel(x, y).A == byte.MaxValue
                        ? Color.Transparent
                        : Color.Black
                );
            }
        }

        output.Save("./dist/solved.png");
    }
}
