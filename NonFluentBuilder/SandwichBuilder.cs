using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder
{
    class SandwichBuilder
    {
        private Sandwich sand = new Sandwich();
        public Sandwich cocinar()
        {
            return sand ;
        }

        public void setIngredients()
        {
        }

        public SandwichBuilder(long id)
        {
            
        }
    }
}
