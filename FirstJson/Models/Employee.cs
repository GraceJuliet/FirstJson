using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FirstJson.Models
{
    public class Employee
    {
        public List<Item> items { get; set; }




    }
        public class Item
        {
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
                }
            }
        }

           
    
}
