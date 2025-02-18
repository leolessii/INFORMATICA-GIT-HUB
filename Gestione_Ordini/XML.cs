using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gestione_Ordini
{
    public class XML
    {
        public XML()
        {

        }

        public bool SerializzaOrdini(Azienda azienda)
        {
            string path = "ordini.xml";

            XmlDocument doc = new XmlDocument();
            XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(decl);

            XmlElement root = doc.CreateElement("GestioneOrdini");
            doc.AppendChild(root);

            XmlElement cli = doc.CreateElement("Clienti");
            root.AppendChild(cli);

            foreach(Cliente cliente in azienda.Clienti)
            {
                XmlElement c = doc.CreateElement("Cliente");

                if(azienda.Ordini[cliente] != null)
                {
                    XmlElement ordine = doc.CreateElement("Ordine")
                    doc.AppendChild(c);
                }
            }
        }
    }
}
