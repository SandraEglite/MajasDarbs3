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

       
        public Person(string firstName, string lastName, string Hobby, string Sex, string ievaditaisDatums)
        {
            Name = firstName;
            Surname = lastName;
            
                     
            DateOfBirth = DateTime.Parse(ievaditaisDatums);
            Console.WriteLine(DateOfBirth.ToString("d"));

            

       
           

            
            
        }
        
        public void Greeting() 
        {
        
        }

     public int Age() 
        {
            DateTime sodienasDatums = DateTime.Now;
            int vecums = (DateTime.Now - DateOfBirth);
            
            return vecums; 
        }
    }

}
