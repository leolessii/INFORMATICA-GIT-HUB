using MorraCineseLibrary;
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

namespace MorraCineseWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IInputInterface, IOutputInterface
    {
        GameManager gameManager;
        public MainWindow()
        {

            gameManager = new GameManager(new ComputerPlayer(), new HumanPlayer("prova", this), this); //in "prova" inserire il nome che verrà chiesto in gui
            InitializeComponent();
        }



        Symbol IInputInterface.InputChoice()
        {
            if(btnCarta.Visibility == Visibility.Visible) return Symbol.Paper;
            if(btnForbice.Visibility == Visibility.Visible) return Symbol.Scissor;
            return Symbol.Rock;
        }

        void IOutputInterface.OutputChoices(Symbol symbol1, Symbol symbol2)
        {
            MessageBox.Show( $"{symbol1} VS {symbol2}");
        }
    }
}