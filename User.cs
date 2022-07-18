namespace ConsoleApp26
{
    internal class User
    {

        private static int id;
        public int PublicId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string NotRobotCode { get; set; }

        public Regist RegistirationMounth { get; set; }


        public User(string name, string surname, string notRobotCode, Regist registirationMounth)
        {
            id++;
            PublicId = id;
            Name = name;
            Surname = surname;
            NotRobotCode = notRobotCode;
            RegistirationMounth = registirationMounth;
        }
        public enum Regist
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


        public string GetDetails()
        {

            if (NotRobotCode.ChekNotRobotCode())
            {
                return $"{PublicId},{Name},{Surname},{RegistirationMounth},{NotRobotCode}";
            }
            else
            {
                return $"{PublicId},{Name},{Surname},{RegistirationMounth},not robot code is not correct";
            }

            //switch ( registirationmounth )
            //{
            //    case (int)Regist.Yanvar:
            //        Console.WriteLine("Yanvar");
            //        break;
            //    case (int)Regist.Fevral:
            //        Console.WriteLine("Fevral");
            //            break;
            //    case (int)Regist.Mart:
            //        Console.WriteLine("Mart");
            //        break ;
            //    case (int)Regist.Aprel:
            //        Console.WriteLine("Aprel");
            //            break;
            //    case (int)Regist.May:
            //       Console.WriteLine("May");
            //        break;
            //    case (int)Regist.Iyun:
            //        Console.WriteLine("Iyun");
            //        break;
            //    case (int)Regist.Iyul:    
            //        Console.WriteLine("Iyul");
            //        break;
            //    case (int)Regist.Avqust:
            //        Console.WriteLine("Avqust");
            //        break;
            //    case (int)Regist.Sentiyabr:
            //        Console.WriteLine("Setiyabr");
            //        break;
            //        Console.WriteLine("Noyabr");
            //        break;
            //    case (int)Regist.Dekabr:
            //        Console.WriteLine("Dekabr");
            //        break;
            //        default:
            //        Console.WriteLine("Not Correct");
            //        break;
            //Console.WriteLine($"PublicId:{PublicId} name:{Name} surname:{Surname} RegistirationMonth:{registirationmounth}");









        }
    }
}

        
  

