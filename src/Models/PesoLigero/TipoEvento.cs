namespace EXAMEN_4_Y_5_Unidad.Models.Flyweight
{
    public class TipoEvento
    {
        public string Nombre { get; }
        public string Color { get; }

        public TipoEvento(string nombre, string color)
        {
            Nombre = nombre;
            Color = color;
        }
    }
}
