using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CRUD.Model
{
    public class EstudianteModel: System.ComponentModel.INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy=false; }
            set { isBusy=value;
                OnPropertyChanged();
            }
        }

        private string id;


        public string Id 
        { 
            get { return id; }
            set { 
                id = value;
                OnPropertyChanged();
            }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { 
                nombre = value;
                OnPropertyChanged();
            }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { 
                apellido = value;
                OnPropertyChanged();
            }
        }

        private int edad;

        public int Edad 
        {
            get { return edad;  }
            set { edad = value;
                OnPropertyChanged();
            }
        }

        private int nota;

        public int Nota
        {
            get { return nota; }
            set { nota = value;
                OnPropertyChanged();
            }
        }

        private String mensaje;

        public String Mensaje 
        {
            get { return $"El nombre del estudiante es: {Nombre}";  }
   
        }
    }
}
