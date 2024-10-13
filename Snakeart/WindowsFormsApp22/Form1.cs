using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        Point[] p;
        Point[] a;
        Point apple;
        Point kamen;
        Point kamen2;
        Point kamen3;
        Point kamen4;
        Point kamen5;
        int len, lan, c1, c2, dir, dir2,dead, dead2;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            len = 5;
            p = new Point[200];
            dir = 1;
            for (int i = 0; i < len; i++)
            {
                p[i].X = 150;
                p[i].Y = 250 + i * 10;
            }
            lan = 5;
            a = new Point[200];
            dir2 = 1;
            for (int i = 0; i < len; i++)
            {
                a[i].X = 250;
                a[i].Y = 250 + i * 10;
            }
            apple.X = 10;
            apple.Y = 10;
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
        private void Form1_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.Up)
                dir2 = 1;
            if (e.KeyCode == Keys.Down)
                dir2 = 2;
            if (e.KeyCode == Keys.Left)
                dir2 = 3;
            if (e.KeyCode == Keys.Right)
                dir2 = 4;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, panel1, new object[] { true });

            for (int i = 1; i < len; i++)
            {
                if (p[0].X == p[i].X && p[0].Y == p[i].Y)
                {
                    dead = 11;
                    a[i + 1].X = a[i].X;
                    a[i + 1].Y = a[i].Y;
                }
            }
            for (int i = 1; i < lan; i++)
            {
                if(a[0].X == a[i].X && a[0].Y == a[i].Y)
                {
                    dead2 = 11;
                    a[i + 1].X = a[i].X;
                    a[i + 1].Y = a[i].Y;
                } 
            }

            if (dir == 0)
            {
                menu f1 = new menu();
                f1.Show();
                Hide();
            }

            //управлении 1 игрока

            for (int i = 198; i >= 0; i--)
            {
                p[i + 1].X = p[i].X;
                p[i + 1].Y = p[i].Y;
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

            // управления 2 игрока\

            for (int i = 198; i >= 0; i--)
            {
                a[i + 1].X = a[i].X;
                a[i + 1].Y = a[i].Y;
            }
            if (dir2 == 1)
            {
                a[0].X = a[1].X;
                a[0].Y = a[1].Y - 10;
                if (a[0].Y < 0) a[0].Y = 490;
            }
            if (dir2 == 2)
            {
                a[0].X = a[1].X;
                a[0].Y = a[1].Y + 10;
                if (a[0].Y > 490) a[0].Y = 0;
            }
            if (dir2 == 3)
            {
                a[0].X = a[1].X - 10;
                if (a[0].X < 0) a[0].X = 490;
                a[0].Y = a[1].Y;
            }
            if (dir2 == 4)
            {
                a[0].X = a[1].X + 10;
                if (a[0].X > 490) a[0].X = 0;
                a[0].Y = a[1].Y;
            }

            // отрисовка

            SolidBrush p1 = new SolidBrush(Color.FromArgb(153, 255, 153));
            for (int i = 0; i < len; i++)
            {
                e.Graphics.FillEllipse(p1, p[i].X, p[i].Y, 10, 10);
            }
            SolidBrush p2 = new SolidBrush(Color.Yellow);
            for (int i = 0; i < lan; i++)
            {
                e.Graphics.FillEllipse(p2, a[i].X, a[i].Y, 10, 10);
            }
            SolidBrush b1 = new SolidBrush(Color.Red);
            e.Graphics.FillEllipse(b1, apple.X, apple.Y, 10, 10);
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

            // условия 1 игрока

            if (p[0].X == apple.X && p[0].Y == apple.Y)
            {
                len++;
                Random R;
                R = new Random();
                apple.X = R.Next(0, 50) * 10;
                apple.Y = R.Next(0, 50) * 10;
                c1++;
                label2.Text = c1.ToString();
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
            }

            if (
                p[0].X == kamen.X && p[0].Y == kamen.Y ||
                p[0].X == kamen2.X && p[0].Y == kamen2.Y ||
                p[0].X == kamen3.X && p[0].Y == kamen3.Y ||
                p[0].X == kamen4.X && p[0].Y == kamen4.Y ||
                p[0].X == kamen5.X && p[0].Y == kamen5.Y
               )
            {
                dead = 11;
                for (int i = 1; i < len; i++)
                {
                    p[0].X = p[i].X;
                    p[0].Y = p[i].Y;
                }
            }
            

            // условия 2 игрока

            if (a[0].X == apple.X && a[0].Y == apple.Y)
            {
                lan++;
                Random R;
                R = new Random();
                apple.X = R.Next(0, 50) * 10;
                apple.Y = R.Next(0, 50) * 10;
                c2++;
                label4.Text = c2.ToString();
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
            }

            if (
                a[0].X == kamen.X && a[0].Y == kamen.Y ||
                a[0].X == kamen2.X && a[0].Y == kamen2.Y ||
                a[0].X == kamen3.X && a[0].Y == kamen3.Y ||
                a[0].X == kamen4.X && a[0].Y == kamen4.Y ||
                a[0].X == kamen5.X && a[0].Y == kamen5.Y
               )
            {
                dead2 = 11;
                for (int i = 1; i < lan; i++)
                {
                    a[0].X = a[i].X;
                    a[0].Y = a[i].Y;
                }
            }
            if (dead == 11 && dead2 == 11)
            {
                menu fr2 = new menu();
                fr2.Show();
                Hide();
                MessageBox.Show("Игра окончена, вы проиграли");
            }

            //время

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


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();

        }
    }
}
