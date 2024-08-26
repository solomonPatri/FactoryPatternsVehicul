using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.singleton
{
    public class Singleton
    {
        //Daca este static pentru a stoca o singura data instanta clasei Singleton


        private static Singleton _singleton;
        //Constructorul privat evita clasa sa fie instantiata de afara
        private Singleton()
        {
            Console.WriteLine("Singleton is Instanted.");

        }

        //metoda statica este pentru a putea obtine instanta unica din clasa, DOAR O SINGURA DATA

        public static Singleton GetInstance()
        {
            if(_singleton == null)
            {
                _singleton = new Singleton();

            }return _singleton;



        }
        //Daca functia face ceva, poate face orice

        public void DoSomething()
        {

            Console.WriteLine("Sa creat singleton cu succes!");
        }














         








    }
}
