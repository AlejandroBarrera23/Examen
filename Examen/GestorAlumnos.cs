using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class GestorAlumnos : Form
    {
        Gestor gestor = new Gestor();
        public GestorAlumnos()
        {
            InitializeComponent();
            btnModificarAlumno.Enabled = false;
            btnEliminarAlumno.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void agregarAlumno_Click(object sender, EventArgs e)
        {
            string id = textIdentificacion.Text.Trim();
            string nombre = textNombres.Text.Trim();
            string apellido = textApellidos.Text.Trim();
            double nota;

            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(textNota.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            // Validar que la nota sea un número válido
            if (!double.TryParse(textNota.Text, out nota))
            {
                MessageBox.Show("La nota debe ser un número válido");
                return;
            }

            // Validar que la nota esté en el rango correcto (opcional)
            if (nota < 0 || nota > 10)
            {
                MessageBox.Show("La nota debe estar entre 0 y 10, para los decimales use la coma");
                return;
            }

            // Validar si el alumno ya existe
            if (gestor.ExisteAlumno(id))
            {
                MessageBox.Show("Ya existe un alumno con esta identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear y agregar el alumno
            Alumno nuevoAlumno = new Alumno(id, nombre, apellido, nota);
            gestor.AgregarAlumno(nuevoAlumno);
            MessageBox.Show("Alumno agregado correctamente");

            // Limpiar los campos
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            textIdentificacion.Clear();
            textNombres.Clear();
            textApellidos.Clear();
            textNota.Clear();
        }


        private void btnListarAlumnos_Click(object sender, EventArgs e)
        {
            actualizarLista();
        }

        public void actualizarLista()
        {
            listaAlumnos.Items.Clear();
            foreach (var alumno in gestor.ListarAlumnos())
            {
                listaAlumnos.Items.Add(alumno.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSuspensos();
        }

        public void MostrarSuspensos()
        {
            listaAlumnos.Items.Clear();
            foreach (var alumno in gestor.ListarAlumnos())
            {
                if (alumno.nota < 7)
                {
                    listaAlumnos.Items.Add(alumno.ToString());
                }
            }
        }

        private void btnAlumnosAprobados_Click(object sender, EventArgs e)
        {
            MostrarAprobados();
        }

        public void MostrarAprobados()
        {
            listaAlumnos.Items.Clear();
            foreach (var alumno in gestor.ListarAlumnos())
            {
                if (alumno.nota >= 7)
                {
                    listaAlumnos.Items.Add(alumno.ToString());
                }
            }
        }

        private void btnAlumnosMH_Click(object sender, EventArgs e)
        {
            MostrarMH();
        }

        public void MostrarMH()
        {
            listaAlumnos.Items.Clear();
            foreach (var alumno in gestor.ListarAlumnos())
            {
                if (alumno.nota == 10)
                {
                    listaAlumnos.Items.Add(alumno.ToString());
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BuscarPorIdentificacion();
        }

        public void BuscarPorIdentificacion()
        {
            string idBuscado = txtBuscarIdentificacion.Text;

            if (string.IsNullOrWhiteSpace(idBuscado))
            {
                MessageBox.Show("Ingrese una identificación para buscar");
                return;
            }

            listaAlumnos.Items.Clear();

            bool encontrado = false;

            foreach (var alumno in gestor.ListarAlumnos())
            {
                if (alumno.identificacion == idBuscado)
                {
                    listaAlumnos.Items.Add(alumno.ToString());
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún alumno con esta identificación");
                txtBuscarIdentificacion.Clear();
            }
            
            txtBuscarIdentificacion.Clear();
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            string id = textIdentificacion.Text.Trim();
            string nombre = textNombres.Text.Trim();
            string apellido = textApellidos.Text.Trim();
            double nota;

            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(textNota.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            // Validar que la nota sea un número válido
            if (!double.TryParse(textNota.Text, out nota))
            {
                MessageBox.Show("La nota debe ser un número válido");
                return;
            }

            // Validar que la nota esté en el rango correcto
            if (nota < 0 || nota > 10)
            {
                MessageBox.Show("La nota debe estar entre 0 y 10, para decimales use la coma");
                return;
            }

            // Buscar y modificar el alumno en la lista
            foreach (var alumno in gestor.ListarAlumnos())
            {
                if (alumno.identificacion == id)
                {
                    alumno.nombres = nombre;
                    alumno.apellidos = apellido;
                    alumno.nota = nota;
                    break;
                }
            }

            MessageBox.Show("Calificacion del Alumno modificado correctamente");

            // Actualizar la lista
            actualizarLista();

            // Limpiar campos y deshabilitar botones
            limpiarCampos();
            textIdentificacion.Enabled = true;
            textNombres.Enabled = true;
            textApellidos.Enabled = true;
            agregarAlumno.Enabled = true;
            btnModificarAlumno.Enabled = false;
            btnEliminarAlumno.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un alumno para eliminar.");
                return;
            }

            string seleccion = listaAlumnos.SelectedItem.ToString();
            string idSeleccionado = seleccion.Split('-')[0].Trim(); // Extraer Identificación

            // Confirmación antes de eliminar
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este alumno?", "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                gestor.EliminarAlumno(idSeleccionado);

                MessageBox.Show("Alumno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la lista
                actualizarLista();

                // Limpiar campos y deshabilitar botones
                limpiarCampos();
                textIdentificacion.Enabled = true;
                textNombres.Enabled = true;
                textApellidos.Enabled = true;
                agregarAlumno.Enabled = true;
                btnModificarAlumno.Enabled = false;
                btnEliminarAlumno.Enabled = false;
                btnCancelar.Enabled = false;
            }

        }

        private void listaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaAlumnos.SelectedItem != null)
            {
                string seleccion = listaAlumnos.SelectedItem.ToString();
                string idSeleccionado = seleccion.Split('-')[0].Trim(); // Extraer la Identificación

                foreach (var alumno in gestor.ListarAlumnos())
                {
                    if (alumno.identificacion == idSeleccionado)
                    {
                        textIdentificacion.Text = alumno.identificacion;
                        textIdentificacion.Enabled = false;
                        textNombres.Text = alumno.nombres;
                        textNombres.Enabled = false;
                        textApellidos.Text = alumno.apellidos;
                        textApellidos.Enabled = false;
                        textNota.Text = alumno.nota.ToString();

                        // Habilitar los botone
                        agregarAlumno.Enabled = false;
                        btnModificarAlumno.Enabled = true;
                        btnEliminarAlumno.Enabled = true;
                        btnCancelar.Enabled = true;
                        break;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            textIdentificacion.Enabled=true;
            textNombres.Enabled=true;
            textApellidos.Enabled=true;
            agregarAlumno.Enabled = true;
            btnModificarAlumno.Enabled = false;
            btnEliminarAlumno.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            listaAlumnos.Items.Clear();
        }
    }
}
