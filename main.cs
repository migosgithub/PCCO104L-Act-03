using System;

class Program {
  public static void Main (string[] args) {
    string text;

    do
    {
        Console.WriteLine("Enter Something: ");
        text = Console.ReadLine();
        Console.WriteLine(text);
    } while (text != "exit");

    Console.WriteLine("Closing Program...");

  }
}