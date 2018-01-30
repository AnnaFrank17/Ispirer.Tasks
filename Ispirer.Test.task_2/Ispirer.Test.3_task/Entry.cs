using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ispirer.Test.task_3
{
   public class Entry
    {
        public Entry() { }

        [XmlElement("firstname")]
        public string Firstname { get; set; }
        [XmlElement("surname")]
        public string Surname { get; set; }
        [XmlElement("number")]
        public string Number { get; set; }
            
    }
}
