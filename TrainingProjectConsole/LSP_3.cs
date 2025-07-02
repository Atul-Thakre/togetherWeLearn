using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
   /* L: Liskov substitution Principle(LSP)
    if we can successfully replace the object/instance of a parent class with the object/instance
    of the child class, without affecting the behavior of the base class, then it is said to be
    in Liskov Substitution Principle. */

/*
It means child class ko aaisa hona chaiye ki vo jab chahe tab paren class to subsittute kar sake.It means parent
parent class me jitni methods hai vo child class me hona hi chahiye. 
*/

//(CASE-1)

abstract class Bonus   //base/parent class
{
    public abstract double salary();
    public abstract double CalculateBonus(double salary)
}

//child class 1
class CompanyEmployee:Bonus //extends
{
    public override double salary(){
        return 10000;
    }

 public override CalculateBonus salary(double salary){
        return ((salary*0.10)/100);
    }

}

//child class 2
class ContractEmployee:Bonus
{
      public override double salary(){
        return 5000;
    }

 public override CalculateBonus salary(double salary){
        return 0;
    }
}

//child class 3
class ThirdPartyEmployee:Bonus
{
      public override double salary(){
        return 1000;
    }

//We don't want to give Bonus to ThirdPartyEmployee but still need to override the abstract method

//It is breaking LSP

 public override CalculateBonus salary(double salary){
        //return 0;
    //Not applicable
//In that case child class is not the substitute of parent class
    }

}

/*
PROBLEM:-ThirdPartyEmployee class can never replace it's parent class Bonus coz it do not have the same no. of method as Bonus class.
BUT CompanyEmployee & ContractEmployee Follows LSP
 */

//-(CASE:2)----------SOLUTION OF ABOVE PROBLEM--------------
    interface Salary
    {
        double Salary();
    }

    interface Bonus
    {
        double CalculateBonus(double salary);
    }

    class CompanyEmployee : Salary, Bonus   //implements
    {
        public double Salary()
        {
            return 10000;
        }
        public double CalculateBonus(double salary)
        {
            return ((salary * 0.10) / 100);
        }
    }

    class ContractEmployee : Salary, Bonus    //implements
    {
        public double Salary()
        {
            return 5000;
        }
        public double CalculateBonus(double salary)
        {
            return 0;
        }
    }

    class ThirdPartyEmployee : Salary   //implements
    {
        public double Salary()
        {
            return 5000;
        }
    }


}

// SO LSP is easily followed here using interfaces

