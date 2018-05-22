using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        private static DirectoryInfo CreateDir(string path)
        {
            DirectoryInfo dirTemp = new DirectoryInfo(path);
            dirTemp.Create();
            return dirTemp;
        }

        static void Main(string[] args)
        {
            CreateDir(@"C:\temp");



            var dirTempK1  = CreateDir(@"C:\temp\К1");
            string patht1 = Path.Combine(dirTempK1.FullName, "t1.txt");



            FileInfo fiT1 = new FileInfo(patht1);
            FileStream fileT1 = fiT1.Create();
            fileT1.Close();

            StreamWriter writerT1 = new StreamWriter(patht1);
            writerT1.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            writerT1.Close();

            string patht2 = Path.Combine(dirTempK1.FullName, "t2.txt");

            FileInfo fiT2 = new FileInfo(patht2);
            FileStream fileT2 = fiT2.Create();
            fileT2.Close();

            StreamWriter writerT2 = new StreamWriter(patht2);
            writerT2.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            writerT2.Close();


            var dirTempK2 = CreateDir(@"C:\temp\К2");
            string patht3 = Path.Combine(dirTempK2.FullName, "t3.txt");

            FileStream fileT11 = fiT1.Open(FileMode.Open);

            FileInfo fiT3 = new FileInfo(patht3);
            FileStream fileT3 = fiT3.Create();
            StreamReader readerT1 = new StreamReader(fileT11);
            StreamReader readerT2 = new StreamReader(fileT11);
            StreamWriter writerT3 = new StreamWriter(fileT3);
            writerT3.Write(readerT1.ReadToEnd());
            writerT3.Write(readerT2.ReadToEnd());
            readerT1.Close();
            readerT2.Close();
            writerT3.Close();
            fileT3.Close();
            fileT11.Close();


            Console.WriteLine(patht1);
            Console.WriteLine(patht2);
            Console.WriteLine(patht3);


            FileStream fileT22 = fiT2.Open(FileMode.Open);

            fiT2.MoveTo(@"C:\temp\К2\t2");
            fiT1.CopyTo(@"C:\temp\К2\t1");



            dirTempK1.Delete();


            //dirTempK2.FullName = "ALL";

            System.IO.Directory.Move(@"C:\temp\К2", @"C:\temp\ALL");

 


        }
    }
}
