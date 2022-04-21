using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Item> list = new List<Item>();
            string filename = Directory.GetCurrentDirectory() + "\\file2.txt";
            File.Create(filename).Close();

            string path = @"C:\Users\Lenovo\Desktop\ЛАБА_6\Задание_3\bin\Debug\net5.0\проверка.txt";

            using (StreamReader sr = new StreamReader(path))
            {            
                using (StreamWriter Bread = new StreamWriter(File.Open(filename, FileMode.OpenOrCreate)))
                {
                    string[] Sr = sr.ReadLine().Split();
                    for (int i = 0; i < Sr.Length; i++)
                    {
                        string value = String.Concat<string>(Sr);
                        int length = value.Length;
                        
                        //Bread.WriteLine(Sr[i]); 
                        Console.WriteLine(Sr[i]);
                        
                        Bread.Write(new String('*', length));
                    }
                    
                }
                
            }
           
        }
    }
}
