using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
   /* D: Dependency Inversion Principle(DIP)
    DIP Says High-level modules should not depend on low-level modules.Instead,both should depend on abstractions (interfaces). 

=> High-level modules/classes implement business rules or logic in a system (application).
    
    =>Low-level modules/classes deal with more detailed operations; in other words, they may write information to databases or pass messages to the operating system or services.
    

     When a class knows explicitly about the design and implementation of another class, it raises the risk that changes to one class will break the other. So we must keep these high-level and low-level modules/classes loosely coupled as much as possible. To do that, we need to make both of them dependent on abstractions instead of knowing each other
    
   
    */

    class Employee
    {
        public void SaveEmployee()
        {
            //here we are using SaveEmployee() of EMPDataAccessLayer, bcoz it's instance is created
            EMPDataAccessLayer objDataAccess = new EMPDataAccessLayer();  // EMPDataAccessLayer class object instace
            objDataAccess.SaveEmployee(); //instance.class_Method
        }
    
    class EMPDataAccessLayer 
     {
        public void SaveEmployee()
        {
            //Save method 
        }
     }
   }


  //--------------SOLUTION-DI-------------------------------------
    public interface IEMPDataAccessLayer
    {
        public void SaveEmployee();
    }

    public class EMPDataAccessLayer : IEMPDataAccessLayer
    {
        public void SaveEmployee()
        {
            //Code for save employee
        }
    }

       public class EMPDataAccessLayer1 : IEMPDataAccessLayer
    {
        public void SaveEmployee()
        {
            //Code for save employee
        }
    }

    public class Employee
    {
        private readonly IEMPDataAccessLayer _EMPDataAccessLayer;

        public Employee(IEMPDataAccessLayer EMPDataAccessLayer) //we are injecting interface IEMPDataAccessLayer through constructor injection.
        {
            _EMPDataAccessLayer = EMPDataAccessLayer;
        }

        public void SaveEmployee()
        {
            _EMPDataAccessLayer.SaveEmployee();
        }
    }
}


/* Advantages
1)Loose Coupling:-With the help of dependency injection we can achieve better and easy dependency inversion principle
  */