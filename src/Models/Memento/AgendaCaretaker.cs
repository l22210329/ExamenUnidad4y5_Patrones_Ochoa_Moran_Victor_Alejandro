using System.Collections.Generic;

namespace EXAMEN_4_Y_5_Unidad.Models.Memento
{
    public class AgendaCaretaker
    {
        private readonly Stack<AgendaMemento> _historial = new Stack<AgendaMemento>();

        public void Guardar(AgendaMemento m) => _historial.Push(m);

        public AgendaMemento? Restaurar()
        {
            return _historial.Count > 0 ? _historial.Pop() : null;
        }
    }
}
