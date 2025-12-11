using System.Collections.Generic;

namespace EXAMEN_4_Y_5_Unidad.Models.Flyweight
{
    public static class FabricaTiposEvento
    {
        private static Dictionary<string, TipoEvento> tipos = new Dictionary<string, TipoEvento>();

        public static TipoEvento ObtenerTipo(string nombre)
        {
            if (!tipos.ContainsKey(nombre))
            {
                tipos[nombre] = CrearTipo(nombre);
            }

            return tipos[nombre];
        }

        private static TipoEvento CrearTipo(string nombre)
        {
            return nombre switch
            {
                "Reunión"      => new TipoEvento("Reunión", ""),
                "Pago"         => new TipoEvento("Pago", ""),
                "Cita"         => new TipoEvento("Cita", ""),
                "Recordatorio" => new TipoEvento("Recordatorio", ""),
                _              => new TipoEvento("General", ""),
            };
        }
    }
}
