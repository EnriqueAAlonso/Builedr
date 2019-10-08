using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder
{
    class BaguetteBuilder
    {
        private Baguette sand = new Baguette();
        public Baguette cocinar()
        {
            return sand;
        }

        public void setIngredients()
        {
        }

        public BaguetteBuilder(long id)
        {

        }
    }
}
