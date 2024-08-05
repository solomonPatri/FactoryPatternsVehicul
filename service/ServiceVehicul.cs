using Factory_Methods_Design_Patterns.class_TypeVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.service
{
    internal class ServiceVehicul
    {
        private List<Vehicle> _serviceVeh;

        public ServiceVehicul()
        {

            _serviceVeh = new List<Vehicle>();
            this.load();
        }

        public void load()
        {
            TwoWheeler twoWheeler = new TwoWheeler(10,"TwoWheeler",2019,"Blue","Mario");
            ThreeWheeler treewheeler1 = new ThreeWheeler(11, "ThreeWheeler", 2020, "Seat", "Black", 129302);
            FourWheeler fourWheeler = new FourWheeler(12, "FourWheeler", 2017, "Ford", "Andreea", "SB 24HGJ");


            _serviceVeh.Add(twoWheeler);
            _serviceVeh.Add(treewheeler1);
            _serviceVeh.Add(fourWheeler);


        }

        public void afisare()
        {
            for(int i=0;i<_serviceVeh.Count;i++)
            {

                _serviceVeh[i].AfisareVehicul();

            }
        }
        public Vehicle ReturnVehicul(string type)
        {
            for (int i = 0; i < _serviceVeh.Count; i++)
            {
                if ((_serviceVeh[i] as TwoWheeler).Type.Equals(type))
                {
                    return (_serviceVeh[i] as TwoWheeler);
                }
                else
                {  if((_serviceVeh[i] as ThreeWheeler).Type.Equals(type))
                    {
                        return (_serviceVeh[i] as ThreeWheeler);
                    }
                    else
                    {
                        if((_serviceVeh[i] as FourWheeler).Type.Equals(type))
                        {
                            return (_serviceVeh[i] as FourWheeler);
                        }
                    }

                }

            }
            return null;
        }

        












    }
}
