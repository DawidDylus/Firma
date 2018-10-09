using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaApp.Models
{
     public class Etat : Contract
    {
        public Etat(float _overtimeHours = 0, string _contractName = "Etat", double _monthlyWages = 3600)
        {
            ContractName = _contractName;
            MonthlyWages = _monthlyWages;
            OvertimeHours = _overtimeHours;
        }

        public override double Salary()
        {
            return MonthlyWages + OvertimeHours * (MonthlyWages/60);            
        }
    }
}
