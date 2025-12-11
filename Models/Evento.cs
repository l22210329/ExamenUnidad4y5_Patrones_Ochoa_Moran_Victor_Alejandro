using EXAMEN_4_Y_5_Unidad.Models.Flyweight;

namespace EXAMEN_4_Y_5_Unidad.Models
{
    public class Evento
    {
        public DateTime Fecha { get; }
        public string Descripcion { get; }
        public TipoEvento Tipo { get; }

        public Evento(DateTime fecha, string descripcion, TipoEvento tipo)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Tipo = tipo;
        }
    }
}
