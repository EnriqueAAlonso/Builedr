using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class InfantilBuilder
    {
        Hamburguesa burguer = new Hamburguesa();
        public InfantilBuilder()
        {
            burguer.carne = TipoCarne.Caballo;
            burguer.costo = 45;
            burguer.foto = "Infantil.jpg";
            setIngredientes();
            burguer.nombre = "Infantil";
            burguer.pan = TipoPan.Molde;
            burguer.papas = false;
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
            burguer.ingredientes.Add("Jalapeño");
            
        }
    }
}
