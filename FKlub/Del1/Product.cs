using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class Product
    {
        IStregsystem Stregsystem;

        public Product(IStregsystem stregsystem)
        {
            Stregsystem = stregsystem;
        }
        public Product()
        {

        }

        public Product(int newProductID, string newProductName, int newPrice, int newProductActive, bool newCanBeBoughtOnCredit)
        {
            this.ProductID = newProductID;
            this.Name = newProductName;
            this.Price = newPrice;
            this.Active = newProductActive;
            this.CanBeBoughtOnCredit = newCanBeBoughtOnCredit;
        }


        protected int _productid;
        protected string _name;
        protected int _price;
        protected int _active;
        protected bool _boughtoncredit;

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

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public int Active
        {
            get
            {
                return _active;
            }
            set{
                _active = value;
            }
        }

        public bool CanBeBoughtOnCredit
        {
            get
            {
                return _boughtoncredit;
            }
            set
            {
                _boughtoncredit = value;
            }
        }
       
        
    }
}
