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

namespace Scuola_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Scuola scuola;

        public MainWindow()
        {
            InitializeComponent();
            scuola = new Scuola();
            lst_Classi.ItemsSource = scuola.Classi;

            //nascondo collaboratore
            btn_AggiugniCollaboratore.Visibility = Visibility.Collapsed;
            txtNomeC.Visibility = Visibility.Collapsed;
            txtCognomeC.Visibility = Visibility.Collapsed;
            txtCodicefiscaleC.Visibility = Visibility.Collapsed;
            txtEmail.Visibility = Visibility.Collapsed;

            //nascondo docente
            btn_AggiugniDocente.Visibility = Visibility.Collapsed;
            txtNomeD.Visibility = Visibility.Collapsed;
            txtCognomeD.Visibility = Visibility.Collapsed;
            txtCodicefiscaleD.Visibility = Visibility.Collapsed;
            txtMateria.Visibility = Visibility.Collapsed;
            txtSalario.Visibility = Visibility.Collapsed;

            //nascondo studente
            btn_AggiugniStudente.Visibility = Visibility.Collapsed;
            txtNome.Visibility = Visibility.Collapsed;
            txtCognome.Visibility = Visibility.Collapsed;
            txtCodicefiscale.Visibility = Visibility.Collapsed;
            txtMatricola.Visibility = Visibility.Collapsed;
        }

        private void lst_Classi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_AggiugniCollaboratore.Visibility = Visibility.Visible;
            txtNomeC.Visibility = Visibility.Visible;
            txtCognomeC.Visibility = Visibility.Visible;
            txtCodicefiscaleC.Visibility = Visibility.Visible;
            txtEmail.Visibility = Visibility.Visible;

            btn_AggiugniDocente.Visibility = Visibility.Visible;
            txtNomeD.Visibility = Visibility.Visible;
            txtCognomeD.Visibility = Visibility.Visible;
            txtCodicefiscaleD.Visibility = Visibility.Visible;
            txtMateria.Visibility = Visibility.Visible;
            txtSalario.Visibility = Visibility.Visible;

            btn_AggiugniStudente.Visibility = Visibility.Visible;
            txtNome.Visibility = Visibility.Visible;
            txtCognome.Visibility = Visibility.Visible;
            txtCodicefiscale.Visibility = Visibility.Visible;
            txtMatricola.Visibility = Visibility.Visible;
        }

        private void btn_AggiugniClasse_Click(object sender, RoutedEventArgs e)
        {
            int anno = Convert.ToInt32(txtAnno.Text);
            Char sezione = Convert.ToChar(txtSezione.Text);
            Classe c = new Classe(anno, sezione);
            scuola.AggiugniClasse(c);
            lst_Classi.ItemsSource = null;
            lst_Classi.ItemsSource = scuola.Classi;
        }

        private void btn_AggiugniCollaboratore_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtNomeC.Text;
            string cognome = txtCognomeC.Text;
            string codiceFiscale = txtCodicefiscaleC.Text;
            string email = txtEmail.Text;
            CollaboratoreEsterno cE = new CollaboratoreEsterno(nome, cognome, codiceFiscale, email);
            scuola.AggiungiCollaboratore(cE);
        }

        private void btn_AggiugniDocente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_AggiugniStudente_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}