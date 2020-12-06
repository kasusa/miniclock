using Newtonsoft.Json;
using System;
using miniclock.Properties;
using System.Drawing;
using System.IO;

using System.Windows.Forms;
using System.Collections.Generic;

namespace miniclock
{

    public partial class Form1 : Form
    {
        LinkedList<Color> colors = new LinkedList<Color>();
        int Twidth = 50; //发现在不同dpi下有显示不全的问题。所以弄一个这个，要改成可以调节的。

        Color defbackground;
        Color transparent = Color.Navy;
        int mactype_w = 50; //这个变量是用来治疗mactype导致自己渲染之后显示不全的问题的
        private void Form1_Load(object sender, EventArgs e)
        {
            Twidth = Settings.Default.width;
            label1.Width = Twidth;
            int position = Settings.Default.position;        //位置 0--top right , 1--top left
            if (position==1)
            {
                topLeftToolStripMenuItem.PerformClick();
            }
            
            Load_hacker_style();//恢复底色
            label1.ForeColor = Settings.Default.theme_color; //恢复文本颜色
        }

        public Form1()
        {
            // 做这些是randomcolor用到的颜色
            colors.AddLast(Color.Aqua);
            colors.AddLast(Color.PowderBlue);
            colors.AddLast(Color.Plum);
            colors.AddLast(Color.Gold);
            colors.AddLast(Color.DarkOrange);
            colors.AddLast(Color.Chartreuse);
            colors.AddLast(Color.Pink);
            colors.AddLast(Color.GreenYellow);

            this.ShowInTaskbar = false;//这个程序将不会显示在任务栏
            InitializeComponent();
            defbackground = Color.WhiteSmoke; //保存一下初始的那个背景颜色，因为打字打不出来

            timer1.Interval = 10000; //10s one tick timer
            timer1.Tick += new EventHandler(gettime); //ontick event
            timer1.Start();
            label1.Text = System.DateTime.Now.ToShortTimeString(); // init time


            this.Width = 99;
            this.Height = 18;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - mactype_w, -1);//显示在右上角
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

        //close button
        private void aDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=P432z8q9iVE 关于存储设置的教程
            Settings.Default.Save();
            this.Close();
        }

        //next theme button
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //更换文字颜色
            //http://www.flounder.com/csharp_color_table.htm 一些c#颜色
            Color foreColoNext;
            
            foreColoNext = colors.First.Value;
            LinkedListNode<Color> a = colors.First;
            colors.Remove(colors.First);
            colors.AddLast(a);
            label1.ForeColor = foreColoNext;
            //随机的时候使用的范围是0~color的长度

            Settings.Default.theme_color = foreColoNext; //存储一下
            Settings.Default.Save();
        }
        //load hacker style function
        private void Load_hacker_style()
        {
            if (Settings.Default.hacker_style == true)
            {
                label1.BackColor = Color.Black;
                label1.ForeColor = Settings.Default.theme_color; //文本颜色

                Settings.Default.hacker_style = true; //存储一下
            }

            if (Settings.Default.hacker_style == false)
            {
                label1.BackColor = defbackground;
                label1.ForeColor = Color.Black;
                Settings.Default.hacker_style = false; //存储一下
            }
        }
        //change hacker style button
        private void hacker_styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //我称之为骇客模式,其实就是把背景颜色变成纯黑
            if (Settings.Default.hacker_style==false)
            {
                label1.BackColor = Color.Black;
                label1.ForeColor = Color.White; //文本颜色
                Settings.Default.theme_color = Color.White;

                Settings.Default.hacker_style = true; //存储一下
            }

            else if (Settings.Default.hacker_style==true)
            {
                label1.BackColor = defbackground;
                label1.ForeColor = Color.Black;
                Settings.Default.theme_color = Color.Black;
                Settings.Default.hacker_style = false; //存储一下
            }
            Settings.Default.Save();
        }
        //position -topleft
        private void topLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Location = new Point(-3, -1);//显示在zuo上角
            Settings.Default.position=1 ;        //位置 0--top right , 1--top left
            Settings.Default.Save();
        }

        //position -topright
        private void topRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - mactype_w, -1);//显示在右上角
            Settings.Default.position = 0;        //位置 0--top right , 1--top left
            Settings.Default.Save();
        }

        //help
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

        //新增了不显示在 alt tab 菜单和 Taskbar的代码(话说原来就不显示在taskbar,但是忘记自己在哪里设置得了)
        //让 alttab菜单更加不杂乱一些.
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_APPWINDOW = 0x40000;
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= (~WS_EX_APPWINDOW);    // 不显示在TaskBar
                cp.ExStyle |= WS_EX_TOOLWINDOW;      // 不显示在Alt+Tab
                return cp;
            }
        }
        //width -
        private void widthSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Width <= 400)
            {
                Twidth -= 2;

                label1.Width = Twidth;
            }
            Settings.Default.width = Twidth;        //位置 0--top right , 1--top left
            Settings.Default.Save();
        }

        //width +
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Width >= 10)
            {
                Twidth += 2;

                label1.Width = Twidth;
            }
            Settings.Default.width = Twidth;        //位置 0--top right , 1--top left
            Settings.Default.Save();
        }
    }
}
