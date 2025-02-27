using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Gestor : Funciones
    {
        public List<Alumno> alumnos = new List<Alumno>();
        public void AgregarAlumno(Alumno alumno)
        {
            if (!ExisteAlumno(alumno.identificacion))
            {
                alumnos.Add(alumno);
            }
        }

        public void EliminarAlumno(string identificacion)
        {
            alumnos.RemoveAll(a => a.identificacion == identificacion);
        }

        public List<Alumno> ListarAlumnos()
        {
            return new List<Alumno>(alumnos);
        }

        public bool ExisteAlumno(string identificacion)
        {
            return alumnos.Any(a => a.identificacion == identificacion);
        }
    }
}
