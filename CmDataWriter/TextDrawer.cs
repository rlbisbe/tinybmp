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


namespace DataWriterLib
{
    public class TextDrawer
    {
        public Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap(21, 7);

            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            mSpace = 1;
            foreach (var item in text.ToCharArray())
            {
                try
                {
                    PaintDigit(int.Parse(item.ToString()), drawing, textBrush);
                }
                catch (Exception)
                {
                    PaintDot(drawing, textBrush);
                }
            }

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();
            return img;
        }

        private void PaintDot(Graphics drawing, Brush textBrush)
        {
            drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 3, 1, 1);
            mSpace += 1;
        }

        private void PaintDigit(int digit, Graphics drawing, Brush textBrush)
        {
            switch (digit)
            {
                case 1:
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 3, 1, 1);
                    break;
                case 2:
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 3, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 3, 1, 1);
                    break;
                case 3:
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 3, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 3, 1, 1);
                    break;
                case 4:
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 3, 1, 1);
                    break;
                case 5:
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 3, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 3, 1, 1);
                    break;
                case 6:
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 3, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 3, 1, 1);
                    break;
                case 7:
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 3, 1, 1);
                    break;
                case 8:
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 3, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 3, 1, 1);
                    break;
                case 9:
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 3, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 3, 1, 1);
                    break;
                case 0:
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 0, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 1, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 2, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 0, hSpace + 3, 1, 1);
                    drawing.FillRectangle(textBrush, mSpace + 1, hSpace + 3, 1, 1);
                    break;
                default:
                    break;
            }
            mSpace += 3;
        }

        int mSpace = 1;
        int hSpace = 2;
    }
}
