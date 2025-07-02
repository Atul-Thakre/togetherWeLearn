using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrainingProjectConsole
{
    //S: Single Responsibility Principle(SRP)
    //SRP says that each class, module, or function in your program should only do one job.
    //In other words, each should have full responsibility for a single functionality of the program.
    class customer
    {
        public void SaveCustomer()
        {
            sqlconnection.createcon();

            //Save logic  (should be only responsiblity of this class.)
            //Param1
            //Param2

            Emailer.sentemail();

            Logger.WriteLog();
        }

        public void saveEmployee()  //(Bad practice) we can not write employee related things here we should only keep Customer related stuff
        {

        }

        //Customer class is doing only one task i.e saving customer's details only
        //For other functionality we have created seperate classes.
    }

    static class sqlconnection
    {
        public static void createcon()
        {
               //logic for create connection
        }
    }

    static class Emailer
    {
        public static void sentemail()
        {
             //logic to send email
        }
    }

    static class Logger
    {
        public static void WriteLog()
        {
            //logic to write log.
        }
    }
}

/*Advantages of SRP
i)Easy Testing :-if someone wants to test individual module can easly test its functionality without hampering others.
ii)Parallel Development:-different devs can work on different modules simultaneously.
iii)Loose Coupling:-

*/