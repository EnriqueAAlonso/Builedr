using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class ShelbyBuilder : BurguerBuilder
    {
        Hamburguesa burguer = new Hamburguesa();

        public ShelbyBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.carne = TipoCarne.Vaca;
            burguer.costo = 85;
            burguer.foto = "Shelby.jpg";
            setIngredientes();
            burguer.nombre = "Shelby";
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
            burguer.ingredientes.Add("Aros de cebolla");
            burguer.ingredientes.Add("Salsa BBQ");




        }
    }
}
