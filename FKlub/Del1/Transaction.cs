using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class Transaction
    {

        IStregsystem Stregsystem;

        public Transaction(IStregsystem stregsystem)
        {
            Stregsystem = stregsystem;
        }

        private int _productid;
        private string _user;
        private string _date;
        private int _amount;

        public int ProductID
        {
            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }
            set 
            {
                _user = value;
            }
        }

        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
              
    }


    
    
}
