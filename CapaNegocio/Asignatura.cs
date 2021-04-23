using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        // atributos
        private string estudiante;
        private string docente;
        private string aula;
        private string metodoEducativo;
        private DateTime horario;
        // Propiedades
        public string Estudiante
        {
            get { return estudiante; } //Lectura del atributo
            set { estudiante = value; } //Escritura del atributo
        }
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public string Aula
        {
            get { return this.aula; }
            set { this.aula = value; }
        }
        public string MetodoEducativo
        {
            get { return this.metodoEducativo; }
            set { this.metodoEducativo = value; }
        }
        public DateTime Horario
        {
            get { return this.horario; }
            set { this.horario = value; }
        }
        // Metodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Aprender()
        {
            return "No se ha implementado el metodo aprender";
        }
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
    }
}
