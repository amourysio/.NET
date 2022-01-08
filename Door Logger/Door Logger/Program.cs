using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Door_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictonary who take name and bool is there or not
            Dictionary<string, bool> Employees = new Dictionary<string, bool>();
            //Directory of Text File
            string filePath = @"C:\Users\Windows10\source\repos\Door Logger\Door Logger\InBuilding.txt";
            string filePath2 = @"C:\Users\Windows10\source\repos\Door Logger\Door Logger\OutOfBuilding.txt";
            //If Statment
            if (!File.Exists(filePath))
            {
                //
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    //Add Employees

                    Console.Write("Please Add Fname of Employee :");
                    sw.WriteLine(Console.ReadLine());
                    sw.WriteLine("Johny Smith");
                    sw.WriteLine("Dani Little");
                    sw.WriteLine("Keith Jonathan");
                    sw.WriteLine("Kimber Lesley");
                    //Console.Write("Please Add Fname of Employee :");
                    //Employees.(Console.ReadLine(), true);
                    //Console.Write("Please Add Fname of Employee :");
                    //Employees.Add(Console.ReadLine(), false);
                    //Console.Write("Please Add Fname of Employee :");
                    //Employees.Add(Console.ReadLine(), false);
                    //Console.Write("Please Add Fname of Employee :");
                    //Employees.Add(Console.ReadLine(), true);


                }
            }

            //Open File
            //using(StreamReader sr = File.OpenText(filePath))
            //{
            //    string s = "";
            //    while((s= sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
                   
            //    }
            //}

            Dictionary<string, string> dataDict = new Dictionary<string, string>();
            Console.Write("Enter your name: ");
            string n = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string s = Console.ReadLine();
            dataDict.Add("Name", n);
            dataDict.Add("Surname", s);
            WriteDictToFile(dataDict, filePath);




            //Dictionary<string, bool> Employees = new Dictionary<string, bool>();
            //Employees.Add(Console.ReadLine(), true);
            //Employees.Add("Anny Ivanova", false);
            //Employees.Add("Janna Moskova", false);
            //Employees.Add("John Smith", false);
            //Employees.Add("James Hench", false);
            //Console.Write("Enter Your Name : ");
            //string curr = Console.ReadLine();

            //if (Employees.ContainsKey(curr))
            //{
            //    string path =  @"C:\Users\Windows10\source\repos\Door Logger\Door Logger\Building.txt";

            //    if (Directory.Exists(path))
            //    {
            //        if (Employees[curr] == false)
            //        {
            //            Employees[curr] = true;
            //            Console.WriteLine("Successfully Entered");
            //        }
            //        else
            //        {
            //            Employees[curr] = false;
            //            Console.WriteLine("Successfully Exited");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Path");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Employee Does Not Exist");
            //}
















            //string fName;
            //string fName2;

            //Console.Write("Name of Entered Person :");
            //fName = Console.ReadLine().ToString();
            //fName2 = fName;

            //string filePath = Application.Pdf + @"C:\Users\Windows10\source\repos\Door Logger\Door Logger\Building.txt";
            ////string filePath = @"C:\Users\Windows10\source\repos\Door Logger\Door Logger\Building.txt";
            //if (!File.Exists(filePath))
            //{
            //    using (StreamWriter sw = File.CreateText(filePath))
            //    {
            //        sw.WriteLine(fName2);
            //        sw.Dispose();
            //    }
            //}

            //string line;
            //StreamReader sr = new StreamReader(filePath);
            //while ((line = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
            //Console.ReadKey();




            //string filePath = @"C:\Users\Windows10\source\repos\Door Logger\Door Logger\Building";
            //List<string> lines = new List<string>();
            //lines = File.ReadAllLines(filePath).ToList();

            //lines.Add(Console.ReadLine());
            //File.WriteAllLines(filePath, lines); 
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //////////////////
            //try
            //{
            //    string path = @"C:\Users\Windows10\source\repos\Door Logger\Door Logger\Building.txt";

            //    if (!File.Exists(path))
            //    {
            //        File.Create(path);
            //    }
            //    File.SetLastAccessTime(path, new DateTime(1985, 5, 4));

            //    // Get the creation time of a well-known directory.
            //    DateTime dt = File.GetLastAccessTime(path);
            //    Console.WriteLine("The last access time for this file was {0}.", dt);

            //    // Update the last access time.
            //    File.SetLastAccessTime(path, DateTime.Now);
            //    dt = File.GetLastAccessTime(path);
            //    Console.WriteLine("The last access time for this file was {0}.", dt);
            //}

            //catch (Exception e)
            //{
            //    Console.WriteLine("The process failed: {0}", e.ToString());
            //}
        }

        private static void WriteDictToFile(Dictionary<string, string> dataDict, string v)
        {
            throw new NotImplementedException();
        }
    }
}
