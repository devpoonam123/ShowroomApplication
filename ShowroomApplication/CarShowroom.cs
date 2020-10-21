using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowroomApplication
{
    public class CarShowroom
    {
        public string companyName { get; set; }
        public string modelName { get; set; }
        public string colour { get; set; }
        public double price { get; set; }
        public string discount { get; set; }
        List<CarShowroom> lstcar = new List<CarShowroom>();
        public IEnumerable<CarShowroom> addCustomerData()
        {
            CarShowroom cs1 = new CarShowroom
            {
                companyName = "Maruti",
                modelName = "800",
                colour = "White",
                discount = "20.7%",
                price = 500000
            };
            CarShowroom cs2 = new CarShowroom
            {
                companyName = "Hundai",
                modelName = "I10",
                colour = "Blue",
                discount = "7.7%",
                price = 900000


            };
            CarShowroom cs3 = new CarShowroom
            {
                companyName = "Hundai",
                modelName = "I20",
                colour = "Black",
                discount = "9%",
                price = 1500000
            };
            CarShowroom cs4 = new CarShowroom
            {
                companyName = "Honda",
                modelName = "HondaAmaze",
                colour = "red",
                discount = "20.7%",
                price = 400000
            };

            lstcar.Add(cs1);
            lstcar.Add(cs2);
            lstcar.Add(cs3);
            lstcar.Add(cs4);

            return lstcar;
        }

        public void Formating(IEnumerable<CarShowroom> cshow,string cn)
        {

            IEnumerable<CarShowroom> lists = new List<CarShowroom>();
            lists = cshow;

            double discount_price;
            
           IEnumerable<CarShowroom> cs = lists.Where(m => m.companyName == cn);

            

            Console.WriteLine("Company name |  Colour  |   Discount  | Model name |  Price | Discount_price ");
            foreach (var c in cs)
            {
                string str = c.discount;
                str=str.Replace('%', ' ').Trim();
              double d=  Convert.ToDouble(str);
                discount_price = c.price - (c.price * d / 100);
                Console.WriteLine("------------------------------------");
                Console.WriteLine(String.Format("{0} | {1} | {2} | {3} | {4} | | {5} |", c.companyName, c.colour, c.discount, c.modelName, c.price, discount_price));
                Console.WriteLine("--------------------------------");
            }
            
            
        }
    }
}
