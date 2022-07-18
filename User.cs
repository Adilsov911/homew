using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class user
    {

        public int id { get; set; }
        public int PublicId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string NotRobotCode { get; set; }

        public int RegistirationMonth { get; set; }

        
        public void GetDetails(int publicid ,string name , string surname , int registirationmounth )
        {
            Name = name;
            Surname = surname;
            registirationmounth = 1;
            
            id++;
            PublicId = id;
            switch ( registirationmounth )
            {
                case (int)Regist.Yanvar:
                    Console.WriteLine("Yanvar");
                    break;
                case (int)Regist.Fevral:
                    Console.WriteLine("Fevral");
                        break;
                case (int)Regist.Mart:
                    Console.WriteLine("Mart");
                    break ;
                case (int)Regist.Aprel:
                    Console.WriteLine("Aprel");
                        break;
                case (int)Regist.May:
                   Console.WriteLine("May");
                    break;
                case (int)Regist.Iyun:
                    Console.WriteLine("Iyun");
                    break;
                case (int)Regist.Iyul:    
                    Console.WriteLine("Iyul");
                    break;
                case (int)Regist.Avqust:
                    Console.WriteLine("Avqust");
                    break;
                case (int)Regist.Sentiyabr:
                    Console.WriteLine("Setiyabr");
                    break;
                    Console.WriteLine("Noyabr");
                    break;
                case (int)Regist.Dekabr:
                    Console.WriteLine("Dekabr");
                    break;
                    default:
                    Console.WriteLine("Not Correct");
                    break;
            Console.WriteLine($"PublicId:{PublicId} name:{Name} surname:{Surname} RegistirationMonth:{registirationmounth}");
                

            }




        }
        enum Regist
        {
            Yanvar = 1,
            Fevral,
            Mart,
            Aprel,
            May,
            Iyun,
            Iyul,
            Avqust,
            Sentiyabr,
            Oktyabr,
            Noyabr,
            Dekabr


        }
    }
  
}
