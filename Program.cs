using System;
using System.Drawing;
using System.Drawing.Imaging;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.Error.WriteLine("Command not specified.");

            return;
        }

        switch (args[0])
        {
            case "generate":
                new Generator().Generate();
                break;
            
            case "solve":
                new Solver().Solve();
                break;
            
            default:
                Console.Error.WriteLine("Unknown command.");
                break;
        }
    }
}
