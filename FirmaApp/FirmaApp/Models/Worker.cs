using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace FirmaApp.Models 
{
    public class Worker : INotifyPropertyChanged
    {

        public Worker(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;

            
            ContractType();
            Contract = new Staz();
            
           
        }


        
        public string salary
        {
            get
            {
                return Salary();
            }
            set
            {

            }   
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

        private Contract contract;
        public Contract Contract
        {
            get
            {
                return contract;
            }      
            set
            {   if (contract != value)
                {
                    contract = value;
                    RaisePropertyChanged("Contract");
                }
            }
        }
                               

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + contract.Salary();
        }                                        
        
        public string Salary()
        {
            return contract.Salary().ToString();
        }
                 

          public ObservableCollection<Contract> Contracts
          {
            get;
            set;
          }

        
          private Contract _scontract;
          public Contract SContract
          {
              get
              {
                  return _scontract;
              }
              set
              {
                
                if (_scontract != value)
                  {
                    
                    _scontract = value;
                    ChangeContract();
                    RaisePropertyChanged("Scontract");   
                    
                                              
                }
              }
          }         
                     
        
        public void ContractType()
        {
            ObservableCollection<Contract> contracts = new ObservableCollection<Contract>()
            {
                new Staz(),
                new Etat()
            };
            Contracts = contracts;
        }

        
        public void ChangeContract()
        {
            Contract = SContract;                 ///changing object contract to type picked by ComboBox  
            RaisePropertyChanged("Contract");     ///update changes   
            RaisePropertyChanged("salary");      
        }
        



        void RaisePropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;





    }
}
