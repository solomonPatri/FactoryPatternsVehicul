using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.abstract_Factory
{
    public class CarFactory
    {
        private CarFactory()
        {

        }

        public static Car BuildCar(Type type)
        {
            Location location = Location.Spain;

            switch(location)
            {
                case Location.Spain:
                    return SpainFactory.Buildcar(type);

                case Location.Germany:
                    return GermanyFactory.BuildCar(type);

               default:
                    return DefaultFactory.BuildCar(type);

            }



        }









    }
}
