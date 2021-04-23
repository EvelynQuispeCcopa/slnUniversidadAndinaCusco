using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        // atributos
        private string nombres;
        private int edad;
        private int dni;
        private string gradoAcademico;
        private string especialidad;
        // Propiedades
        public string Nombres
        {
            get { return nombres; } //Lectura del atributo
            set { nombres = value; } //Escritura del atributo
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string GradoAcademico
        {
            get { return this.gradoAcademico; }
            set { this.gradoAcademico = value; }
        }
        public string Especialidad
        {
            get { return this.especialidad; }
            set { this.especialidad = value; }
        }
        // Metodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Evaluar()
        {
            return "No se ha implementado el metodo evaluar";
        }
        public string Ayudar()
        {
            return "No se ha implementado el metodo ayudar";
        }
    }
}
