using System;

namespace MainActionsSmoke.Rename
{
    public class RenameMe
    {
        void TestMethod()
        {
            Console.Write("Enter a Number : ");
            var i = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write(i % 2 == 0 ? "Entered Number is an Even Number" : "Entered Number is an Odd Number");
        }
    }
}