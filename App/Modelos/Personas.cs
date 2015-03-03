using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelos
{
    public class Personas
    {
       #region atributos
        private string id;
       private string nombre;
       private string direccion;
       private string telefonos;
       private string email;
        #endregion

       #region propíedades
       public string Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }   
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
         public string Nombr{
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        #endregion

       #region metodos sobreescritos
        public override string ToString()
        {
            string resul;
            resul = "ID=" + this.id + "\n" + "Nombre=" + this.nombre + "\n" + "Direccion=" + this.direccion + "\n" + "telefonos=" + this.telefonos + "\n" + "Email=" + this.email;
            return  resul;

        }
        public Personas(string id,string nombre,string direccion,string telefonos,string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefonos = telefonos;
            this.email = email;
        }

        public override bool Equals(object obj)
        {
            Personas  per= (Personas)obj;
            bool val=false;
            if (id==per.id && nombre==per.nombre && telefonos==per.telefonos && email==per.email && direccion==per.direccion )
            {
                val = true;
            }

            return val;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
//prueba asp.net

    }


}
