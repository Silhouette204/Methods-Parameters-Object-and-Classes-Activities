using System;

namespace MPOCBankChallenge 
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int id, age;
           String name, location;

            Console.WriteLine("Enter your ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Location: ");
            location = Console.ReadLine();
            
            Withdepo money = new Withdepo();
            Console.WriteLine(money.moneyVal(id));
            money.enterVal(id);

            clientInfo info = new clientInfo();

            info.employeeInfo(id, name, age, location);


        }
    }
}
