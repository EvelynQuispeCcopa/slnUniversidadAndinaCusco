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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los datos del formulario
            string aforo = txtAforo.Text;
            string ambiente = txtAmbiente.Text;
            string docente = txtDocente.Text;
            int cantidadAlumno = int.Parse(txtCantidadAlumno.Text);
            laboratorio1.Aforo = aforo;
            laboratorio1.Ambiente = ambiente;
            laboratorio1.Docente = docente;
            laboratorio1.CantidadAlumno = cantidadAlumno;
            MessageBox.Show("Se han registrado correctamente los datos de Laboratorio 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string aforo = laboratorio1.Aforo;
            string ambiente = laboratorio1.Ambiente;
            string docente = laboratorio1.Docente;
            int cantidadAlumno = laboratorio1.CantidadAlumno;
            MessageBox.Show("Aforo: " + aforo + "Ambiente: " + ambiente + "Docente: " + docente + "CantidadAlumno: " + cantidadAlumno);
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Investigar
            MessageBox.Show(laboratorio1.Investigar());
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Analizar
            MessageBox.Show(laboratorio1.Analizar());
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Estudiar
            MessageBox.Show(laboratorio1.Estudiar());
        }
    }
}
