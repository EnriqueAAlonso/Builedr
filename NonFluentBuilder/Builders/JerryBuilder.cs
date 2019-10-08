using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class JerryBuilder : BurguerBuilder
    {
        Hamburguesa burguer = new Hamburguesa();

        public JerryBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.carne = TipoCarne.Caballo;
            burguer.costo = 55;
            burguer.foto = "Jerry.jpg";
            setIngredientes();
            burguer.nombre = "Jerry";
            burguer.pan = TipoPan.Blando;
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
            burguer.ingredientes.Add("Jamon");
            
        }
    }
}
