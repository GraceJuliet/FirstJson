using FirstJson.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using static FirstJson.Models.Employee;

namespace FirstJson.ViewModels
{
    class ViewModel : INotifyPropertyChanged
    {


        Item it;

        public Employee emp;

        public RelayCommand cmd { get; set; }




        public ViewModel()
        {
            emp = new Employee();
            cmd = new RelayCommand(Canexecute, CanUse);


            emp.items = new List<Item>();
            it = new Item();
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

        private string id;

        public string Id
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

        public void Canexecute(object param)
        {
            if (param.ToString() == "Addrecord")
            {
               
                AddSectionRecord();
            }



            else if (param.ToString() == "Clearrecord")
            {
               
                Name = "";
                Id = "";
                Address = "";

               

            }

        }


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //public int FlagsAttribute { get; private set; }
        public bool CanUse(object message)
        {
            return true;
        }
        public void AddSectionRecord()
        {

            string json = System.IO.File.ReadAllText(@"C:\Users\99002679\Downloads\data.json");
            Employee jsondata = new Employee();

            jsondata = JsonConvert.DeserializeObject<Employee>(json);

            if (jsondata != null)
            {

                it.Name = this.Name;
                it.Id = this.Id;
                it.Address = this.Address;
                foreach (var item in jsondata.items)
                {
                    MessageBox.Show(jsondata.items.Count().ToString());
                    

                }
                jsondata.items.Add(it);
                MessageBox.Show("Record added into Json");



                string strresultjson = JsonConvert.SerializeObject(jsondata, Formatting.Indented);
                using (var writer = new StreamWriter(@"C:\Users\99002679\Downloads\data.json"))
                {
                    writer.Write(strresultjson);
                }

            }
        }
    }
}
