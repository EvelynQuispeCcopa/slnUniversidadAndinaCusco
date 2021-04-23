using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        // atributos
        private string apellidos;
        private string nombres;
        private string codigo;
        private string materia;
        private string escuelaProfesional;
        // Propiedades
        public string Apellidos
        {
            get { return apellidos; } //Lcetura del atributo
            set { apellidos = value; } //Escritura del atributo
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public string Materia
        {
            get { return this.materia; }
            set { this.materia = value; }
        }
        public string EscuelaProfesional
        {
            get { return this.escuelaProfesional; }
            set { this.escuelaProfesional = value; }
        }
        // Metodos u operaciones
        public string Evaluacion()
        {
            return "No se ha implementado el metodo evaluacion";
        }
        public string Reportes()
        {
            return "No se ha implementado el metodo reportes";
        }
        public string Analisis()
        {
            return "No se ha implementado el metodo aprobar analisis";
        }
    }
}
