using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Person
    {
        string name;
        string address;
        int contact;


        public Person()
        {


        }
        public string getName()
        {
            return name;
        }
        public int getContact()
        {
            return contact;
        }
        public string getAddress()
        {
            return address;
        }  
        public void setName(string name)
        { 
            this.name = name;
        }
        public void setContact(int contact)
        {
            this.contact = contact;
        }
        public void setAddress(string address)
        { 
            this.address = address;
        }

    }
}
