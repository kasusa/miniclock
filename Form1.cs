using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniclock
{
    public partial class Form1 : Form
    {
        Color defbackground;
        int mactype_w = 50; //这个变量是用来治疗mactype导致自己渲染之后显示不全的问题的
        public Form1()
        {
            this.ShowInTaskbar = false;//这个程序将不会显示在任务栏
            InitializeComponent();
            defbackground = label1.BackColor; //保存一下初始的那个背景颜色，因为打字打不出来

            timer1.Interval = 10000; //10s one tick timer
            timer1.Tick += new EventHandler(gettime); //ontick event
            timer1.Start();
            label1.Text = System.DateTime.Now.ToShortTimeString(); // init time


            this.Width = 55;
            this.Height = 18;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - mactype_w, 0);//显示在右上角
        }

        private void gettime(Object myObject,EventArgs myEventArgs)
        {
            DateTime now = System.DateTime.Now;
            label1.Text = now.ToShortTimeString();
            //label1.Text = now.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //this.Close();
            contextMenuStrip1.Show(Cursor.Position);//在鼠标位置显示一个菜单
        }

        //菜单中的关闭按钮
        private void aDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //更换主题,实际上就是从下面的数组里面,随机一个颜色换到字符上
            //http://www.flounder.com/csharp_color_table.htm
            Color foreColorNow = label1.ForeColor;
            Color[] colors = 
                { Color.Aqua
                    , Color.PowderBlue
                    , Color.Plum
                    , Color.Gold
                    , Color.DarkOrange
                    , Color.Chartreuse
            };
            ;
            label1.ForeColor = colors[new Random().Next(0, colors.Length)];
            //随机的时候使用的范围是0~color的长度

            if (label1.ForeColor==foreColorNow)//为了保证使用的体验，如果随机到了和当前同样的颜色，要把这个颜色改掉
                label1.ForeColor = colors[new Random().Next(0, colors.Length)];

        }

        private void hacker_styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //我称之为骇客模式,其实就是把背景颜色变成纯黑
            if (label1.BackColor==defbackground)
                label1.BackColor = Color.Black;
            else
                label1.BackColor = defbackground;

        }

        private void topLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);//显示在zuo上角

        }

        private void topRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - mactype_w, 0);//显示在右上角

        }

        private void biggersizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("" +
                "假如时间显示不全，请调整你的DPI设置\n"+
                "属性-兼容性-更改高dpI设置-高DPI缩放执行-应用程序\n" +
                "然后重新启动应用\n---------\n" +
                "If the time display is incomplete, adjust your DPI Settings \n" +
                "Attribute - compatibility - change high dpI Settings - high dpI zoom ,select application \n" +
                "And then restart the application.");
        }
    }
}
