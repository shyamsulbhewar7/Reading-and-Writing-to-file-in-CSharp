using System;
using System.IO;

namespace ReadingAndWritingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
        }
        static void CaseStudy1()// only reading from files
        {
            string text1 = File.ReadAllText(@"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\file1.html");
            Console.WriteLine("Contents of first file(html) are " + text1);
            string text2 = File.ReadAllText(@"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\file2.xml");
            Console.WriteLine("--------------------------------------------------------------\nContents of second file(xml) are " + text2);
            string text3 = File.ReadAllText(@"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\file3.txt");
            Console.WriteLine("--------------------------------------------------------------\nContents of third file(text) are " + text3);

        }
        static void CaseStudy2()// reading and writing to files
        {
            string text1 = "Never give up" + "\n keep going , keep fighting";
            File.WriteAllText(@"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\sample1.txt",text1);
            string text2 = File.ReadAllText(@"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\file2.xml");
            File.WriteAllText(@"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\sample2.xml", text2);
            string text3 = File.ReadAllText(@"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\file1.html");
            File.WriteAllText(@"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\sample3.html", text3);        
        }
        static void CaseStudy3()// appending data to files
        {
            string input;
            string filepath = @"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\data.txt";
            Console.WriteLine("Enter data/username to write in file");
            input = Console.ReadLine();
            File.AppendAllText(filepath, input + "\n");
            string text = File.ReadAllText(@"C:\Users\DELL\Desktop\SwabhavTechLab\Assignment\Files Read and Write\ReadingAndWritingFiles\data.txt");           
            Console.WriteLine("after appending Content of file is  \n" + text);
        }
    }
}
