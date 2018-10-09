using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FirmaApp.Models 
{
    public class Worker : INotifyPropertyChanged
    {

        public Worker(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
            _contract = new Etat();
        }




        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");                    
                }
            }
        }       //Getter,Setter for firstName variable

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");                    
                }
            }
        }

        private Contract _contract;
        public Contract contract
        {
            get
            {
                return _contract;
            }
        }


        public string salary
        {
            get
            {
                return Salary();
            }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + _contract.ContractName + " " + _contract.Salary();
        }
        
                    

        
        
        public string Salary()
        {
            return _contract.Salary().ToString();
        }
        
        

        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;





    }
}
