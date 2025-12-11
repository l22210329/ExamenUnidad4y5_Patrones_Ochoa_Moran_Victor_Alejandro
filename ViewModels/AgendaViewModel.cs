using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EXAMEN_4_Y_5_Unidad.Models;
using System.Windows.Input;
using Microsoft.Maui.Controls;  

namespace EXAMEN_4_Y_5_Unidad.ViewModels
{
    public class AgendaViewModel : INotifyPropertyChanged
    {
        private Agenda agenda = new Agenda();


        public ObservableCollection<Evento> Eventos { get; set; }
            = new ObservableCollection<Evento>();


        public ObservableCollection<string> TiposDisponibles { get; set; }
            = new ObservableCollection<string>
            {
                "Reunión",
                "Pago",
                "Cita",
                "Recordatorio"
            };


        private DateTime _fecha = DateTime.Now;
        public DateTime Fecha
        {
            get => _fecha;
            set { _fecha = value; OnPropertyChanged(); }
        }

        private string _descripcion = "";
        public string Descripcion
        {
            get => _descripcion;
            set { _descripcion = value; OnPropertyChanged(); }
        }

        private string _tipo = "";
        public string Tipo
        {
            get => _tipo;
            set { _tipo = value; OnPropertyChanged(); }
        }


        public ICommand AgregarEventoCommand { get; }
        public ICommand RestaurarCommand { get; }


        public AgendaViewModel()
        {
            AgregarEventoCommand = new Command(AgregarEvento);
            RestaurarCommand = new Command(Restaurar);
        }



        private void LimpiarCampos()
        {
            Fecha = DateTime.Now;
            Descripcion = "";
            Tipo = "";
        }
        
        public void AgregarEvento()
        {
            agenda.AgregarEvento(Fecha, Descripcion, Tipo);

            Eventos.Clear();
            foreach (var e in agenda.Eventos)
                Eventos.Add(e);

            LimpiarCampos();
        }


        public void Restaurar()
        {
            agenda.RestaurarUltimoEstado();

            Eventos.Clear();
            foreach (var e in agenda.Eventos)
                Eventos.Add(e);
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
