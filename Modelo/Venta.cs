using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Venta
    {
        private int idVenta;
        private int idEmpleado;
        private string fecha;
        private string hora;
        private float totalVta;
        private float totalPago;

        public Venta(){}
        public Venta(int idVenta, int idEmpleado, string fecha, string hora, float totalVta, float totalPago)
        {
            this.idVenta = idVenta;
            this.idEmpleado = idEmpleado;
            this.fecha = fecha;
            this.hora = hora;
            this.totalVta = totalVta;
            this.totalPago = totalPago;
        }
        public int getIdVenta()
        {
            return idVenta;
        }

        public int getIdEmpleado()
        {
            return idEmpleado;
        }

        public string getFecha()
        {
            return fecha;
        }

        public string getHora()
        {
            return hora;
        }

        public float getTotalVta()
        {
            return totalVta;
        }

        public float getTotalPago()
        {
            return totalPago;
        }

        public void setIdVenta(int idVenta)
        {
            this.idVenta = idVenta;
        }

        public void setIdEmpleado(int idEmpleado)
        {
            this.idEmpleado = idEmpleado;
        }

        public void setFecha(string fecha)
        {
            this.fecha = fecha;
        }

        public void setHora(string hora)
        {
            this.hora = hora;
        }

        public void setTotalVta(float totalVta)
        {
            this.totalVta = totalVta;
        }

        public void setTotalPago(float totalPago)
        {
            this.totalPago = totalPago;
        }

        public override string ToString()
        {
            return "____________________________" +
            "ID Venta: " + idVenta +
            "ID Empleado: " + idEmpleado +
            "Fecha: " + fecha +
            "Hora: " + hora +
            "Total Venta: $" + totalVta +
            "Total Pago: $" + totalPago;
        }
    }
}
