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
        private int _id;
        private Vehicle _pVehicle;





        public Client(Vehicle vehiculul)
        {
            _pVehicle = null;

        }
        public Client()
        {

        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public void BuildVehicle(VehicleType type)
        {
            IVehicleFactory vf = new VehicleFactory();
            _pVehicle = vf.Build(type);



        }

        //Returneaza vehiculul creat (Dar este gol de date)
        public Vehicle GetVehicle()
        {
            return _pVehicle;
        }
        
        





    }
}
