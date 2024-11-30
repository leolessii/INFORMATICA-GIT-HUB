using SixLabors.ImageSharp.Processing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Matrici_Core;

namespace Matrici_Di_Convoluzioni
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Matrice ma;
        Immagine img;

        public MainWindow()
        {
            InitializeComponent();
            int[,] contrasto = new int[,];
            contrasto[0, 1] = -1;
            contrasto[1, 0] = -1;
            contrasto[1, 1] = 5;
            contrasto[1, 2] = -1;
            contrasto[2, 1] = -1;

            Matrice m = new Matrice(contrasto);

        }

        private void btnPercorsoFile_Click(object sender, RoutedEventArgs e)
        {
            img = new Immagine(txtPercorsoFile.Text);
        }

        private void lstMatrici_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ma = new Matrice(lstMatrici.SelectedItem as int[,], img);
        }

        private void btnApplicaMatrice_Click(object sender, RoutedEventArgs e)
        {
            ma.StartMatrice();
            //metti l'immagine
        }
    }
}