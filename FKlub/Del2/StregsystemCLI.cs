using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class StregsystemCLI
    {
        IStregsystem Stregsystem;

        public StregsystemCLI (IStregsystem stregsystem)
        {
            Stregsystem = stregsystem;
        }

        public interface IstregsystemUI
        {
            void DisplayUserNotFound();
            void DisplayProductNotFound();
            void DisplayUserInfo();
            void DisplayToManyArgumentsError();
            void DisplayAdminCommandNotFound();
            void DisplayUserBuysProduct();
            void DisplayUserBuysProduct();
            void Close();
            void DisplayInsufficentFunds();
            void DisplayGeneralError();

        }

            public void DisplayUserNotfound()
            {
             
            }
    }
}
