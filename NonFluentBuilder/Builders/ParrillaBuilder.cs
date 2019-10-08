using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class ParrillaBuilder : BurguerBuilder
    {
        Hamburguesa burguer = new Hamburguesa();
        public ParrillaBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.carne = TipoCarne.Caballo;
            burguer.costo = 50;
            burguer.foto = "Parrilla.jpg";
            setIngredientes();
            burguer.nombre = "Parrilla";
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
            burguer.ingredientes.Add("Queso de Cabra");

        }
    }
}
