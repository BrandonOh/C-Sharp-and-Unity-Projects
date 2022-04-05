using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadExercise
{
    class Employee
    {
        public string id;

        public static bool operator== (Employee em, Employee em2)
        {
            return em.id == em2.id;
        }

        public static bool operator!= (Employee em, Employee em2)
        {
            return em.id != em2.id;
        }
    }
}
