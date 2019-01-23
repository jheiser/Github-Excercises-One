using System;

class MainClass {
  public static void Main (string[] args) {
    string mileString;
    double mile;
    string gasString;
    int gas;
    double mpg;

    Console.WriteLine ("Enter the amount of miles you've driven:");
    mileString = Console.ReadLine();
    mile = Convert.ToDouble(mileString);

    Console.WriteLine ("Enter the amount of gas you've used (in gallons)");
    gasString = Console.ReadLine();
    gas = Convert.ToInt32(gasString);

    mpg = mile / gas;

    Console.WriteLine ("Your MPG is: " + mpg);
  }
}