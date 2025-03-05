using Core_Es_3_Verifica_19_02_2025;

namespace Es_3_Verifica_19_02_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creazione magazzino
            Magazzino m = new Magazzino();

            //creazione prodotto
            Prodotto p = new Prodotto("mouse", "logitech", "001");

            //creazione campione
            Campione c = new Campione(p, "I001", true);

            //creazione campioni
            HashSet<Campione> campioni= new HashSet<Campione>();
            campioni.Add(c);

            //aggiunta campioni
            m.Campioni.Add(p, campioni);

            //metodi magazzino
            Console.WriteLine(m.NCampioniDiUnProdotto(p));

            //creazione richiesta
            Richiesta r = new Richiesta(c.NumeroInventario, campioni);
            Console.WriteLine(m.RichiediCampioniProdotti(r));

            Console.WriteLine(m.RestituisciCampione(c));
        }
    }
}
