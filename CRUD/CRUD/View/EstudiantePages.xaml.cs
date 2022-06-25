using CRUD.Model;
using CRUD.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRUD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstudiantePages : ContentPage
    {
        EstudianteViewModel contexto = new EstudianteViewModel();
        public EstudiantePages()
        {
            InitializeComponent();
            BindingContext = contexto;
            LvEstudiantes.ItemSelected += LvEstudiantes_ItemSelected;
        }

        private void LvEstudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                EstudianteModel modelo = (EstudianteModel)e.SelectedItem;
                contexto.Nombre = modelo.Nombre;
                contexto.Apellido = modelo.Apellido;
                contexto.Edad = modelo.Edad;
                contexto.Nota = modelo.Nota;
            }
        }
    }
}