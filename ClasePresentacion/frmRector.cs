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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string añoRectorado = txtAñoRectorado.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Edad = edad;
            rector1.AñoRectorado = añoRectorado;
            MessageBox.Show("Se han registrado correctamente los datos de Rector 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            int edad = rector1.Edad;
            string añoRectorado = rector1.AñoRectorado;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Edad: " + edad + "Año Rectorado: " + añoRectorado);
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Supervisar
            MessageBox.Show(rector1.Supervisar());
        }

        private void btnApoyar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Apoyar
            MessageBox.Show(rector1.Apoyar());
        }

        private void btnOrganizarAcitividades_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Organizar Actividades
            MessageBox.Show(rector1.OrganizarActividades());
        }
    }
}
