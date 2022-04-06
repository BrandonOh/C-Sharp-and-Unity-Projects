using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Employee
    {
        public string fName;
        public string lName;
        public int idNum;

        public Employee()
        {
            string firstName = fName;
            string lastName = lName;
            int id = idNum;
        }
    }
}
