using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Math;
using AForge;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Hist hist;
        bool isConverted;
        string ppath;

        public Form1()
        {
            InitializeComponent();
            hist = new Hist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image" + "(*.jpg,*.jpeg,*.png)|" +
                                    "*.jpg;*.jpeg;*.png";
                openFile.FilterIndex = 2;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fname = openFile.FileName;
                        ppath = fname;
                        //printImage(fname);
                        Original.Image = new Bitmap(fname);
                    }
                    catch { }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //histogram.Image = hist.histogramEqualization((Bitmap)Original.Image);
            //histogram.Image = printImage(ppath);
            printImage(ppath);
        }

        private void printImage(string path)
        {
            Bitmap target = new Bitmap(path);
            HorizontalIntensityStatistics hos = new HorizontalIntensityStatistics(target);
            Histogram histo = hos.Blue;

            Bitmap result = new Bitmap(1300, 750);

            int[] temp = histo.Values;

            for (int x = 0; x < temp.Length; x++)
            {
                for (int y = 0; y < 500; y++)
                {
                    if (y < temp[x]/temp.Length)
                    {
                        result.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        result.SetPixel(x, y, Color.White);
                    }
                }
            }

            result.Save(@"C:\Users\응딩이\Desktop\TestPixel.bmp");
        }
    }
}
