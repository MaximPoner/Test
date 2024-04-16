using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
     class Zaměstnanec
    {


        public string Jméno { get; set; }
        public string Příjmení { get; set; }
        public int ID { get; set; }
        public DateTime Datum { get; set; }




        public override string ToString()
        {
            return $"{Jméno} - {Příjmení} - {ID} - ({Datum.ToShortDateString})";
        }

    }
}
