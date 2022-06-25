using CRUD.Model;
using CRUD.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CRUD.ViewModel
{
    public class EstudianteViewModel: EstudianteModel
    {
        public ObservableCollection<EstudianteModel> Estudiantes { get; set; }
        EstudianteServicio servicio = new EstudianteServicio();
        EstudianteModel modelo;

        public EstudianteViewModel()
        {
            Estudiantes = servicio.Consultar();
            GuardarCommand = new Command(async () => await Guardar(), () => !IsBusy);
            ModificarCommand = new Command(async () => await Modificar(), () => !IsBusy);
            EliminarCommand = new Command(async() => await Eliminar(), () => !IsBusy);
            LimpiarCommand = new Command(Limpiar, () => !IsBusy);
        }

        public Command GuardarCommand { get; set; }
        public Command ModificarCommand { get; set; }
        public Command EliminarCommand { get; set; }
        public Command LimpiarCommand { get; set; }
        public async Task Guardar()
        {
            IsBusy = true;
            Guid IdEstudiante = Guid.NewGuid();
            modelo = new EstudianteModel()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Nota = Nota,
                Id = IdEstudiante.ToString()
            };
            servicio.Guardar(modelo);
            await Task.Delay(2000);
            IsBusy = false;
        }

        public async Task Modificar()
        {
            IsBusy = true;
            modelo = new EstudianteModel()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Nota = Nota,
                Id = Id
            };
            servicio.Modificar(modelo);
            IsBusy = false;
        }

        public async Task Eliminar()
        {
            IsBusy = true;
            servicio.Eliminar(Id);
            IsBusy = false;
        }

        private void Limpiar()
        {
            Nombre = "";
            Apellido = "";
            Edad = 0;
            Nota = 0;
        }
    }
}
