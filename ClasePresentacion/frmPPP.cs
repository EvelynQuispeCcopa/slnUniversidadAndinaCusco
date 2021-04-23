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
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.PPP PPP1 = new CapaNegocio.PPP();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los datos del formulario
            string estudiante = txtEstudiante.Text;
            string asesor = txtAsesor.Text;
            int cicloEstudios = int.Parse(txtCicloEstudios.Text);
            string especialidad = txtEspecialidad.Text;
            string ambiente = txtAmbiente.Text;
            PPP1.Estudiante = estudiante;
            PPP1.Asesor = asesor;
            PPP1.CicloEstudios = cicloEstudios;
            PPP1.Especialidad = especialidad;
            PPP1.Ambiente = ambiente;
            MessageBox.Show("Se han registrado correctamente los datos de PPP 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string estudiante = PPP1.Estudiante;
            string asesor = PPP1.Asesor;
            int cicloEstudios = PPP1.CicloEstudios;
            string especialidad = PPP1.Especialidad;
            string ambiente = PPP1.Ambiente;
            MessageBox.Show("Estudiante: " + estudiante + "Asesor: " + asesor + "Ciclo Estudios: " + cicloEstudios + "Especialidad: " + especialidad + "Ambiente: " + ambiente);
        }

        private void btnCapacitar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Capacitar
            MessageBox.Show(PPP1.Capacitar());
        }

        private void btnFichaInforme_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Ficha Informe
            MessageBox.Show(PPP1.FichaInforme());
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Actividades
            MessageBox.Show(PPP1.Actividades());
        }
    }
}
