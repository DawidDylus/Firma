using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirmaApp.Models
{
     public class Staż : Contract
    {
        public Staż(string _contractName = "Staż", double _monthlyWages = 1500 )
        {
            ContractName = _contractName;
            MonthlyWages = _monthlyWages;
        }


        public override double Salary()
        {
            return MonthlyWages;         
            
        }
    }
}
