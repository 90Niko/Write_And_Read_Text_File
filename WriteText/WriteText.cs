using System;
using System.IO;

namespace WriteText
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\ngero\\OneDrive\\Dokumente\\Sample.txt", true);

                Console.WriteLine("Enter a line of text to write to the file:");
                string line = Console.ReadLine();

                sw.WriteLine(line);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
