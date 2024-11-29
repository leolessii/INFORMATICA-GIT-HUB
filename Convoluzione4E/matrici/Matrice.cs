using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

public class Matrice
{
    private int[,] matriceDiConvoluzione = new int[3,3];
    private int[] pixelTettoSinistro = new int[2];
    private int[] pixelTettoDestro = new int[2];
    private int[] pixelFondoSinistro = new int[2];
    private int[] pixelFondoDestro = new int[2];
    private immagine img;
    private int Width;
    private int Height;

    public Matrice(int[,] m)
    {
        matriceDiConvoluzione = m;  
        GetBorderPixels();
    }

    public void GetBorderPixels()
    {
        Width = img.GetWidth();
        Height = img.GetHeight();
        pixelTettoSinistro[0]=0;
        pixelTettoSinistro[1]=0;
        pixelTettoDestro[0]=Width-1;
        pixelTettoDestro[1]=0;
        pixelFondoSinistro[0]=0;
        pixelFondoSinistro[1]=Height-1;
        pixelFondoDestro[0]=Width-1;
        pixelFondoDestro[1]=Height-1;
    }

    private Rgba32 GetNewColorPixel(int x, int y)
    {
        int newRed;
        int newGreen;
        int newBlue;
        int newAlpha;
        Rgba32 color;

        color = img.GetColor(x, y);
        newRed = (color.R * 255);
        if(newRed > 255)
        {
            newRed = 255;
        }
        color.R = Convert.ToByte(newRed);
        newGreen = (color.G * 255);
        if(newGreen > 255)
        {
            newGreen = 255;
        }
        color.G = Convert.ToByte(newGreen);
        newBlue = (color.B * 255);
        if(newBlue > 255)
        {
            newBlue = 255;
        }
        color.B = Convert.ToByte(newBlue);
        newAlpha = (color.A * 255);
        if(newAlpha > 255)
        {
            newAlpha = 255;
        }
        color.A = Convert.ToByte(newAlpha);

        return color;
    }

    private void MatriceWidth(int y)
    {
        int[] pixel = [1,1];
        int x = 1;
        for(int i=0; i<=Width-1; i++)
        {
            img.SetColor(pixel[x], pixel[y], GetNewColorPixel(x,y));
            x++;
        }
    }

    private void MatriceHeight()
    {
        int[] pixel = [1,1];
        int y = 1;
        for(int i = 0; i<=Height-1; i++)
        {
            MatriceWidth(y);
            y++;
        }
    }

    public void StartMatrice()
    {
        MatriceHeight();
    }
}