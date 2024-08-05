using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Methods_Design_Patterns;

namespace Factory_Methods_Design_Patterns
{
    public class Client
    {

        private Vehicle _pVehicle;

        public Client()
        {
            _pVehicle = null;

        }

        public void BuildVehicle(VehicleType type)
        {
            IVehicleFactory vf = new VehicleFactory();
            _pVehicle = vf.Build(type);



        }
        public Vehicle GetVehicle()
        {
            return _pVehicle;
        }







    }
}
