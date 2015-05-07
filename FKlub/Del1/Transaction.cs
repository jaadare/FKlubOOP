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

        public Transaction()
        {

        }

        protected int _transactionid;
        protected User _user;
        protected DateTime _date;
        protected int _amount;

        public int TransactionID
        {
            get
            {
                return _transactionid;
            }
            set
            {
                _transactionid = value;
            }
        }

        public User Buyer
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

        public DateTime Date
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

        public override string ToString()
        {
            string s1 = Convert.ToString(TransactionID);
            string s2 = Convert.ToString(Amount);
            string s3 = Convert.ToString(Date);
            return "Transaction ID:" + s1 + " Amount: " + s2 + " Date: " + s3;
        }
        
              
    }


    
    
}
