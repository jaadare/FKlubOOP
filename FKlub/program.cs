﻿using System;
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
            IStregsystem Stregsystem = new IStregsystem();
            StregsystemCLI cli = new StregsystemCLI(Stregsystem);

            //test.readfileproducts();
            //test.readfileusers();
            //for (int i = 0; i < test.Productlist.Count; i++)
            //{
            //    Console.WriteLine(" ID: " + test.Productlist[i].ProductID +" Product name: "+ test.Productlist[i].Name +" Price: "+ test.Productlist[i].Price +" Active: "+ test.Productlist[i].Active);
                
            //}
            //foreach (var T in test.Userlist)
            //{
            //    Console.WriteLine(T.ToString());
            //}
            //test.getactiveproducts();

            //foreach (var product in test.ActvieProducts)
            //{
            //    Console.WriteLine("{0}   {1}   {2}   {3}   {4}",product.ProductID,product.Name,product.Price,product.Active,product.CanBeBoughtOnCredit);
                
            //}
            //test.getuser("Jaadare88");
            //test.getproduct(1);

                         
            //Console.ReadKey();

        }
    }   
}
