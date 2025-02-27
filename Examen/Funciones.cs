using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface Funciones
    {
        void AgregarAlumno(Alumno alumno);
        void EliminarAlumno(string identificacion);
        List<Alumno> ListarAlumnos();

    }
}
