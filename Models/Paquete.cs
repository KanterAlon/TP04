using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP04_Paquetes_Tur_sticos.Models
{
    public class Paquete
    {   
        public string Hotel {get; private set;}
        public string Aereo {get; private set;}
        public string Excursion {get; private set;}

        public Paquete()
        {

        }

        public Paquete(string hotel, string aereo, string excursion)
        {
            Hotel = hotel;
            Aereo = aereo;
            Excursion = excursion;
        }


    }

    
}