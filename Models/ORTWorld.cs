public class ORTWorld
    {
        public static List<string> ListaDestinos { get; private set; }
        public static List<string> ListaHoteles { get; private set; }
        public static List<string> ListaAereos { get; private set; }
        public static List<string> ListaExcursiones { get; private set; }
        public static Dictionary<string, Paquete    > Paquetes { get; private set; }

        public ORTWorld()
        {
            ListaDestinos = new List<string>
            {
                "Paris",
                "New York",
                "Tokyo",
                "London",
                "Rome",
                "Sydney",
                "Cape Town",
                "Barcelona",
                "Dubai",
                "Rio de Janeiro"
            };

            ListaHoteles = new List<string>
            {
                "hotel1.jpg",
                "hotel2.jpg",
                "hotel3.jpg",
                "hotel4.jpg",
                "hotel5.jpg",
                "hotel6.jpg",
                "hotel7.jpg",
                "hotel8.jpg",
                "hotel9.jpg",
                "hotel10.jpg"
            };

            ListaAereos = new List<string>
            {
                "aereo1.jpg",
                "aereo2.jpg",
                "aereo3.jpg",
                "aereo4.jpg",
                "aereo5.jpg",
                "aereo6.jpg",
                "aereo7.jpg",
                "aereo8.jpg",
                "aereo9.jpg",
                "aereo10.jpg"
            };

            ListaExcursiones = new List<string>
            {
                "excursion1.jpg",
                "excursion2.jpg",
                "excursion3.jpg",
                "excursion4.jpg",
                "excursion5.jpg",
                "excursion6.jpg",
                "excursion7.jpg",
                "excursion8.jpg",
                "excursion9.jpg",
                "excursion10.jpg"
            };

            Paquetes = new Dictionary<string, Paquete>();
        }

        public ORTWorld(List<string> listaDestinos, List<string> listaHoteles, List<string> listaAereos, List<string> listaExcursiones, Dictionary<string, Paquete> paquetes)
        {
            ListaDestinos = listaDestinos;
            ListaHoteles = listaHoteles;
            ListaAereos = listaAereos;
            ListaExcursiones = listaExcursiones;
            Paquetes = paquetes;
        }

        public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
        {
            if (Paquetes.ContainsKey(destinoSeleccionado))
            {
                return false;
            }
            else
            {
                Paquetes.Add(destinoSeleccionado, paquete);
                return true;
            }
        }
    }