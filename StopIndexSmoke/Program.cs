using System;
using System.IO;
using System.Text;

namespace StopIndexSmoke
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fileName = @"C:\Users\Anastasiia.Posulikhi\RiderProjects\ProjectModelSmoke\StopIndexSmoke\GeneratorOutput\test1.txt";

            using (FileStream fs = File.Create(fileName))
            {
                Byte[] message = new UTF8Encoding(true).GetBytes("Message");
                fs.Write(message, 0, message.Length);
                fs.Close();
            }
            
            Console.WriteLine("The file was generated successfully!");
        }
    }
}