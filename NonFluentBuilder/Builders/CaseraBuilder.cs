using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class CaseraBuilder
    {
        Hamburguesa burguer = new Hamburguesa();

        public CaseraBuilder()
        {
            burguer.carne = TipoCarne.Vaca;
            burguer.costo = 65;
            burguer.foto = "Casera.jpg";
            setIngredientes();
            burguer.nombre = "Casera";
            burguer.pan = TipoPan.Blando;
            burguer.papas = false;
        }

        public Hamburguesa cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Ketchup");
            burguer.ingredientes.Add("Queso Amarillo");
            burguer.ingredientes.Add("Lechuga");
            burguer.ingredientes.Add("Cebolla");




        }
    }

}
