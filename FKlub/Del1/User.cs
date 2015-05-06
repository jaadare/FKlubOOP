using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Eksamen
{
    public class User :IComparable<User>
    {
        IStregsystem Stregsystem;

        public User(IStregsystem stregsystem)
        {
            Stregsystem = stregsystem;
        }

       private int _userid;
       //unik id nr, inc for indmeld
       private string _firstname;
       private string _lastname;
       private string _username;
        // 0-9 a-z A-Z og _ resten ikke valid
       private string _email;
        // localpart@domain 
        // local == 0-9 a-z A-Z og _ , . , -
        // domain == 0-9 a-z A-Z og -
        // domain must contain 1 . but cant begin or end with either . or -
       private double _balance;

       public int UserID
       {
           get
           {
               return _userid;
           }
           set
           {
               _userid = value;
           }
       }
       
       public string FirstName
       {
           get
           {
               return _firstname;
           }
           set
           {
               _firstname = value;
           }
       }

       public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

       public string UserName
       {
           get
           {
               return _username;
           }
           set
           {
               _username = value;
           }
       }

       public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

       public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

       public int CompareTo(User other)
       {
           // If other is not a valid object reference, this instance is greater. 
           if (other == null) return 1;
           return UserID.CompareTo(other.UserID);
       }
       
       public override string ToString()
       {
           
           return String.Format("Name:{0},{1}, Email:{2}",_firstname,_lastname,_email); 
       }


    }
    
}
