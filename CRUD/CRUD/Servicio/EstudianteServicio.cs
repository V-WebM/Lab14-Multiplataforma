using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CRUD.Servicio
{
    public class EstudianteServicio
    {
        public ObservableCollection<EstudianteModel> estudiantes { get; set; }
    
        public EstudianteServicio()
        {
            if (estudiantes == null) 
            {
                estudiantes = new ObservableCollection<EstudianteModel>();
            }
        }

        public ObservableCollection<EstudianteModel> Consultar()
        {
            return estudiantes;
        }

        public void Guardar(EstudianteModel modelo)
        {
            estudiantes.Add(modelo);
        }

        public void Modificar(EstudianteModel modelo)
        {
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Id == modelo.Id)
                {
                    estudiantes[i] = modelo;
                }
            }
        }

        public void Eliminar(string idEstudiante)
        {
            EstudianteModel modelo = estudiantes.FirstOrDefault(p => p.Id == idEstudiante);
            estudiantes.Remove(modelo);
        }
    }
}
