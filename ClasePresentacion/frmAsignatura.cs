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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los datos del formulario
            string estudiante = txtEstudiante.Text;
            string docente = txtDocente.Text;
            string aula = txtAula.Text;
            string metodoEducativo = txtMetodoEducativo.Text;
            DateTime horario = dtHorario.Value;
            asignatura1.Estudiante = estudiante;
            asignatura1.Docente = docente;
            asignatura1.Aula = aula;
            asignatura1.MetodoEducativo = metodoEducativo;
            asignatura1.Horario = horario;
            MessageBox.Show("Se han registrado correctamente los datos de Asignatura 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string estudiante = asignatura1.Estudiante;
            string docente = asignatura1.Docente;
            string aula = asignatura1.Aula;
            string metodoEducativo = asignatura1.MetodoEducativo;
            DateTime horario = asignatura1.Horario;
            MessageBox.Show("Estudiante: " + estudiante + "Docente: " + docente + "Aula: " +  aula + "Metodo Educativo: " + metodoEducativo + "Horario: " + horario);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Enseñar());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Aprender());
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Estudiar());
        }
    }
}
