using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder
{
    public abstract class BurguerBuilder
    {
          Hamburguesa burguer=new Hamburguesa();
         public Hamburguesa cocinar()
        {
            return burguer;
        }

        public void setIngredients()
        {
        }

        public BurguerBuilder(long id)
        {

        }

    }
}
