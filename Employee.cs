using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    public class Employee
    {
        private int id;
        private string name;
        private int age;

        // property in C#
        /*  Property is used to set the value to the data member
            Property is used to get the value from the data member
            Property have set & get accessors, set accessor is used to initialize value to the data member
            Get accessor is used to retrieve value from the data member
            Property is also called as special method of a class
         */

        public int Id
        {
            get { return id; }
            set { id = value; } // value is a built in keyword which set the value to the variable
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

}


        /* 

        Property will give restricted access to the variable
        We can have only get accessor in the property, that will create a read only property
        We can have only set accessor in the property , that will create a write only property
        We can use any access specifier to either set or get , but not for both 

        */