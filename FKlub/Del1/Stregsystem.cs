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
        public Product Products;
        public Transaction Transactions;
        public User Users;
        public SeasonalProduct SeasonalProducts;

        private List<User> _userlist = new List<User>();
        private List<Product> _productlist = new List<Product>();
        private List<Transaction> _transactionlist = new List<Transaction>();

        public void readfile()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\test.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                bool altfalse = false;
                int id =  Convert.ToInt32(values[1]);
                int price = Convert.ToInt32(values[3]);
                int active = Convert.ToInt32(values[4]);

               Product newproduct = Products.NewProduct(id,values[2],price,active,altfalse);
                _productlist.Add(newproduct);
                
            }
        }

    }
}
