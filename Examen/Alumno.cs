using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Alumno
    {
        public string identificacion;
        public string nombres;
        public string apellidos;
        public double nota;

        public Alumno(string identificacion, string nombres, string apellidos, double nota)
        {
            this.identificacion = identificacion;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.nota = nota;
        }

        public string ClasificacionNota()
        {
            if (nota < 5)
                return "SS";
            else if (nota < 7)
                return "AP";
            else if (nota < 9)
                return "NT";
            else
                return "SB";
        }

        public override string ToString()
        {
            return $"{identificacion} - {nombres} {apellidos} - Nota: {nota} - Calificacion: {ClasificacionNota()}";
        }
    }
}
