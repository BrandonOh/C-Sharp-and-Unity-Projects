using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise
{
    public class Employee : Person, IQuittable
    { 
    
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("I Quit");
        }
        
    }
}
