using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjectConsole
{
    /*O: Open closed Principle (OCP)
    -->OCP says that classes, methods, modules etc.are open for extension, but closed for modification. */
   

    /*class Employee
    {

        (CASE:1)-Suppose need to give bonus to an employee

        public double CalculateBonus(double salary)
        {
           return ((salary * 0.10) / 100);
        }

         (CASE:2)-Suppose new requirement, need to give bonus to an employee based on type of employee
        
        double bonus=0;
        public double CalculateBonus(string emptype, double salary)
        {
            if (emptype == "CompanyEmployee")
            {
                bonus = ((salary * 0.10) / 100);
            }
            else if (emptype == "ContractEmployee")
            {
                bonus = 0;
            }
            else if (emptype == "ThirdParty")  //Again new reqirement then need to change this method again
            {
                bonus = 0;
            }
            return bonus;
        }

    } */

  /*  DrawBack of above way of writing code:-
    i)End up testing for entire module
   ii)QA team need to test the entire flow
  iii)Costly process  */

    abstract class Bonus
    {
        public abstract double CalculateBonus(double salary);
    }

    class CompanyEmployee: Bonus //extends
    {
        public override double CalculateBonus(double salary)
        {
            return ((salary * 0.10) / 100);
        }
    }

    class ContractEmployee : Bonus  //extends
    {
        public override double CalculateBonus(double salary)
        {
            return 0;
        }
    }

    class ThirdParty : Bonus //extends
    {
        public override double CalculateBonus(double salary)
        {
            return 0;
        }
    }


}

/* (Advantage)
We are easily extending our code without changing the existing class CompanyEmployee.
we are modifing according to our use case.
 */ 

