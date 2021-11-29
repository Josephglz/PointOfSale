using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Empleado
    {
        private int idEmpleado;
        private string nombre;
        private string apellido;
        private int rol;
        private string usuario;
        private string password;
        private string ultConexion;
        private string image;
        public Empleado() { }
        public Empleado(int idEmpleado, string nombre, string apellido, int rol, string usuario, string password, string ultConexion, string image)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.rol = rol;
            this.usuario = usuario;
            this.password = password;
            this.ultConexion = ultConexion;
            this.image = image;
        }
        /*==========    [   GETTERS   ]     ==========*/
        public int getIdempleado()
        {
            return this.idEmpleado;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public int getRol()
        {
            return this.rol;
        }
        public string getRolName()
        {
            if(getRol() == 2)
            {
                return "Vendedor";
            }
            return "Administrador";
        }
        public string getUsuario()
        {
            return this.usuario;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getUltConexion()
        {
            return this.ultConexion;
        }
        public string getImage()
        {
            return this.image;
        }
        /*==========    [   SETTERS   ]     ==========*/
        public void setIdempleado(int idEmpleado)
        {
            this.idEmpleado = idEmpleado;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setRol(int rol)
        {
            this.rol = rol;
        }
        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setUltConexion(string ultConexion)
        {
            this.ultConexion = ultConexion;
        }
        public void setImage(string image)
        {
            this.image = image;
        }
        public override string ToString()
        {
            return "ID Empleado: " + idEmpleado + "\nNombre = " + nombre + "\nApellido: " + apellido + "\nRol: " + getRolName() + "[" + getRol() + "]\nUsuario: " + usuario + "\nPassword: " + password + "\nUlt. Conexion: " + ultConexion + "\nImagen: " + image;
        }
    }
}
