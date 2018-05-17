using DocumentFactory.Documents;
using DocumentFactory.Pages.Report;
using DocumentFactory.Pages.Resume;
using System;

namespace DocumentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume = new Resume();

            #region Resume Demo
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Resume Pages:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine(resume.MakePage(nameof(CoverLetter)));
            Console.WriteLine();
            Console.Write("Please press any key to proceed to the next page...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(resume.MakePage(nameof(Education)));
            Console.WriteLine();
            Console.Write("Please press any key to proceed to the next page...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(resume.MakePage(nameof(Experience)));
            Console.WriteLine();
            Console.Write("Please press any key to proceed to the next page...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(resume.MakePage(nameof(References)));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Please press any key to proceed to the report...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            Report report = new Report();

            #region Report Demo
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Report Pages:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine(report.MakePage(nameof(CoverSheet)));
            Console.WriteLine();
            Console.Write("Please press any key to proceed to the next page...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(report.MakePage(nameof(Abstract)));
            Console.WriteLine();
            Console.Write("Please press any key to proceed to the next page...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(report.MakePage(nameof(Body)));
            Console.WriteLine();
            Console.Write("Please press any key to proceed to the next page...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(report.MakePage(nameof(WorksCited)));
            Console.WriteLine();
            #endregion

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Please press any key to exit this demonstation...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
