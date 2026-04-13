using System;

class Program
{
    static void Main(string[] args)
    {
        UIHelper.DisplayLogo();

        Console.Write("\nEnter your name: ");
        string name = Console.ReadLine();

        Chatbot bot = new Chatbot(name);
        bot.Start();
    }
}

