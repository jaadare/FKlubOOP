using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    }
}
