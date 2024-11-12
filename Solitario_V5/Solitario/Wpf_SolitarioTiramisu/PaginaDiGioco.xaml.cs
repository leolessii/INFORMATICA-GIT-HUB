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
    /// Logica di interazione per PaginaDiGioco.xaml
    /// </summary>
    public partial class PaginaDiGioco : Window
    {
        public Partita partita;
        public bool selezione;
        public bool mano;
        public bool destinazione;
        public Carta cartaSelezionata;
        public int tavolo;
        public int indice;
        public bool provenienza;

        public PaginaDiGioco(string nome)
        {
            InitializeComponent();

            partita = new Partita(nome);
            selezione = true;

            // provenienza = true -> mano, provenienza = false -> tavolo
            provenienza = false;
            destinazione = true;
            cartaSelezionata = new Carta(Seme.D, Valore.tre); 
            tavolo = 0;
            indice = 0;
        }

        private void AggiornaImmagini()
        {
            if(partita.Mano[0].CartaInCima != null)
            {
                string sm1 = partita.Mano[0].CartaInCima.Fronte;
                var urim1 = new Uri(sm1, UriKind.Relative);
                Image imagem1 = new Image();
                imagem1.Source = new BitmapImage(urim1);
                btnMano1.Background = new ImageBrush(imagem1.Source);
            }
            else
            {
                btnMano1.Background.Opacity = 0;
            }
            
            if(partita.Mano[1].CartaInCima != null)
            {
                string sm2 = partita.Mano[1].CartaInCima.Fronte;
                var urim2 = new Uri(sm2, UriKind.Relative);
                Image imagem2 = new Image();
                imagem2.Source = new BitmapImage(urim2);
                btnMano2.Background = new ImageBrush(imagem2.Source);
            }
            else
            {
                btnMano2.Background.Opacity = 0; 
            }

            if (partita.Mano[2].CartaInCima != null)
            {
                string sm3 = partita.Mano[2].CartaInCima.Fronte;
                var urim3 = new Uri(sm3, UriKind.Relative);
                Image imagem3 = new Image();
                imagem3.Source = new BitmapImage(urim3);
                btnMano3.Background = new ImageBrush(imagem3.Source);
            }
            else
            {
                btnMano3.Background.Opacity = 0;
            }

            if (partita.Mano[3].CartaInCima != null)
            {
                string sm4 = partita.Mano[3].CartaInCima.Fronte;
                var urim4 = new Uri(sm4, UriKind.Relative);
                Image imagem4 = new Image();
                imagem4.Source = new BitmapImage(urim4);
                btnMano4.Background = new ImageBrush(imagem4.Source);
            }
            else
            {
                btnMano4.Background.Opacity = 0;
            }

            if (tavolo>0)
            {
                if(partita.Tavolo[0].CartaInCima !=null)
                {
                    string st1 = partita.Tavolo[0].CartaInCima.Fronte;
                    var urit1 = new Uri(st1, UriKind.Relative);
                    Image imaget1 = new Image();
                    imaget1.Source = new BitmapImage(urit1);
                    btnTavolo1.Background = new ImageBrush(imaget1.Source);
                }
                else
                {
                    btnTavolo1.Background.Opacity = 0;
                }

                if (partita.Tavolo[1].CartaInCima != null)
                {
                    string st2 = partita.Tavolo[1].CartaInCima.Fronte;
                    var urit2 = new Uri(st2, UriKind.Relative);
                    Image imaget2 = new Image();
                    imaget2.Source = new BitmapImage(urit2);
                    btnTavolo2.Background = new ImageBrush(imaget2.Source);
                }
                else
                {
                    btnTavolo2.Background.Opacity = 0;
                }

                if (partita.Tavolo[2].CartaInCima != null)
                {
                    string st3 = partita.Tavolo[2].CartaInCima.Fronte;
                    var urit3 = new Uri(st3, UriKind.Relative);
                    Image imaget3 = new Image();
                    imaget3.Source = new BitmapImage(urit3);
                    btnTavolo3.Background = new ImageBrush(imaget3.Source);
                }
                else
                {
                    btnTavolo3.Background.Opacity = 0;
                }

                if (partita.Tavolo[3].CartaInCima != null)
                {
                    string st4 = partita.Tavolo[3].CartaInCima.Fronte;
                    var urit4 = new Uri(st4, UriKind.Relative);
                    Image imaget4 = new Image();
                    imaget4.Source = new BitmapImage(urit4);
                    btnTavolo4.Background = new ImageBrush(imaget4.Source);
                }
                else
                {
                    btnTavolo4.Background.Opacity = 0;
                }
            } 
        }

        public void TerminaPartita()
        {
            if(partita.TerminaPartita() == true)
            {
                PaginaFinale fine = new PaginaFinale(partita);
                this.Close();
                fine.Show();
            }
        }

        private void btnMazzo_Click(object sender, RoutedEventArgs e)
        {
            cartaSelezionata = null;
            partita.PescaDalMazzo();

            AggiornaImmagini();
        }

        private void btnMano1_Click(object sender, RoutedEventArgs e)
        {
            if(selezione== true)
            {
                //se provenienza = true allora viene dalla mano
                provenienza = true;
                //prendila
                cartaSelezionata = partita.Mano[0].CartaInCima;
                //numnero della mano da cui arriva la carta
                indice = 0;
            }
            else if(selezione== false)
            {
                //mettila
                destinazione = true;
                //se va bene allora rimuovila se no non lo fare
                if(partita.SpostaCarta(destinazione, cartaSelezionata, 0)==true)
                {
                    if(provenienza == true)
                    {
                        partita.Mano[indice].RimuoviCarta();
                    }
                    else if(provenienza==false)
                    {
                        partita.Tavolo[indice].RimuoviCarta();
                    }
                }
                else
                {
                    MessageBox.Show("non puoi spostare questa carta");
                }
            }
            selezione = !selezione;
            AggiornaImmagini();
            TerminaPartita();
        }

        private void btnMano2_Click(object sender, RoutedEventArgs e)
        {
            if (selezione == true)
            {
                provenienza= true;
                //prendila
                cartaSelezionata = partita.Mano[1].CartaInCima;
                //
                indice = 1;
            }
            else if (selezione == false)
            {
                //mettila
                destinazione= true;
                //se va bene allora rimuovila se no non lo fare
                if(partita.SpostaCarta(destinazione, cartaSelezionata, 1)==true)
                {
                    if (provenienza == true)
                    {
                        partita.Mano[indice].RimuoviCarta();
                    }
                    else if (provenienza == false)
                    {
                        partita.Tavolo[indice].RimuoviCarta();
                    }
                }
                else
                {
                    MessageBox.Show("non puoi spostare questa carta");
                }
            }
            selezione = !selezione;
            AggiornaImmagini();
            TerminaPartita();
        }

        private void btnMano3_Click(object sender, RoutedEventArgs e)
        {
            if (selezione == true)
            {
                provenienza = true;
                //prendila
                cartaSelezionata = partita.Mano[2].CartaInCima;
                indice = 2;
            }
            else if (selezione == false)
            {
                //mettila
                destinazione = true;
                //se va bene allora rimuovila se no non lo fare
                if(partita.SpostaCarta(destinazione, cartaSelezionata, 2)==true)
                {
                    if (provenienza == true)
                    {
                        partita.Mano[indice].RimuoviCarta();
                    }
                    else if (provenienza == false)
                    {
                        partita.Tavolo[indice].RimuoviCarta();
                    }
                }
                else
                {
                    MessageBox.Show("non puoi spostare questa carta");
                }
            }
            selezione = !selezione;
            AggiornaImmagini();
            TerminaPartita();
        }

        private void btnMano4_Click(object sender, RoutedEventArgs e)
        {
            if (selezione == true)
            {
                provenienza=true;
                //prendila
                cartaSelezionata = partita.Mano[3].CartaInCima;
                indice = 3;
            }
            else if (selezione == false)
            {
                //mettila
                destinazione = true;
                //se va bene allora rimuovila se no non lo fare
                if(partita.SpostaCarta(destinazione, cartaSelezionata, 3)==true)
                {
                    if (provenienza == true)
                    {
                        partita.Mano[indice].RimuoviCarta();
                    }
                    else if (provenienza == false)
                    {
                        partita.Tavolo[indice].RimuoviCarta();
                    }
                }
                else
                {
                    MessageBox.Show("non puoi spostare questa carta");
                }
            }
            selezione = !selezione;
            AggiornaImmagini();
            TerminaPartita();
        }


        private void btnTavolo1_Click(object sender, RoutedEventArgs e)
        {
            tavolo = 1;
            if (selezione == true)
            {
                provenienza = false;
                //prendila
                cartaSelezionata = partita.Tavolo[0].CartaInCima;
                indice = 0;
            }
            else if (selezione == false)
            {
                //mettila
                destinazione = false;
                //se va bene allora rimuovila se no non lo fare
                if(partita.SpostaCarta(destinazione, cartaSelezionata, 0)==true)
                {
                    if (provenienza == true)
                    {
                        partita.Mano[indice].RimuoviCarta();
                    }
                    else 
                    {
                        partita.Tavolo[indice].RimuoviCarta();
                    }
                }
                else
                {
                    MessageBox.Show("non puoi spostare questa carta");
                }
            }
            selezione = !selezione;
            AggiornaImmagini();
            TerminaPartita();
        }

        private void btnTavolo2_Click(object sender, RoutedEventArgs e)
        {
            tavolo = 1;
            if (selezione == true)
            {
                provenienza = false;
                //prendila
                cartaSelezionata = partita.Tavolo[1].CartaInCima;
                indice = 1;
            }
            else if (selezione == false)
            {
                //mettila
                destinazione = false;
                //se va bene allora rimuovila se no non lo fare
                if(partita.SpostaCarta(destinazione, cartaSelezionata, 1)==true)
                {
                    if (provenienza == true)
                    {
                        partita.Mano[indice].RimuoviCarta();
                    }
                    else if (provenienza == false)
                    {
                        partita.Tavolo[indice].RimuoviCarta();
                    }
                }
                else
                {
                    MessageBox.Show("non puoi spostare questa carta");
                }
            }
            selezione = !selezione;
            AggiornaImmagini();
            TerminaPartita();
        }

        private void btnTavolo3_Click(object sender, RoutedEventArgs e)
        {
            tavolo = 1;
            if (selezione == true)
            {
                provenienza = false;
                //prendila
                cartaSelezionata =  partita.Tavolo[2].CartaInCima;
                indice = 2;
            }
            else if (selezione == false)
            {
                //mettila
                destinazione = false;
                //se va bene allora rimuovila se no non lo fare
                if(partita.SpostaCarta(destinazione, cartaSelezionata, 2)==true)
                {
                    if (provenienza == true)
                    {
                        partita.Mano[indice].RimuoviCarta();
                    }
                    else if (provenienza == false)
                    {
                        partita.Tavolo[indice].RimuoviCarta();
                    }
                }
                else
                {
                    MessageBox.Show("non puoi spostare questa carta");
                }
            }
            selezione = !selezione;
            AggiornaImmagini();
            TerminaPartita();
        }

        private void btnTavolo4_Click(object sender, RoutedEventArgs e)
        {
            tavolo = 1;
            if (selezione == true)
            {
                provenienza=false;
                //prendila
                cartaSelezionata = partita.Tavolo[3].CartaInCima;
                indice = 3;
            }
            else if (selezione == false)
            {
                //mettila
                destinazione = false;
                //se va bene allora rimuovila se no non lo fare
                if(partita.SpostaCarta(destinazione, cartaSelezionata, 3)==true)
                {
                    if (provenienza == true)
                    {
                        partita.Mano[indice].RimuoviCarta();
                    }
                    else if (provenienza == false)
                    {
                        partita.Tavolo[indice].RimuoviCarta();
                    }
                }
                else
                {
                    MessageBox.Show("non puoi spostare questa carta");
                }
            }
            selezione = !selezione;
            AggiornaImmagini();
            TerminaPartita();
        }
    }
}
