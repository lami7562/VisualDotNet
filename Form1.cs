using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;

namespace encFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // ZipFile zi = new ZipFile(@"D:\zip c#\testzip");
            ZipFile.ExtractToDirectory(@"D:\zip c#\testzip.zip", @"D:\zip c#\testzip", UTF8Encoding.UTF8);
            

    }

        private void button2_Click(object sender, EventArgs e)
        {
            //resetpass(".\\test");
            
        }
        string status = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
        void setpass(string pathfolder)
        {
            DirectoryInfo d = new DirectoryInfo(pathfolder);
           // string selectedpath = d.Parent.FullName + "\\" + d.Name;
            d.MoveTo(d.Parent.FullName + "\\" + d.Name + status);
        }
        void resetpass(string pathfolder)
        {
            DirectoryInfo d = new DirectoryInfo(pathfolder);
            string dd = d.Parent.FullName + "\\" + d.Name + status;
            DirectoryInfo ddd = new DirectoryInfo(dd);
            File.Delete(dd + "\\p.xml");
            ddd.MoveTo(dd.Substring(0, dd.LastIndexOf(".")));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                setpass(folderBrowserDialog1.SelectedPath);
            }
        }
        

    }
}
