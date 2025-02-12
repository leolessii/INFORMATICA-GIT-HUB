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
        public XmlSerializer serializer;

        public XML()
        {
            serializer = new XmlSerializer(typeof(XML));
        }

        public bool SerializzaLibri(Libreria libreria)
        {
            string path = "libri.xml";

            XmlDocument doc = new XmlDocument();
            XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(decl);

            XmlElement root = doc.CreateElement("Libreria");
            root.SetAttribute("nome", libreria.Nome);
            doc.AppendChild(root);

            foreach(Libro libro in libreria.Libri)
            {
                XmlElement Libro = doc.CreateElement("Libro");
                Libro.SetAttribute("ISBN", libro.ISBN);
                root.AppendChild(Libro);

                XmlElement Titolo = doc.CreateElement("Titolo");
            }
        }
    }
}
