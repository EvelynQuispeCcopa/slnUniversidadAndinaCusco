using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        // atributos
        private string estudiante;
        private string asesor;
        private int cicloEstudios;
        private string especialidad;
        private string ambiente;
        // Propiedades
        public string Estudiante
        {
            get { return estudiante; } //Lcetura del atributo
            set { estudiante = value; } //Escritura del atributo
        }
        public string Asesor
        {
            get { return asesor; }
            set { asesor = value; }
        }
        public int CicloEstudios
        {
            get { return this.cicloEstudios; }
            set { this.cicloEstudios = value; }
        }
        public string Especialidad
        {
            get { return this.especialidad; }
            set { this.especialidad = value; }
        }
        public string Ambiente
        {
            get { return this.ambiente; }
            set { this.ambiente = value; }
        }
        // Metodos u operaciones
        public string Capacitar()
        {
            return "No se ha implementado el metodo capacitar";
        }
        public string FichaInforme()
        {
            return "No se ha implementado el metodo ficha informe";
        }
        public string Actividades()
        {
            return "No se ha implementado el metodo actividades";
        }
    }
}
