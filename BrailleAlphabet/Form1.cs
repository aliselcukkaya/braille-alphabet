using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace BrailleAlphabet
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            pictureBox34.Image = Properties.Resources.a;
            pictureBox35.Image = Properties.Resources.b;
            pictureBox36.Image = Properties.Resources.c;
            pictureBox37.Image = Properties.Resources.d;
            pictureBox38.Image = Properties.Resources.e;
            pictureBox39.Image = Properties.Resources.f;
            pictureBox40.Image = Properties.Resources.g;
            pictureBox41.Image = Properties.Resources.h;
            pictureBox42.Image = Properties.Resources.i;
            pictureBox43.Image = Properties.Resources.j;
            pictureBox44.Image = Properties.Resources.k;
            pictureBox45.Image = Properties.Resources.l;
            pictureBox46.Image = Properties.Resources.m;
            pictureBox47.Image = Properties.Resources.n;
            pictureBox48.Image = Properties.Resources.o;
            pictureBox49.Image = Properties.Resources.p;
            pictureBox50.Image = Properties.Resources.q;
            pictureBox51.Image = Properties.Resources.r;
            pictureBox52.Image = Properties.Resources.s;
            pictureBox53.Image = Properties.Resources.t;
            pictureBox54.Image = Properties.Resources.u;
            pictureBox55.Image = Properties.Resources.v;
            pictureBox56.Image = Properties.Resources.w;
            pictureBox57.Image = Properties.Resources.x;
            pictureBox58.Image = Properties.Resources.y;
            pictureBox59.Image = Properties.Resources.z;
            pictureBox60.Image = Properties.Resources._0;
            pictureBox61.Image = Properties.Resources._1;
            pictureBox62.Image = Properties.Resources._2;
            pictureBox63.Image = Properties.Resources._3;
            pictureBox64.Image = Properties.Resources._4;
            pictureBox65.Image = Properties.Resources._5;
            pictureBox66.Image = Properties.Resources._6;
            pictureBox67.Image = Properties.Resources._7;
            pictureBox68.Image = Properties.Resources._8;
            pictureBox69.Image = Properties.Resources._9;

            panel1.Visible = false;
            panel2.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
        }

        private void translateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counter = 1;
            foreach (PictureBox pbox in Controls.OfType<PictureBox>())
            {
                if (counter < 34)
                {
                    pbox.Image = null;
                }
                counter++;
            }
            

            panel1.Visible = true;
            panel2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;

            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 1;
            foreach (PictureBox pbox in Controls.OfType<PictureBox>())
            {
                if (counter < 34)
                {
                    pbox.Image = null;
                }
                counter++;
            }

            string s = textBox1.Text;
            List<string> list = new List<string>();
            foreach (char item in s)
            {
                list.Add(item.ToString());
            }
            

            System.Collections.IList myList = panel1.Controls;
            for (int i = 0; i < list.Count; i++)
            {
                PictureBox item = (PictureBox)myList[i+1];
                if (list[i] == "a")
                {
                    item.Image = Properties.Resources.a;
                    
                }
                if (list[i] == "b")
                {
                    item.Image = Properties.Resources.b;
                    
                }
                if (list[i] == "c")
                {
                    item.Image = Properties.Resources.c;
                    
                }
                if (list[i] == "d")
                {
                    item.Image = Properties.Resources.d;
                    
                }
                if (list[i] == "e")
                {
                    item.Image = Properties.Resources.e;
                    
                }
                if (list[i] == "f")
                {
                    item.Image = Properties.Resources.f;
                    
                }
                if (list[i] == "g")
                {
                    item.Image = Properties.Resources.g;
                    
                }
                if (list[i] == "h")
                {
                    item.Image = Properties.Resources.h;

                }
                if (list[i] == "i")
                {
                    item.Image = Properties.Resources.i;

                }
                if (list[i] == "j")
                {
                    item.Image = Properties.Resources.j;

                }
                if (list[i] == "k")
                {
                    item.Image = Properties.Resources.k;

                }
                if (list[i] == "l")
                {
                    item.Image = Properties.Resources.l;

                }
                if (list[i] == "m")
                {
                    item.Image = Properties.Resources.m;

                }
                if (list[i] == "n")
                {
                    item.Image = Properties.Resources.n;

                }
                if (list[i] == "o")
                {
                    item.Image = Properties.Resources.o;

                }
                if (list[i] == "p")
                {
                    item.Image = Properties.Resources.p;

                }
                if (list[i] == "q")
                {
                    item.Image = Properties.Resources.q;

                }
                if (list[i] == "r")
                {
                    item.Image = Properties.Resources.r;

                }
                if (list[i] == "s")
                {
                    item.Image = Properties.Resources.s;

                }
                if (list[i] == "t")
                {
                    item.Image = Properties.Resources.t;

                }
                if (list[i] == "u")
                {
                    item.Image = Properties.Resources.u;

                }
                if (list[i] == "v")
                {
                    item.Image = Properties.Resources.v;

                }
                if (list[i] == "w")
                {
                    item.Image = Properties.Resources.w;

                }
                if (list[i] == "x")
                {
                    item.Image = Properties.Resources.x;

                }
                if (list[i] == "y")
                {
                    item.Image = Properties.Resources.y;

                }
                if (list[i] == "z")
                {
                    item.Image = Properties.Resources.z;

                }
                if (list[i] == "0")
                {
                    item.Image = Properties.Resources._0;

                }
                if (list[i] == "1")
                {
                    item.Image = Properties.Resources._1;

                }
                if (list[i] == "2")
                {
                    item.Image = Properties.Resources._2;

                }
                if (list[i] == "3")
                {
                    item.Image = Properties.Resources._3;

                }
                if (list[i] == "4")
                {
                    item.Image = Properties.Resources._4;

                }
                if (list[i] == "5")
                {
                    item.Image = Properties.Resources._5;

                }
                if (list[i] == "6")
                {
                    item.Image = Properties.Resources._6;

                }
                if (list[i] == "7")
                {
                    item.Image = Properties.Resources._7;

                }
                if (list[i] == "8")
                {
                    item.Image = Properties.Resources._8;

                }
                if (list[i] == "9")
                {
                    item.Image = Properties.Resources._9;

                }




            }
        }
    }
}
