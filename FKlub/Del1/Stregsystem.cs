using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OOP_Eksamen
{
    public class IStregsystem
    {
        public Product Product;
        public Transaction Transaction;
        public User User;
        public SeasonalProduct SeasonalProduct;
        public BuyTransaction BuyTransaction;
        public InsertCash InsertCash;

        private List<User> _userlist = new List<User>();
        private List<Product> _productlist = new List<Product>();
        private List<Transaction> _transactionlist = new List<Transaction>();
        
        public List<User>Userlist
        {
            get
            {
                return _userlist;
            }
            set
            {
                _userlist = value;
            }
        }

        public List<Product> Productlist
        {
            get
            {
                return _productlist;
            }
            set
            {
                _productlist = value;
            }
        }

        public List<Transaction> Transactionlist
        {
            get
            {
                return _transactionlist;
            }
            set
            {
                _transactionlist = value;
            }
        }
        
        public void readfileproducts()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\products.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(';');

                Product newproduct = new Product();
                newproduct.ProductID = Convert.ToInt32(values[0]);
                newproduct.Name = values[1];
                newproduct.Price = Convert.ToInt32(values[2]);
                newproduct.Active = Convert.ToInt32(values[3]);
                newproduct.CanBeBoughtOnCredit = false;

                Productlist.Add(newproduct);         
            }
        }

        public void readfileusers()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\users.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(';');

                User newuser = new User();
                newuser.UserID = Convert.ToInt32(values[0]);
                newuser.FirstName = values[1];
                newuser.LastName = values[2];
                newuser.UserName = values[3];
                newuser.Email = values[4];
                newuser.Balance = Convert.ToDouble(values[5]);

                Userlist.Add(newuser);
            }
        }

        public void BuyProduct(string username, int productid)
        {
            var query1 = from user in Userlist
                         where username == user.UserName
                         select user;
            query1.

        }
        

    }
}
