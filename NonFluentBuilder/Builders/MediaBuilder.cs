using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class MediaBuilder
    {
        Hamburguesa burguer = new Hamburguesa();
        public MediaBuilder()
        {
            burguer.carne = TipoCarne.Rellena;
            burguer.costo = 85;
            burguer.foto = "Media.jpg";
            setIngredientes();
            burguer.nombre = "Media";
            burguer.pan = TipoPan.Blando;
            burguer.papas = true;
        }

        public Hamburguesa cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Queso Amarillo");
            burguer.ingredientes.Add("Tocino");
            burguer.ingredientes.Add("Jamon");
            burguer.ingredientes.Add("Mostaza");




        }
    }
}
