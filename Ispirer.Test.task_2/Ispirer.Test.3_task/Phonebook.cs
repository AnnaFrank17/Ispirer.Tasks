using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Ispirer.Test.task_3
{

    [XmlRoot("phonebook")]
    [Serializable()]
    public class Phonebook
    {
        public Phonebook() { }
        [XmlElement("entry")]
        public List<Entry> Dbase { get; set; }
        public static Phonebook Serializ()
        {
            Phonebook phonebook;
            XmlSerializer xmlserial = new XmlSerializer(typeof(Phonebook));

            using (FileStream fs = new FileStream("phone_book.xml", FileMode.Open))
            {
                phonebook = xmlserial.Deserialize(fs) as Phonebook;

            }
            return phonebook;
        }

        public Entry Search_surname(string surname)
        {

            return Dbase.FirstOrDefault(i => i.Surname.ToLower() == surname.ToLower());
        }

    }
}
