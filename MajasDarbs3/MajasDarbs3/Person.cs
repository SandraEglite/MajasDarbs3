using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs3
{
    public class Person
    {
       public string Name { get; set; } 
       public string Surname { get; set; } 
        
             
        public string Hobby { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Sex { get; set; }

        

        public Person(string firstName, string lastName, string ievaditaisHobijs, string Sex, string ievaditaisDatums)
        {
            Name = firstName;
            Surname = lastName;
            Hobby = ievaditaisHobijs; 
                                 
            DateOfBirth = DateTime.Parse(ievaditaisDatums);
            Console.WriteLine(DateOfBirth.ToString("d"));                                     
        }

        public TimeSpan Age()
        {
            DateTime sodienasDatums = DateTime.Now;
            TimeSpan vecums = DateTime.Now - DateOfBirth;
            return vecums;
            
        }

        public void Greeting() 
        {
          Console.WriteLine($"Sveiks, mani sauc {Name} {Surname}, mans hobijs ir {Hobby} un man ir {(Age().Days/365)} gadi");
        }


    }

}
