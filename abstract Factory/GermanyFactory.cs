using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.abstract_Factory
{
    public class GermanyFactory
    {
        public static Car BuildCar(Type model)
        {
            switch (model)
            {
                case Type.Seat:

                    return new SeatCar(Location.Germany);

                case Type.Ford:

                    return new FordCar(Location.Germany);
                case Type.BMW:

                    return new BMWCar(Location.Germany);

                default:
                    return null;





            }









        }










    }
}
