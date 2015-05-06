using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    public class SeasonalProduct:Product
    {
        IStregsystem Stregsystem;

        public SeasonalProduct(IStregsystem stregsystem)
        {
            Stregsystem = stregsystem;
        }
        private string _startdate;
        private string _enddate;

        public string StartDate
        {
            get
            {
                return _startdate;
            }
            set 
            {
                _startdate = value;
            }
        }

        public string EndDate
        {
            get
            {
                return _enddate;
            }
            set
            {
                _enddate = value;
            }
        }

        
    }
}
