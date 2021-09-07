using System;
using System.IO;
using System.Text;

namespace FilesGeneratorIntoNonIndexedFolder
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			string fileName =
				@"C:\Users\Anastasiia.Posulikhi\RiderProjects\ProjectModelSmoke\FilesGeneratorIntoNonIndexedFolder\Output\testfile25.txt";

			// Create a new file     
			using (FileStream fs = File.Create(fileName))
			{
				// Add some text to file    
				Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
				fs.Write(title, 0, title.Length);
				byte[] author = new UTF8Encoding(true).GetBytes("\nMahesh Chand");
				fs.Write(author, 0, author.Length);
			}
		}
	}
}