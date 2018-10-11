using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FirmaApp.Models
{
    abstract public class Contract : INotifyPropertyChanged
    {
        public Contract()
        {

        }

        private string contractName;
        public string ContractName
        {
            get
            {
                return contractName;
            }
            set
            {
                if (contractName != value)
                {
                    contractName = value;
                    RaisePropertyChanged("ContractName");
                }
            }
        }
             
        private double monthlyWages;
        protected double MonthlyWages
        {
            get
            {
                return monthlyWages;
            }
            set
            {
                if (monthlyWages != value)
                {
                    monthlyWages = value;
                    RaisePropertyChanged("MonthlyWages");
                }
            }
        }

        private float overtimeHours;
        public float OvertimeHours
        {
            get
            {
                return overtimeHours;
            }
            set
            {
                if (overtimeHours != value)
                {
                    overtimeHours = value;
                    RaisePropertyChanged("OvertimeHours");                                        
                }
            }
        }

        public abstract double Salary();
       


        void RaisePropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;


    }
}
