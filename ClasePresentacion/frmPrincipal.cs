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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del alumno
            frmAlumno formulario = new frmAlumno();
            formulario.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del docente
            frmDocente formulario = new frmDocente();
            formulario.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del laboratorio
            frmLaboratorio formulario = new frmLaboratorio();
            formulario.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del asignatura
            frmAsignatura formulario = new frmAsignatura();
            formulario.Show();
        }

        private void jefePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del jefe practica
            frmJefePractica formulario = new frmJefePractica();
            formulario.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario de notas
            frmNotas formulario = new frmNotas();
            formulario.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario de rector
            frmRector formulario = new frmRector();
            formulario.Show();
        }

        private void pPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario de PPP(practicas pre profesionales)
            frmPPP formulario = new frmPPP();
            formulario.Show();
        }
    }
}
