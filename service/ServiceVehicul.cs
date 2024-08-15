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

        public Vehicle ReturnVehicleById(int id)
        {
            for(int i = 0; i < _serviceVeh.Count; i++)
            {
                if (_serviceVeh[i].Id == id)
                {
                    return _serviceVeh[i];
                }

            }
            return null;



        }
        public int GeneratenextId()
        {
            Random random = new Random();
            int nrrand = random.Next(15, 100);
            while (ReturnVehicleById(nrrand)!=null)
            {
                nrrand = random.Next(15,100);

            }
            return nrrand;
        }
        public void adaugareVehicle(Vehicle vehicle)
        {
            Vehicle add = vehicle;
            _serviceVeh.Add(add);

        }

        public void InformComplete(Vehicle vehicle)
        {

            if (vehicle is TwoWheeler)
            {
                Console.WriteLine("Introduceti datele necesare completarea datelor" + "+/n");
                Console.WriteLine("Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Color: ");
                string color = Console.ReadLine();
                Console.WriteLine("Propietar: ");
                string pro = Console.ReadLine();

                Vehicle complevehicle = new TwoWheeler(24, "TwoWheeler", year, color, pro);
                adaugareVehicle(complevehicle);

            }
            else
            {
                if (vehicle is ThreeWheeler)
                {
                    Console.WriteLine("Introduceti datele necesare completarea datelor" + "+/n");
                    Console.WriteLine("Year: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Model: ");
                    string model = Console.ReadLine();
                    Console.WriteLine("Color: ");
                    string color = Console.ReadLine();
                    Console.WriteLine("Kilometraj: ");
                    int kilom = int.Parse(Console.ReadLine());

                    Vehicle infoveeh = new ThreeWheeler(34, "ThreeWheeler", year, model, color, kilom);
                    adaugareVehicle(infoveeh);

                }
                else
                {
                    if (vehicle is FourWheeler)
                    {
                        Console.WriteLine("Introduceti datele necesare completarea datelor" + "+/n");
                        Console.WriteLine("Year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Model:");
                        string model = Console.ReadLine();
                        Console.WriteLine("Propietar: ");
                        string propi = Console.ReadLine();
                        Console.WriteLine("Nr de matricola: ");
                        string nrmatri = Console.ReadLine();

                        Vehicle newveh = new FourWheeler(44, "FourWheeler", year, model, propi, nrmatri);
                        adaugareVehicle(newveh);
                    }
                    else
                    {
                        Console.WriteLine("A intervenit o problema!");
                    }











                }

            }
        }

       











    }
}
