using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class Program
    {
        static void Main(string[] args)
        {
            IStregsystem test = new IStregsystem();

            test.readfileproducts();
            test.readfileusers();
            for (int i = 0; i < test.Productlist.Count; i++)
            {
                Console.WriteLine(" ID: " + test.Productlist[i].ProductID +" Product name: "+ test.Productlist[i].Name +" Price: "+ test.Productlist[i].Price +" Active: "+ test.Productlist[i].Active);
                
            }
            foreach (var T in test.Userlist)
	        {
		        Console.WriteLine(T.ToString());
                
	}

                         
            Console.ReadKey();

        }
    }   
}
