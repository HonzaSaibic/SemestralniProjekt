using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestralka
{
    public class Jidlo
    {
        public string jmeno { get; set; }
        public int proteiny { get; set; }
        public int sacharidy { get; set; }
        public int tuky { get; set; }

        public Jidlo (string jmeno, int proteiny, int sacharidy, int tuky)
        {
            this.jmeno = jmeno;
            this.proteiny = proteiny;
            this.sacharidy = sacharidy;
            this.tuky = tuky;
        }
    }
}
