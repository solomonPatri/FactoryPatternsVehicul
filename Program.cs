using Factory_Methods_Design_Patterns;
using Factory_Methods_Design_Patterns.class_TypeVehicle;
using Factory_Methods_Design_Patterns.service;
using System;

internal class Program
{
    

        public static void Main(string[] args)
        {
           ServiceVehicul serviceVehicul = new ServiceVehicul();
            serviceVehicul.afisare();
           //Console.WriteLine("Introduceti care doriti: ");
           //string type =Console.ReadLine();
           //Vehicle vh = serviceVehicul.ReturnVehicul(type);
                    

            Client client = new Client();

            client.BuildVehicle(VehicleType.TwoWheeler);
            client.GetVehicle().AfisareVehicul();

            client.BuildVehicle(VehicleType.ThreeWheeler);
            client.GetVehicle().AfisareVehicul();

            client.BuildVehicle(VehicleType.FourWheeler);
            client.GetVehicle().AfisareVehicul();
        }






    



}











