﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScreenSAver
{
    public partial class frmScSaver : Form
    {
        List<Image> BGImages = new List<Image>(); //stores the images
        List<BritPic> BritPics = new List<BritPic>(); //holds the position of each pic
        Random rand = new Random(); //will generate random numbers
        
        class BritPic
        {
            public int PicNum;
            public float X;
            public float Y;
            public float Speed;
        }
        public frmScSaver()
        {
            InitializeComponent();
        }

        private void frmScSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close(); //this tells the program to close with any key stroke
        }

        private void frmScSaver_Load(object sender, EventArgs e)
        {

            string[] images = System.IO.Directory.GetFiles("pics");

            foreach (string image in images)
            {
                BGImages.Add(new Bitmap(image));
            }

            for (int i=0; i <50;  ++i)
            {
                BritPic mp = new BritPic();
                mp.PicNum = i % BGImages.Count;

                mp.X = rand.Next(0, Width);
                mp.Y = rand.Next(0, Height);

                BritPics.Add(mp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void frmScSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPics) //generates a paint event
            {
                e.Graphics.DrawImage(BGImages[bp.PicNum], bp.X, bp.Y);
                bp.X -= 2;

                if (bp.X < -250)
                {
                    bp.X = Width + rand.Next(20, 100); 
                }
            }
        }
    }
}
