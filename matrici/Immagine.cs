using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

public class immagine
{
    public Image<Rgba32> image;
    public Color colorTaken;

    public immagine(string nameImage)
    {
        image = Image.Load<Rgba32>(nameImage);
    }

    public void GetColor(int x, int y)
    {
        colorTaken = image[x,y];
    }

    public void SetColor(int x, int y, Color color)
    {
        image[x, y] = color;
    }

    public void Save(string path, int chouse)
    {
        if(chouse == 1)
        {
            //png
            image.SaveAsPng($"{path}.png");
            
        }
        else if(chouse == 2)
        {
            //jpg
            image.SaveAsJpeg($"{path}.jpg");
        }
    }
}