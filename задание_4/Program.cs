using System;
using System.IO;


namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Lenovo\Desktop\ЛАБА_6\Lab6_Temp";
            string filename = path + "\\lab6.txt";
            string FileTemp = path + "\\lab_backup.txt";
            Directory.CreateDirectory(path);
            
            File.Copy(@"C:\Users\Lenovo\Desktop\ЛАБА_6\ЛАБА_6\bin\Debug\net5.0\lab6.txt",filename);
            using (StreamReader sr = new StreamReader(filename)) {
                string s = sr.ReadToEnd();
                using (FileStream fs = new FileStream(FileTemp, FileMode.OpenOrCreate))
                        {
                    byte[] arr = System.Text.Encoding.Default.GetBytes(s);
                    fs.Write(arr, 0, arr.Length);
                    
                }
                
            }
            string line = new string('-', 55);
            Console.WriteLine("Информация о файле");
            Console.WriteLine(line + '|');
            Console.WriteLine("Размер файла: " + new FileInfo(filename).Length);
            Console.WriteLine(line + '|');
            Console.WriteLine("Время последнего изменения: " + File.GetLastWriteTime(filename));
            Console.WriteLine(line + '|');
            Console.WriteLine("Время последнего доступа к файлу: " + File.GetLastAccessTime(filename));
            Console.WriteLine(line + '|');

        }
    }
}
