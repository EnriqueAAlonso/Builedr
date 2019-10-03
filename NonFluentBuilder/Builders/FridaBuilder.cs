using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class FridaBuilder
    {
        Hamburguesa burguer = new Hamburguesa();

        public FridaBuilder()
        {
            burguer.carne = TipoCarne.Vaca;
            burguer.costo = 65;
            burguer.foto = "Frida.jpg";
            setIngredientes();
            burguer.nombre = "Frida";
            burguer.pan = TipoPan.Molde;
            burguer.papas = true;
        }

        public Hamburguesa cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Tomate");
            burguer.ingredientes.Add("Queso Amarillo");
            burguer.ingredientes.Add("Lechuga");
            burguer.ingredientes.Add("Ranch");




        }
    }
}
