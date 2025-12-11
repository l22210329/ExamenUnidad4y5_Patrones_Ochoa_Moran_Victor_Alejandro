using System.Collections.Generic;
using EXAMEN_4_Y_5_Unidad.Models.Builder;
using EXAMEN_4_Y_5_Unidad.Models.Flyweight;
using EXAMEN_4_Y_5_Unidad.Models.Memento;

namespace EXAMEN_4_Y_5_Unidad.Models
{
    public class Agenda
    {
        public List<Evento> Eventos { get; private set; } = new List<Evento>();

        private AgendaCaretaker caretaker = new AgendaCaretaker();

        public void AgregarEvento(DateTime fecha, string descripcion, string tipo)
        {
            caretaker.Guardar(CrearMemento());

            var builder = new EventoBuilder();
            builder.SetFecha(fecha);
            builder.SetDescripcion(descripcion);

            var tipoFlyweight = FabricaTiposEvento.ObtenerTipo(tipo);
            builder.SetTipo(tipoFlyweight);

            Eventos.Add(builder.Build());
        }

        public AgendaMemento CrearMemento()
        {
            return new AgendaMemento(Eventos);
        }

        public void RestaurarUltimoEstado()
        {
            var memento = caretaker.Restaurar();
            if (memento != null)
            {
                Eventos = new List<Evento>(memento.EstadoEventos);
            }
        }
    }
}
