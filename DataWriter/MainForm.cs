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
using System.Windows.Forms;

namespace DataWriter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image = new TextDrawer().DrawText(textBox1.Text, new Font("Tiny Fonts", 4, GraphicsUnit.Point), Color.Black, Color.White);
            image.Save("image.bmp");
            pictureBox1.Image = image;
        }

        
    }
}
