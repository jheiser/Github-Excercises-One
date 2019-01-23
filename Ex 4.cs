using System;

class MainClass {
  public static void Main (string[] args) {
    string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation'?";
    string input;

    Console.WriteLine ("Please search for a term:");
    input = Console.ReadLine();

    if(alice.Contains(input))
    {
      Console.WriteLine("It does.");
    }

    else
    {
      Console.WriteLine("It does not.");
    }
  }
}