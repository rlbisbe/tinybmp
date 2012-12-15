using DataWriterLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataWriter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            image = new TextDrawer().DrawText(textBox1.Text, new Font("Tiny Fonts", 4, GraphicsUnit.Point), Color.Black, Color.White);
            pictureBox1.Image = image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName == "")
                return;

            image.Save(saveFileDialog.FileName);
            MessageBox.Show("Image saved");
        }

        private Image image;
    }
}
