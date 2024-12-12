using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FutbolNet.Modelos
{
    public class Partido
    {
        public int Id { get; set; }

        // Relación con Equipo para local y visitante
        public int EquipoLocalId { get; set; }
        public Equipo? EquipoLocal { get; set; }

        public int EquipoVisitanteId { get; set; }
        public Equipo? EquipoVisitante { get; set; }

        public DateTime Fecha { get; set; }

    }
}
