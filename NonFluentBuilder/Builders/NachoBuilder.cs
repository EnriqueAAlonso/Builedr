using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class NachoBuilder
    {
        Hamburguesa burguer = new Hamburguesa();
        public NachoBuilder()
        {
            burguer.carne = TipoCarne.Vaca;
            burguer.costo = 100;
            burguer.foto = "Nacho.jpg";
            setIngredientes();
            burguer.nombre = "Nacho";
            burguer.pan = TipoPan.Blando;
            burguer.papas = true;
        }

        public Hamburguesa cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Lechuga");
            burguer.ingredientes.Add("Queso Amarillo");
            burguer.ingredientes.Add("Tocino");
            burguer.ingredientes.Add("Jamon");
            burguer.ingredientes.Add("Mostaza");
            burguer.ingredientes.Add("Queso blanco");
            burguer.ingredientes.Add("Mayonesa");

        }
    }
}
