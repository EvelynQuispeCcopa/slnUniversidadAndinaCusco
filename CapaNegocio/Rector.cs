using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        // atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string añoRectorado;
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
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public string AñoRectorado
        {
            get { return this.añoRectorado; }
            set { this.añoRectorado = value; }
        }
        // Metodos u operaciones
        public string Supervisar()
        {
            return "No se ha implementado el metodo supervisar";
        }
        public string Apoyar()
        {
            return "No se ha implementado el metodo apoyar";
        }
        public string OrganizarActividades()
        {
            return "No se ha implementado el metodo organizar actividades";
        }
    }
}
