using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        // atributos
        private string aforo;
        private string ambiente;
        private string docente;
        private int cantidadAlumno;
        // Propiedades
        public string Aforo
        {
            get { return aforo; } //Lectura del atributo
            set { aforo = value; } //Escritura del atributo
        }
        public string Ambiente
        {
            get { return ambiente; }
            set { ambiente = value; }
        }
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public int CantidadAlumno
        {
            get { return this.cantidadAlumno; }
            set { this.cantidadAlumno = value; }
        }
        // Metodos u operaciones
        public string Investigar()
        {
            return "No se ha implementado el metodo investigar";
        }
        public string Analizar()
        {
            return "No se ha implementado el metodo analizar";
        }
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
    }
}
