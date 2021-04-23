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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.JefePractica jefePractica1 = new CapaNegocio.JefePractica();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los datos del formulario
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            int dni = int.Parse(txtDni.Text);
            string gradoAcademico = txtGradoAcademico.Text;
            string especialidad = txtEspecialidad.Text;
            jefePractica1.Nombres = nombres;
            jefePractica1.Edad = edad;
            jefePractica1.Dni = dni;
            jefePractica1.GradoAcademico = gradoAcademico;
            jefePractica1.Especialidad = especialidad;
            MessageBox.Show("Se han registrado correctamente los datos de Jefe Practica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string nombres = jefePractica1.Nombres;
            int edad = jefePractica1.Edad;
            int dni = jefePractica1.Dni;
            string gradoAcademico = jefePractica1.GradoAcademico;
            string especialidad = jefePractica1.Especialidad;
            MessageBox.Show("Nombres: " + nombres + "Edad: " + edad + "Dni: " + dni + "GradoAcademico: " + gradoAcademico + "Especialidad: " + especialidad);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Enseñar
            MessageBox.Show(jefePractica1.Enseñar());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Evaluar
            MessageBox.Show(jefePractica1.Evaluar());
        }

        private void btnAyudar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Ayudar
            MessageBox.Show(jefePractica1.Ayudar());
        }
    }
}
