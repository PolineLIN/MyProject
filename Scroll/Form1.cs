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
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            //將Form1設定成容器
            this.IsMdiContainer = true;
            //將Form1最大化
            this.WindowState = FormWindowState.Maximized;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //建立一個新Form2物件
            form2 = new Form2(this);
            //將Form2放在Form1內
            form2.MdiParent = this;
            form2.Show();
        }
        public void SetValue(Point P1, Point P2)
        {
            toolStripStatusLabel1.Text = "AutoScrollPosition = " + P1.ToString();
            toolStripStatusLabel2.Text = "ScrollPosition = " + P2.ToString();
        }
    }
}
