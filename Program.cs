using System;
using System.Collections.Generic;
using System.IO;


namespace тренировка_или_самообман_
{
    class Program
    {

        public struct Item
        {
            public int Integers;

            public Item(int integers)
            {
                this.Integers = integers;
            }
            public void Print()
            {
                Console.WriteLine($"|{this.Integers,-3}|");
            }
        }
        static string filename = Directory.GetCurrentDirectory() + "\\lab6.txt";
        static string filename2 = Directory.GetCurrentDirectory() + "\\2_lab6.txt";
        static void Main(string[] args)
        {
            List<int> list2 = new List<int>();
            List<Item> list = new List<Item>();
            
                 int n = 50;
                 for (int i = 3; i < n; i++)
                 {
                       int integers = i += 4;

                       Console.WriteLine($"|{i}|");
                       Console.WriteLine(new String('=', 5));
                       list.Add(new Item(integers));
                 }

            using (StreamReader streamreader = new StreamReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                while (streamreader.Peek() > -1)
                {
                    string[] array = streamreader.ReadLine().Split();

                    int integers = int.Parse(array[0]);

                    list.Add(new Item(integers));
                }
            }
            
            string empty = null;
                  File.WriteAllText(filename, empty);
                  for (int j = 0; j < list.Count; j++)
                  {
                        using (StreamWriter streamwriter = new StreamWriter(File.Open(filename, FileMode.Append)))
                        {
                          //streamwriter.WriteLine($"|{list[j].Integers,-3}|");
                           streamwriter.WriteLine(list[j].Integers);
                        }
                  }

            read(list2);
            writeInNewFile(list2);
        }
        static void read(List<int> list2) {

            using (StreamReader reader = new StreamReader(File.Open(filename, FileMode.Open)))
            {
                while (reader.Peek() > -1)
                {
                    string[] SchitannayzString = reader.ReadLine().Split();

                    list2.Add(int.Parse(SchitannayzString[0]));
                    //list2.Add(int.Parse(SchitannayzString[7]));

                }
            }

            //string[] FileName = File.ReadAllLines(filename);
            //list2.Add(int.Parse(FileName[3]));
        }
        static void writeInNewFile(List<int> list2)
        {
            using (StreamWriter Bread = new StreamWriter(File.Open(filename2, FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    if (i.Equals(3) || i.Equals(7))
                    {
                        Bread.Write($"|{list2[i],-3}|");
                    }
                }


            }
        }
    }


}

