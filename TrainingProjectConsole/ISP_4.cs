using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
   /* I: Interface Segregation Principle (ISP)
    ISP says clients should not be forced to implement interfaces they don’t use.
    So instead of huge interfaces, it is better to create multiple small ones so that
    they are utilized in the best possible way. */

//------CASE:1-------------------

interface iCommunication{
        void TextMessaging(string content);
        void WhatsappText(string content);
        void VideoCall(string content);
}

class Ajeet_Ka_Iphone_12Mini:iCommunication{
      public  void TextMessaging(string content)
      {
            //Text message gaon vali bandi ko, bandi set
      }

    public  void WhatsappText(string content)
      {
            //WhatsappText gaon vali bandi ko,bandi set
      }


     public  void VideoCall(string content)
      {
            //VideoCall gaon vali bandi ko,bandi set

      }
}

class Emran_Ka_Nokia_1100:iCommunication{
      public  void TextMessaging(string content)
      {
            //Text message sent still he is single.
      }

    public  void WhatsappText(string content)
      {
            //phone me feature hi nahi hai
            //PROBLEM:-this class can not implement this feature
      }


     public  void VideoCall(string content)
      {
            //phone me feature hi nahi hai
            //PROBLEM:-this class can not implement this feature


      }
}

/* PROBLEM:-Don't make a big interface otherwise class which is 
implementing that need to forcefully implement all methods (BAD PRACTICE) */


//----------CASE:2-----SMALL INTERFACES--------------------
    interface iTextMessage
    {
        void TextMessaging(string content);
    }

    interface iWhatsupText
    {
        void WhatsappText(string content);
    }

    interface iVideocall
    {
        void VideoCall(string content);
    }

    class Ajeet_Ka_Iphone_12Mini : iTextMessage, iWhatsupText, iVideocall
    {
        public void TextMessaging(string content)
        {
            //Text message gaon vali bandi ko, bandi set
        }
        public void WhatsappText(string content)
        {
            //WhatsappText gaon vali bandi ko,bandi set
        }
        public void VideoCall(string content)
        {
            //VideoCall gaon vali bandi ko,bandi set
        }
    }

    class Emran_Ka_Nokia_1100 : iTextMessage
    {
        public void TextMessaging(string content)
        {
            //Finally iski bhi set ho gai
        }
    }
}

//NOTE:-Small interfaces are better than Large interfaces