using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomApplication
{
   public  class Program
    {
        IEnumerable<CarShowroom> lists = new List<CarShowroom>();
        static void Main(string[] args)
        {
            Console.WriteLine("------------Welecome to my showroom---------------");
            Console.WriteLine("There are the list of Car's  which is avilable in our company!");
            IEnumerable<CarShowroom> lists = new List<CarShowroom>();
              CarShowroom carShowroom = new CarShowroom();
          lists=  carShowroom.addCustomerData();
            IEnumerable<string> listcompanyname = lists.Select(m => m.companyName).Distinct();
             


            foreach(var c in listcompanyname)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Which model do you want to see!");
            int count = 0;
            foreach (var c in listcompanyname)
            {
                ++count;
                Console.WriteLine("If you want to go with"+"  "  +c+  " "+"press"+"  "+count+":");
            }
            string choice = Console.ReadLine();
              

            switch (choice)
            {
                case "1":

                    carShowroom.Formating(lists,"Maruti");
                    break;

                case "2":

                    carShowroom.Formating(lists,"Hundai");

                    break;

                case "3":

                    carShowroom.Formating(lists,"Honda");

                    break;
            }
                

            Console.ReadLine();

        }

        
        }

    }

