using System.Collections.Generic;
using EXAMEN_4_Y_5_Unidad.Models;

namespace EXAMEN_4_Y_5_Unidad.Models.Memento
{
    public class AgendaMemento
    {
        public List<Evento> EstadoEventos { get; }

        public AgendaMemento(List<Evento> estado)
        {
            EstadoEventos = new List<Evento>(estado);
        }
    }
}
