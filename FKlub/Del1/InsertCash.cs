using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class InsertCash:Transaction
    {
         IStregsystem Stregsystem;

        public InsertCash(IStregsystem stregsystem)
        {
            Stregsystem = stregsystem;
        }

        public void execute(User user, int Amount)
        {
            user.Balance = user.Balance + Amount;


        }
        

    }
}
