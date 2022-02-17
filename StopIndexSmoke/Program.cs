using System;
using System.IO;
using System.Text;

namespace StopIndexSmoke
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TODO: check file generation to non-indexed folders
            // 1. Specify the path to the file to be created
            // 2. Give it a name
            // 3. Run the StopIndexSmoke app
            string file = @"..\ProjectModelSmoke\StopIndexSmoke\GeneratorOutput\test2.txt";

            using (FileStream fs = File.Create(file))
            {
                Byte[] message = new UTF8Encoding(true).GetBytes("Message");
                fs.Write(message, 0, message.Length);
                fs.Close();
            }
            
            Console.WriteLine("The file was generated successfully!");
        }
    }
}