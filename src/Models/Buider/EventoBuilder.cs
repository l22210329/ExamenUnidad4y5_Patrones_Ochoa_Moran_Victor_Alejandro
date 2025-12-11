using System;
using EXAMEN_4_Y_5_Unidad.Models;
using EXAMEN_4_Y_5_Unidad.Models.Flyweight;

namespace EXAMEN_4_Y_5_Unidad.Models.Builder
{
    public class EventoBuilder : IEventoBuilder
    {
        private DateTime _fecha;
        private string _descripcion = "";
        private TipoEvento _tipo = null!;

        public void SetFecha(DateTime fecha) => _fecha = fecha;
        public void SetDescripcion(string descripcion) => _descripcion = descripcion;
        public void SetTipo(TipoEvento tipo) => _tipo = tipo;

        public Evento Build()
        {
            return new Evento(_fecha, _descripcion, _tipo);
        }
    }
}
