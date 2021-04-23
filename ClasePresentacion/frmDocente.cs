using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasePresentacion
{
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int dni = int.Parse(txtDni.Text);
            DateTime fechaNacimiento = dtFechaNacimiento.Value;
            string profesion = txtProfesion.Text;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.Dni = dni;
            docente1.FechaNacimiento = fechaNacimiento;
            docente1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos de Docente 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            int dni = docente1.Dni;
            DateTime fechaNacimiento = docente1.FechaNacimiento;
            string profesion = docente1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Dni: " + dni + "FechaNacimiento: " + fechaNacimiento + "Profesion: " + profesion);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Enseñar());
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Matricular());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Desaprobar());
        }
    }
}
