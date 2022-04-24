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

     public static DateTime Age() 
        {
            //DateTime sodienasDatums = DateTime.Now;


            DateTime ievaditaisDatums = new DateTime();
            DateTime sodienasDatums = DateTime.Now;

            int age = sodienasDatums.Year - ievaditaisDatums.Year;

            Console.WriteLine(age);

            //TimeSpan vecums = DateTime.Now - DateOfBirth;
            //return vecums;
            //string[] standardFmts = { "d" };
            //foreach (string standardFmt in standardFmts)
            //Console.WriteLine("Vecums ir:",vecums.ToString("d"));

        }

        public void Greeting() 
        {
          Console.WriteLine($"Sveiks, mani sauc {Name} {Surname} un man ir {Age()} gadi");
        }


    }

}
