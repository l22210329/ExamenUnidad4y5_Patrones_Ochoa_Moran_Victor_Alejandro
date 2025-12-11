using System;
using EXAMEN_4_Y_5_Unidad.Models;
using EXAMEN_4_Y_5_Unidad.Models.Flyweight;

namespace EXAMEN_4_Y_5_Unidad.Models.Builder
{
    public interface IEventoBuilder
    {
        void SetFecha(DateTime fecha);
        void SetDescripcion(string descripcion);
        void SetTipo(TipoEvento tipo);
        Evento Build();
    }
}
