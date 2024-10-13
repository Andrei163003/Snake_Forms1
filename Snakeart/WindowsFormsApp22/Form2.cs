using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form2 : Form
    {
        
        Point[] p;
        Point[] a;
        Point apple;
        Point apple2;
        Point kamen;
        Point kamen2;
        Point kamen3;
        Point kamen4;
        Point kamen5;
        int len;
        int lan, c1;
        int dir;

        public Form2()
        {
            InitializeComponent();
            len = 5;
            p = new Point[200];
            dir = 1;
            for (int i = 0; i < len; i++)
            {
                p[i].X = 250;
                p[i].Y = 250 + i * 10;
            }
            apple.X = 150;
            apple.Y = 150;
            apple2.X = 90;
            apple2.Y = 90;
            kamen.X = 500;
            kamen.Y = 500;
            kamen2.X = 500;
            kamen2.Y = 500;
            kamen3.X = 500;
            kamen3.Y = 500;
            kamen4.X = 500;
            kamen4.Y = 500;
            kamen5.X = 500;
            kamen5.Y = 500;
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            {
                typeof(Panel).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, panel1, new object[] { true });
                for (int i = 198; i >= 0; i--)
                {
                    p[i + 1].X = p[i].X;
                    p[i + 1].Y = p[i].Y;
                }
                if (dir == 0)
                {
                    menu f1 = new menu();
                    f1.Show();
                    Hide();
                }
                if (dir == 1)
                {
                    p[0].X = p[1].X;
                    p[0].Y = p[1].Y - 10;
                    if (p[0].Y < 0) p[0].Y = 490;
                }
                if (dir == 2)
                {
                    p[0].X = p[1].X;
                    p[0].Y = p[1].Y + 10;
                    if (p[0].Y > 490) p[0].Y = 0;
                }
                if (dir == 3)
                {
                    p[0].X = p[1].X - 10;
                    if (p[0].X < 0) p[0].X = 490;
                    p[0].Y = p[1].Y;
                }
                if (dir == 4)
                {
                    p[0].X = p[1].X + 10;
                    if (p[0].X > 490) p[0].X = 0;
                    p[0].Y = p[1].Y;
                }

                SolidBrush b;
                b = new SolidBrush(Color.White);
                if (c1 >= 1 && c1 < 3)
                {
                    b = new SolidBrush(Color.Green);
                }
                else if (c1 >= 3 && c1 < 5)
                {
                    b = new SolidBrush(Color.Yellow);
                }
                else if (c1 >= 5 && c1 < 7)
                {
                    b = new SolidBrush(Color.Purple);
                }
                else
                {
                    b = new SolidBrush(Color.White);
                }
                for (int i = 0; i < len; i++)
                {
                    e.Graphics.FillEllipse(b, p[i].X, p[i].Y, 10, 10);
                }
                SolidBrush b1 = new SolidBrush(Color.Red);
                e.Graphics.FillEllipse(b1, apple.X, apple.Y, 10, 10);
                SolidBrush b2 = new SolidBrush(Color.Red);
                e.Graphics.FillEllipse(b2, apple2.X, apple2.Y, 10, 10);
                SolidBrush c22 = new SolidBrush(Color.Gray);
                e.Graphics.FillEllipse(c22, kamen.X, kamen.Y, 10, 10);
                SolidBrush c23 = new SolidBrush(Color.Gray);
                e.Graphics.FillEllipse(c23, kamen2.X, kamen2.Y, 10, 10);
                SolidBrush c24 = new SolidBrush(Color.Gray);
                e.Graphics.FillEllipse(c24, kamen3.X, kamen3.Y, 10, 10);
                SolidBrush c25 = new SolidBrush(Color.Gray);
                e.Graphics.FillEllipse(c25, kamen4.X, kamen5.Y, 10, 10);
                SolidBrush c26 = new SolidBrush(Color.Gray);
                e.Graphics.FillEllipse(c26, kamen5.X, kamen5.Y, 10, 10);

                if (p[0].X == apple.X && p[0].Y == apple.Y)
                {
                    len++;
                    Random R;
                    R = new Random();
                    apple.X = R.Next(0, 50) * 10;
                    apple.Y = R.Next(0, 50) * 10;
                    c1++;
                    label1.Text = c1.ToString();
                    timer1.Interval -= 5;
                    kamen.X = R.Next(0, 50) * 10;
                    kamen.Y = R.Next(0, 50) * 10;
                    kamen2.X = R.Next(0, 50) * 10;
                    kamen2.Y = R.Next(0, 50) * 10;
                    kamen3.X = R.Next(0, 50) * 10;
                    kamen3.Y = R.Next(0, 50) * 10;
                    kamen4.X = R.Next(0, 50) * 10;
                    kamen4.Y = R.Next(0, 50) * 10;
                    kamen5.X = R.Next(0, 50) * 10;
                    kamen5.Y = R.Next(0, 50) * 10;
                    apple2.X = R.Next(0, 50) * 10;
                    apple2.Y = R.Next(0, 50) * 10;
                }
                else
                if (p[0].X == apple2.X && p[0].Y == apple2.Y)
                {
                    menu fr2 = new menu();
                    fr2.Show();
                    Hide();
                    MessageBox.Show("Вы съели гнилое яблоко. Вы проиграли!");

                }
                if (p[0].X == kamen.X && p[0].Y == kamen.Y)
                {
                    menu fr2 = new menu();
                    fr2.Show();
                    Hide();
                    MessageBox.Show("Игра окончена, вы проиграли");
                }
                if (p[0].X == kamen2.X && p[0].Y == kamen2.Y)
                {
                    menu fr2 = new menu();
                    fr2.Show();
                    Hide();
                    MessageBox.Show("Игра окончена, вы проиграли");
                }
                if (p[0].X == kamen2.X && p[0].Y == kamen2.Y)
                {
                    menu fr2 = new menu();
                    fr2.Show();
                    Hide();
                    MessageBox.Show("Игра окончена, вы проиграли");
                }
                if (p[0].X == kamen3.X && p[0].Y == kamen3.Y)
                {
                    menu fr2 = new menu();
                    fr2.Show();
                    Hide();
                    MessageBox.Show("Игра окончена, вы проиграли");
                }
                if (p[0].X == kamen4.X && p[0].Y == kamen4.Y)
                {
                    menu fr2 = new menu();
                    fr2.Show();
                    Hide();
                    MessageBox.Show("Игра окончена, вы проиграли");
                }
                if (p[0].X == kamen5.X && p[0].Y == kamen5.Y)
                {
                    menu fr2 = new menu();
                    fr2.Show();
                    Hide();
                    MessageBox.Show("Игра окончена, вы проиграли");
                }
                if (timer1.Interval <= 10)
                {
                    timer1.Interval = 250;
                }
                if (c1 >= 1000)
                {
                    menu fr2 = new menu();
                    fr2.Show();
                    Hide();
                    MessageBox.Show("игра окончена");
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                dir = 0;
            if (e.KeyCode == Keys.W)
                dir = 1;
            if (e.KeyCode == Keys.S)
                dir = 2;
            if (e.KeyCode == Keys.A)
                dir = 3;
            if (e.KeyCode == Keys.D)
                dir = 4;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
