public class Paquete
    {   
        public string Hotel {get; private set;}
        public string Aereo {get; private set;}
        public string Excursion {get; private set;}
        public Paquete()
        {

        }
        public Paquete(string hotel, string aereo, string excursion, string destino)
        {
            Hotel = hotel;
            Aereo = aereo;
            Excursion = excursion;
        }
    }