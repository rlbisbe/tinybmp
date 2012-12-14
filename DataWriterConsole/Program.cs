using DataWriterLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWriterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                return;
            }
            Image image = new TextDrawer().DrawText(args[0], new Font("Tiny Fonts", 4, GraphicsUnit.Point), Color.Black, Color.White);
            image.Save(args[1]);
        }
    }
}
