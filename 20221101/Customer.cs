using System;
using System.Collections.Generic;
using System.Text;

namespace _20221101
{
    class Customer
    {
        private int _Id;
        private string _FirstName;
        private string _LastName;
        private string _Email;



        public int Id 
        {
            get { return _Id; }
            set 
            {
                if (value <0)
                {
                    _Id = 0;
                }
                else
                {
                    _Id = value;
                }
            }
        }
        public string FirstName 
        { 
            get { return _FirstName; }
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("No Firstname");
                }
                else
                {
                    _FirstName = value;
                }
        }   }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("No Firstname");
                }
                else
                {
                    _LastName = value;
                }
            }
        }
        public string Email
        {
            get { return _Email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Email is null or empty");
                }
                else if(value == null)
                {
                    throw new Exception("Email is empty");
                }
                else
                {
                    _Email = value;
                }
                
            }
        }
        



    }
}
