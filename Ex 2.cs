using System;

class MainClass {
  public static void Main (string[] args) {
    string lengthString;
    double length;
    string widthString;
    double width;
    double area;

    Console.WriteLine ("Please enter the length of the rectangle:");
    lengthString = Console.ReadLine();
    length = Convert.ToDouble(lengthString);

    Console.WriteLine ("Please enter the width of the rectangle:");
    widthString = Console.ReadLine();
    width = Convert.ToDouble(widthString);

    area = length * width;
    Console.WriteLine("The area of the rectangle is: " + area);
  }
}