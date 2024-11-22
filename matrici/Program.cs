using SixLabors.ImageSharp;
using SixLabors.ImageSharp.ColorSpaces;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.PixelFormats;
using System.Dynamic;
internal class Program
{
    public static immagine im;
    private static void Main(string[] args)
    {
        Console.WriteLine("write the name of the image");
        string name = Console.ReadLine();

        im = new immagine(name);

        Console.WriteLine("Write: \n - 1 for choosing to save a color \n - 2 for choosing to set a color \n - 3 for choosing to save the imagine in  format");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n == 1)
        {
            Console.WriteLine("write the x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write the y");
            int y = Convert.ToInt32(Console.ReadLine());

            im.GetColor(x, y);
        }
        else if(n == 2)
        {
            Console.WriteLine("write the x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write the y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write the color");
            string color = Console.ReadLine();
        }
    }
}