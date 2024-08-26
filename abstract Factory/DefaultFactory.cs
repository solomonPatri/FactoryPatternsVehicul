using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.abstract_Factory
{
    public class DefaultFactory
    {
        public static Car BuildCar(Type model)
        {
            switch (model)
            {
                case Type.Seat:

                    return new SeatCar(Location.Default);
                case Type.Ford:
                    return new FordCar(Location.Default);
                case Type.BMW:
                    return new BMWCar(Location.Default);
                default:
                    return null;

            }

        }
    }






}

