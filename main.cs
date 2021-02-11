using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter sales amount");
    double sales = Convert.ToDouble(Console.ReadLine());
    double commission = 200+.09*sales;
    string status;
    if (sales < 3000)
      status = "poor";
    else if (sales<5000)
      status = "average";
    else if (sales <10000)
      status = "good";
    else if (sales< 15000)
      status = "excellent";
    else
      status = "outstanding";
    Console.WriteLine("Sales commission for "+name+ " is $"+commission);
    Console.WriteLine("Performance is "+status);
}
}