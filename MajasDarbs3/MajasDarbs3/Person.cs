using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs3
{
    public class Person
    {
        private string first;
        private string last;

        public Person(string firstName, string lastName) 
        { 
        first = firstName;
        last = lastName;
        }
        
        public string Hobby { get; set; }

        public int DateOfBirth { get; set; }

        public bool IsFemale { get; set; }

        
     public void Greeting() 
        {
        
        }

     public void Age() 
        { 
        
        }
    }

}
