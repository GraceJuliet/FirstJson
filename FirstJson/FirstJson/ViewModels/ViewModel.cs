using FirstJson.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FirstJson.ViewModels
{
     public class ViewModel:INotifyPropertyChanged
    {
        public Employee emp;

        public RelayCommand Cmd { get; set; }


        Item it;

        public ViewModel()
        {
            emp = new Employee();
            Cmd = new RelayCommand(Canexecute, CanUse);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private int id;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }


        private string address;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
