using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CoreLibreria
{
    public class XML
    {

        public void SerializzaLibri(Libreria libreria)
        {
            string path = "libri.xml";

            StreamWriter sw = new StreamWriter(path);
            XmlSerializer libri = new XmlSerializer(typeof(Libreria));
            libri.Serialize(sw, libreria.Libri);
        }

        public void SerializzaUtenti(Libreria libreria)
        {
            string path = "utenti.xml";

            StreamWriter sw = new StreamWriter(path);
            XmlSerializer utenti = new XmlSerializer(typeof(Libreria));
            utenti.Serialize(sw, libreria.Utenti);
        }

        public void SerializzaPrestitiAttivi(Libreria libreria)
        {
            string path = "prestitiAttivi.xml";

            StreamWriter sw = new StreamWriter(path);
            XmlSerializer prestitiAttivi = new XmlSerializer(typeof(Libreria));
            prestitiAttivi.Serialize(sw, libreria.PrestitiAttivi);
        }

        public void SerializzaPrestitiInAttesa(Libreria libreria)
        {
            string path = "prestitiInAttesa.xml";

            StreamWriter sw = new StreamWriter(path);
            XmlSerializer prestitiInAttesa = new XmlSerializer(typeof(Libreria));
            prestitiInAttesa.Serialize(sw, libreria.PrestitiInAttesa);
        }

        public void DeserializzaLibri(Libreria libreria)
        {
            string path = "libri.xml";

            StreamReader sr = new StreamReader(path);
            XmlSerializer libri = new XmlSerializer(typeof(Libreria));
            libreria.Libri = libri.Deserialize(sr) as HashSet<Libro>;
        }

        public void DeserializzaUtenti(Libreria libreria)
        {
            string path = "utenti.xml";

            StreamReader sr = new StreamReader(path);
            XmlSerializer utenti = new XmlSerializer(typeof(Libreria));
            libreria.Utenti = utenti.Deserialize(sr) as HashSet<Utente>;
        }

        public void DeserializzaPrestitiAttivi(Libreria libreria)
        {
            string path = "prestitiAttivi.xml";

            StreamReader sr = new StreamReader(path);
            XmlSerializer prestitiAttivi = new XmlSerializer(typeof(Libreria));
            libreria.PrestitiAttivi = prestitiAttivi.Deserialize(sr) as Dictionary<Libro, Prestito>;
        }

        public void DeserializzaPrestitiInAttesa(Libreria libreria)
        {
            string path = "prestitiInAttesa.xml";

            StreamReader sr = new StreamReader(path);
            XmlSerializer prestitiInAttesa = new XmlSerializer(typeof(Libreria));
            libreria.PrestitiInAttesa = prestitiInAttesa.Deserialize(sr) as Queue<Prestito>;
        }
    }
}
