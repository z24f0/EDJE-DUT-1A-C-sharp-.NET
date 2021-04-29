using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    class Jeux
    {
        public string Nom { get; set; }
        public string Date { get; set; }

        public string ImageName { get; set; }

        public override string ToString()
        {
            return $" {Nom} - {Date} ";
        }
    }
}
