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
            box_classe.Visibility = Visibility.Collapsed;
            box_codiceFiscale.Visibility = Visibility.Collapsed;
            box_cognome.Visibility = Visibility.Collapsed;
            box_materia.Visibility = Visibility.Collapsed;
            box_matricola.Visibility = Visibility.Collapsed;
            box_nome.Visibility = Visibility.Collapsed;
            box_salario.Visibility = Visibility.Collapsed;
            box_sezione.Visibility = Visibility.Collapsed;
            btn_aggiungiStudente2.Visibility= Visibility.Collapsed;
            btn_aggiungiDocente2.Visibility= Visibility.Collapsed;
            btn_aggiungiCollaboratore2.Visibility = Visibility.Collapsed;
            btn_cambia.Visibility = Visibility.Collapsed;   

            scuola = new Scuola();
        }

        private void btn_aggiungiStudente_Click(object sender, RoutedEventArgs e)
        {
            btn_aggiungiCollaboratore.Visibility = Visibility.Hidden;
            btn_aggiungiStudente.Visibility = Visibility.Hidden;
            btn_aggiungiDocente.Visibility = Visibility.Hidden;

            box_nome.Visibility = Visibility.Visible;
            box_cognome.Visibility = Visibility.Visible;
            box_codiceFiscale.Visibility = Visibility.Visible;
            box_matricola.Visibility = Visibility.Visible;
            box_classe.Visibility = Visibility.Visible;
            box_sezione.Visibility = Visibility.Visible;
            btn_aggiungiStudente2.Visibility= Visibility.Visible;
            btn_cambia.Visibility = Visibility.Visible;



        }

        private void btn_aggiungiDocente_Click(object sender, RoutedEventArgs e)
        {
            btn_aggiungiCollaboratore.Visibility = Visibility.Hidden;
            btn_aggiungiStudente.Visibility = Visibility.Hidden;
            btn_aggiungiDocente.Visibility = Visibility.Hidden;

            box_nome.Visibility = Visibility.Visible;
            box_cognome.Visibility = Visibility.Visible;
            box_codiceFiscale.Visibility = Visibility.Visible;
            box_materia.Visibility = Visibility.Visible;
            box_salario.Visibility = Visibility.Visible;
            btn_aggiungiDocente2.Visibility = Visibility.Visible;
            btn_cambia.Visibility = Visibility.Visible;

        }

        private void btn_aggiungiCollaboratore_Click(object sender, RoutedEventArgs e)
        {
            btn_aggiungiCollaboratore.Visibility = Visibility.Hidden;
            btn_aggiungiStudente.Visibility = Visibility.Hidden;
            btn_aggiungiDocente.Visibility = Visibility.Hidden;

            box_nome.Visibility = Visibility.Visible;
            box_cognome.Visibility = Visibility.Visible;
            box_codiceFiscale.Visibility = Visibility.Visible;
            btn_aggiungiCollaboratore2.Visibility = Visibility.Visible;
            btn_cambia.Visibility = Visibility.Visible;
        }


        private void btn_aggiungiStudente2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome=box_nome.Text;
                string cognome = box_cognome.Text;
                string codiceFiscale= box_codiceFiscale.Text;
                int matricola= Convert.ToInt32(box_matricola.Text);
                int classe = Convert.ToInt32(box_classe.Text);
                char sezione= Convert.ToChar(box_sezione.Text);

                if (nome == null || nome.Trim().Length==0)
                {
                    MessageBox.Show("il noome non è valido");
                    return;
                }

                if (cognome == null || cognome.Trim().Length == 0)
                {
                    MessageBox.Show("il cognome non è valido");
                    return;
                }

                if (codiceFiscale == null || codiceFiscale.Trim().Length != 16)
                {
                    MessageBox.Show("il codice fiscale non è valido");
                    return;
                }

                Studente studente = new Studente(nome, cognome, codiceFiscale, matricola, classe, sezione);
               scuola.AggiungiStudente(studente);
                MessageBox.Show("studente aggiunto");

                box_nome.Text ="inserisci nome";
                box_cognome.Text= "inserisci cognome";
                box_codiceFiscale.Text = "inserisci codice fiscale";
                box_matricola.Text = "inserisci matricola";
                box_classe.Text = "inserisci classe";
                box_sezione.Text = "inserisci sezione";


            }
            catch (Exception ex) { MessageBox.Show("errore: " + ex.Message); }
                
        }

        private void btn_aggiungiDocente2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome = box_nome.Text;
                string cognome = box_cognome.Text;
                string codiceFiscale = box_codiceFiscale.Text;
                string materia = box_materia.Text;
                double salario = Convert.ToDouble(box_salario.Text);

                if (nome == null || nome.Trim().Length == 0)
                {
                    MessageBox.Show("il noome non è valido");
                    return;
                }

                if (cognome == null || cognome.Trim().Length == 0)
                {
                    MessageBox.Show("il cognome non è valido");
                    return;
                }

                if (codiceFiscale == null || codiceFiscale.Trim().Length != 16)
                {
                    MessageBox.Show("il codice fiscale non è valido");
                    return;
                }

                if (materia == null || materia.Trim().Length == 0)
                {
                    MessageBox.Show("la materia non è valido");
                    return;
                }

                if (salario == null || salario<=0 )
                {
                    MessageBox.Show("il  salario non è valido");
                    return;
                }

                Docente docente = new Docente(nome, cognome, codiceFiscale, materia, salario);
                scuola.AggiungiDocente(docente);
                MessageBox.Show("docente aggiunto");

                box_nome.Text = "inserisci nome";
                box_cognome.Text = "inserisci cognome";
                box_codiceFiscale.Text = "inserisci codice fiscale";
                box_materia.Text = "inserisci materia";
                box_salario.Text = "inserisci salario";
                

            }
            catch (Exception ex) { MessageBox.Show("errore: " + ex.Message); }

        }

        private void btn_aggiungiCollaboratore2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome = box_nome.Text;
                string cognome = box_cognome.Text;
                string codiceFiscale = box_codiceFiscale.Text;
                string mail = box_email.Text;
                

                if (nome == null || nome.Trim().Length == 0)
                {
                    MessageBox.Show("il noome non è valido");
                    return;
                }

                if (cognome == null || cognome.Trim().Length == 0)
                {
                    MessageBox.Show("il cognome non è valido");
                    return;
                }

                if (codiceFiscale == null || codiceFiscale.Trim().Length != 16)
                {
                    MessageBox.Show("il codice fiscale non è valido");
                    return;
                }

                if (mail == null || mail == "")
                {
                    MessageBox.Show("la mail non è valida");
                    return;
                }

                CollaboratoreEsterno c = new CollaboratoreEsterno(nome, cognome, codiceFiscale, mail);
                scuola.AggiungiCollaboratore(c);
                MessageBox.Show("collaboratore aggiunto");

                box_nome.Text = "inserisci nome";
                box_cognome.Text = "inserisci cognome";
                box_codiceFiscale.Text = "inserisci codice fiscale";
              

            }
            catch (Exception ex) { MessageBox.Show("errore: " + ex.Message); }

        }

        private void btn_cambia_Click(object sender, RoutedEventArgs e)
        {
            btn_cambia.Visibility= Visibility.Collapsed;
            btn_aggiungiStudente.Visibility = Visibility.Visible;
            btn_aggiungiCollaboratore.Visibility = Visibility.Visible;
            btn_aggiungiDocente.Visibility = Visibility.Visible;

            box_classe.Visibility = Visibility.Collapsed;
            box_codiceFiscale.Visibility = Visibility.Collapsed;
            box_cognome.Visibility = Visibility.Collapsed;
            box_materia.Visibility = Visibility.Collapsed;
            box_matricola.Visibility = Visibility.Collapsed;
            box_nome.Visibility = Visibility.Collapsed;
            box_salario.Visibility = Visibility.Collapsed;
            box_sezione.Visibility = Visibility.Collapsed;
            btn_aggiungiStudente2.Visibility = Visibility.Collapsed;
            btn_aggiungiDocente2.Visibility = Visibility.Collapsed;
            btn_aggiungiCollaboratore2.Visibility = Visibility.Collapsed;

        }
    }
}