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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string codigo = txtCodigo.Text;
            string materia = txtMateria.Text;
            string escuelaProfesional = txtEscuelaProfesional.Text;
            notas1.Apellidos = apellidos;
            notas1.Nombres = nombres;
            notas1.Codigo = codigo;
            notas1.Materia = materia;
            notas1.EscuelaProfesional = escuelaProfesional;
            MessageBox.Show("Se han registrado correctamente los datos de Notas 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string apellidos = notas1.Apellidos;
            string nombres = notas1.Nombres;
            string codigo = notas1.Codigo;
            string materia = notas1.Materia;
            string escuelaProfesional = notas1.EscuelaProfesional;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Codigo: " + codigo + "Materia: " + materia + "Escuela Profesional: " + escuelaProfesional);
        }

        private void btnEvaluación_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Evaluacion
            MessageBox.Show(notas1.Evaluacion());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Reportes
            MessageBox.Show(notas1.Reportes());
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Analisis
            MessageBox.Show(notas1.Analisis());
        }
    }
}
