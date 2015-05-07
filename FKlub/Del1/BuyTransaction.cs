using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class BuyTransaction:Transaction
    {
         IStregsystem Stregsystem;

        public BuyTransaction (IStregsystem stregsystem)
        {
            Stregsystem = stregsystem;
        }

        public void execute(User buyer ,Product purchase )
        {
            if (buyer.Balance - purchase.Price < 0 && purchase.CanBeBoughtOnCredit == false)
            {
                Console.WriteLine("no good");
            }
            else
            
                buyer.Balance = buyer.Balance - purchase.Price;
                
                
                
            
           
        }

        public override string ToString()
        {
            string s1 = Convert.ToString(Amount);
            string s2 = Convert.ToString(Date);
            string s3 = Convert.ToString(TransactionID);

            return "A buy has been made by: " + Stregsystem.User.UserName + " Total Amount is: " + s1 + " bought on " + s2 + " With Transaction ID: " + s3;
        }
    }
}
