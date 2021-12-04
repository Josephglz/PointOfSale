using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        private int idCategoria;
        private string categoria;
        private int idParent;

        public Categoria() { }
        public Categoria(int idCategoria, string categoria, int idParent)
        {
            this.idCategoria = idCategoria;
            this.categoria = categoria;
            this.idParent = idParent;
        }
        public void setIdCategoria(int idCategoria)
        {
            this.idCategoria = idCategoria;
        }
        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }
        public void setIdParent(int idParent)
        {
            this.idParent = idParent;
        }

        public int getIdCategoria()
        {
            return this.idCategoria;
        }
        public string getCategoria()
        {
            return this.categoria;
        }

        public int getIdParent()
        {
            return this.idParent;
        }

        public override string ToString()
        {
            return "ID: " + idCategoria +
                "\nCategoría: " + categoria +
                "\nID Padre: " + idParent;
        }
    }
}
