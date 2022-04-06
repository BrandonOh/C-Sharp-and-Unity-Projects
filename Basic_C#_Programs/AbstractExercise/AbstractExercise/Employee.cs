using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise
{
    public class Employee<T> : Person, IQuittable
    {

        public List<T> ts = new List<T>();

       
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
