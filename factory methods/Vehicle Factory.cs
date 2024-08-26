using Factory_Methods_Design_Patterns.class_TypeVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Methods_Design_Patterns;


namespace Factory_Methods_Design_Patterns
{
    public class VehicleFactory : IVehicleFactory {

        //Cream obiecte dupa type care il dam
        public Vehicle Build(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.TwoWheeler:

                    return new TwoWheeler();

                case VehicleType.ThreeWheeler:
                    return new ThreeWheeler();

                case VehicleType.FourWheeler:
                    return new FourWheeler();

                default:
                    return null;




            }
        }

       











    }









 }





