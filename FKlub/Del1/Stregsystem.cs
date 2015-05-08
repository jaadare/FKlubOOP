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
        //public Product Product;
        //public Transaction Transaction;
        //public User User;
        //public SeasonalProduct SeasonalProduct;
        //public BuyTransaction BuyTransaction;
        //public InsertCash InsertCash;

        private List<User> _userlist = new List<User>();
        private List<Product> _productlist = new List<Product>();
        private List<Product> _activeproducts = new List<Product>();
        private List<Transaction> _transactionlist = new List<Transaction>();
        private List<Transaction> _usertransactions = new List<Transaction>();
        
        
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

        public List<Product> ActvieProducts
        {
            get
            {
                return _activeproducts;
            }
            set
            {
                _activeproducts = value;
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

        public List<Transaction> UserTransactionlist
        {
            get
            {
                return _usertransactions;
            }
            set
            {
                _usertransactions = value;
            }
        }

        public void readfileproducts()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\products.csv"), Encoding.UTF8);
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
            User user = getuser(username);
            Product product = getproduct(productid);

            Transaction buy = new Transaction();
            


            if (user.Balance - product.Price > 0)
            {
                ExecuteTransaction(buy,product,user);
            }
            
                
        }

        public void AddCreditToAccount(string username, int amount)
        {
            User user = getuser(username);

            

        }

        public void ExecuteTransaction(Transaction trans, Product product, User user)
        {
            trans.execute(trans,product,user);
        }

        public void ExecuteTransaction(User user, int Amount)
        {

        }

        public Product getproduct(int productid)
        {
            var query = from products in Productlist
                        where products.ProductID == productid
                        select products;
            Product product = query.FirstOrDefault();
          
          
            return product;
        }

        public User getuser(string username)
        {
            var query =  from users in Userlist
                         where users.UserName == username
                         select users;

            User user = query.FirstOrDefault();
                if(user == null)
                {
                    
                }
                else     
            Console.WriteLine("{0}{1}{2}{3}{4}",user.UserID,user.UserName,user.FirstName,user.LastName,user.Balance); 
            return user;
                        
            
        }

        public void gettransactionlist(string username,int numtransaction)
        {
            var query = from transactions in Transactionlist
                        where transactions.Buyer.UserName == username
                        orderby transactions.Date ascending
                        select transactions;

            List<Transaction> temp = query.ToList();
            if (temp.Count == null)
            {
                
            }

            else if (numtransaction > temp.Count)
            {
                for (int i = 0; i <= temp.Count; i++)
                {
                    UserTransactionlist.Add(temp[i]);
                }
            }
            for (int i = 0; i <= numtransaction; i++)
            {
                
            }

           
        }

        public void getactiveproducts()
        {
            var query = from products in Productlist
                        where products.Active == 1
                        select products;
            ActvieProducts = query.ToList();
        }
    }
}
