public class Withdepo{
 public int moneyVal(int id){

    if (id == 1001){
      Console.WriteLine("Your Money Bank: ");
     return 5000; 
    }else if (id == 1002){
      Console.WriteLine("Your Money Bank: ");
     return 10000;
    }else if (id == 1003){
      Console.WriteLine("Your Money Bank: ");
     return 20000;
    } else {
      try {
      }
      catch (Exception error){
	     Console.WriteLine("Invalid ID");
}
    }
    return id;
}
  public void enterVal(int id){

    char choice;
    int amount;
    int total;

    Console.WriteLine("Choose Method");
    Console.WriteLine("W.Withdrawal  D.Deposit");
    choice = Console.ReadKey().KeyChar; 
 
    if(choice == 'W'){
    Console.WriteLine("ithdraw: ");
     Console.WriteLine("Enter amount you want to: ");
     amount = Convert.ToInt32(Console.ReadLine());

     total = moneyVal(id) + amount;
     Console.WriteLine("==========Your information==========");
     Console.WriteLine("Total Money: " + total);
     
    } else if (choice == 'D'){
      Console.WriteLine("eposit: ");
     Console.WriteLine("Enter amount you want to: ");
     amount = Convert.ToInt32(Console.ReadLine());

     total = moneyVal(id) - amount;
     Console.WriteLine("==========Your information==========");
     Console.WriteLine("Total Money: " + total);
    }
  }
}  
 