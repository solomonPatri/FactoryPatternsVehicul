using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.abstract_Factory
{
    public class SpainFactory
    {
        public static Car Buildcar(Type model)
        {

            switch (model)
            {
                case Type.Seat:

                    return new SeatCar(Location.Spain);
                case Type.Ford:
                    return new FordCar(Location.Spain);

                case Type.BMW:
                    return new BMWCar(Location.Spain);
                default:
                    return null;


            }





        }





    }
}
