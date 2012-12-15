using DataWriterLib;
using System;
using System.Drawing;
using System.IO;

namespace DataWriterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!HaveCorrectArguments(args))
                return;

            GenerateImage(args[0],args[1]);
        }

        private static void GenerateImage(string text, string filename)
        {
            Console.WriteLine("Saving string: " + text + "\n");
            Image image = new TextDrawer().DrawText(text,
                new Font("Tiny Fonts", 4, GraphicsUnit.Point),
                Color.Black, Color.White);

            image.Save(filename);
            Console.WriteLine("String saved in: \n" +
                Directory.GetCurrentDirectory() + "\\" + filename);
        }

        private static bool HaveCorrectArguments(string[] args)
        {
            if (args.Length == 2)
                return true;

            Console.WriteLine("\nUsage: DataWriterConsole.exe " +
                "Number Output_file\n\n- " +
                "Number: Numbers and dots\n- " +
                "Output_file: Filename with bmp extension");
            return false;
        }
    }
}
