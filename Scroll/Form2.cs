using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scroll
{
    public partial class Form2 : Form
    {
        private Form1 F1;
        private int PaintCount = 0;
        private int ScrollCount = 0;

        public Form2(Form1 F1)
        {
            InitializeComponent();
            this.F1 = F1;
            this.DoubleBuffered = true;
            //this.AutoScroll = true;
            //this.AutoScrollMinSize = new Size(10000, 10000);
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            F1.SetValue(this.AutoScrollPosition, this.AutoScrollOffset);
            this.PaintCount++;
            this.Text = "Panit:" + PaintCount.ToString() + "Scroll:" + ScrollCount.ToString();
        }
        private Point ScrollP1;

        private void Form2_Scroll(object sender, ScrollEventArgs e)
        {

            this.ScrollCount++;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox1.Select(Str.Length, 1);

            this.textBox1.Text = Str;

            //this.textBox1.ScrollToCaret();
        }
        string Str = "基準點座標(@X,Y設原點/X,Y相對座標/LEN;{ANG;Y/X}角度)：";
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Str;
            this.textBox1.Select(Str.Length, 1);
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyValue.ToString());
        }
    }
}
