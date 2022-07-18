using System;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 =  new User("Adil","Suleymanov","T7H7",User.Regist.Iyul);
            Console.WriteLine(user1.GetDetails());
            User user = new User("Sahil","Memmedov","asda1", User.Regist.Avqust);
            Console.WriteLine(user.GetDetails());
           

            
        }
    }
}
