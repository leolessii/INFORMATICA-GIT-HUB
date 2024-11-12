using Classi_SolitarioTiramisu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf_SolitarioTiramisu
{
    /// <summary>
    /// Logica di interazione per PaginaFinale.xaml
    /// </summary>
    public partial class PaginaFinale : Window
    {
        public PaginaFinale(Partita p)
        {
            InitializeComponent();
            txtNome.Text = p.Giocatore.Nome;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow inizio = new MainWindow();
            this.Close();
            inizio.Show();
        }
    }
}
