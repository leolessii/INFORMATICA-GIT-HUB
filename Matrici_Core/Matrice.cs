using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Matrici_Core
{
    public class Matrice
    {
        private int[,] matrice;
        private int moltiplicatore;
        private Immagine img;
        private int Width;
        private int Height;

        public Matrice(int[,] m, Immagine i)
        {
            matrice = m;
            img = i;
            moltiplicatore = matrice[1, 1];
        }

        private Rgba32 GetNewColorPixel(int x, int y)
        {
            int newRed;
            int newGreen;
            int newBlue;
            int newAlpha;
            Rgba32 color;

            color = img.GetColor(x, y);
            newRed = (color.R * moltiplicatore);
            if (newRed > 255)
            {
                newRed = 255;
            }
            color.R = Convert.ToByte(newRed);
            newGreen = (color.G * moltiplicatore);
            if (newGreen > 255)
            {
                newGreen = 255;
            }
            color.G = Convert.ToByte(newGreen);
            newBlue = (color.B * moltiplicatore);
            if (newBlue > 255)
            {
                newBlue = 255;
            }
            color.B = Convert.ToByte(newBlue);
            newAlpha = (color.A * moltiplicatore);
            if (newAlpha > 255)
            {
                newAlpha = 255;
            }
            color.A = Convert.ToByte(newAlpha);

            return color;
        }

        private void MatriceWidth(int y)
        {
            int[] pixel = [1, 1];
            int x = 1;
            for (int i = 0; i <= Width - 1; i++)
            {
                img.SetColor(pixel[x], pixel[y], GetNewColorPixel(x, y));
                x++;
            }
        }

        private void MatriceHeight()
        {
            int[] pixel = [1, 1];
            int y = 1;
            for (int i = 0; i <= Height - 1; i++)
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
}
