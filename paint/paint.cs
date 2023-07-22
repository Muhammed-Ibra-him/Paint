using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class paint : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        Point sp = new Point(1500, 1500);
        Point ep = new Point(150, 150);
        int k = 0;
        public paint()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void red_Click(object sender, EventArgs e)
        {
            p.Color = red.BackColor;
            default1.BackColor = red.BackColor;
        }

        private void black_Click(object sender, EventArgs e)
        {
            p.Color = black.BackColor;
            default1.BackColor = black.BackColor;
        }

        private void gray_Click(object sender, EventArgs e)
        {
            p.Color = gray.BackColor;
            default1.BackColor = gray.BackColor;
        }

        private void DarkRed_Click(object sender, EventArgs e)
        {
            p.Color = DarkRed.BackColor;
            default1.BackColor = DarkRed.BackColor;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            p.Color = blue.BackColor;
            default1.BackColor = blue.BackColor;
        }

        private void green_Click(object sender, EventArgs e)
        {
            p.Color = green.BackColor;
            default1.BackColor = green.BackColor;
        }

        private void White_Click(object sender, EventArgs e)
        {
            p.Color = White.BackColor;
            default1.BackColor = White.BackColor;
        }

        private void Brown_Click(object sender, EventArgs e)
        {
            p.Color = Brown.BackColor;
            default1.BackColor = Brown.BackColor;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            p.Color = Pink.BackColor;
            default1.BackColor = Pink.BackColor;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            p.Color = Yellow.BackColor;
            default1.BackColor = Yellow.BackColor;
        }

        private void Gold_Click(object sender, EventArgs e)
        {
            p.Color = Gold.BackColor;
            default1.BackColor = Gold.BackColor;
        }

        private void Cyan_Click(object sender, EventArgs e)
        {
            p.Color = Cyan.BackColor;
            default1.BackColor = Cyan.BackColor;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            p.Color = Purple.BackColor;
            default1.BackColor = Purple.BackColor;
        }

        private void paint_MouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
            if (e.Button == MouseButtons.Left)
                k = 1;
        }

        private void paint_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }

        private void paint_MouseMove(object sender, MouseEventArgs e)
        {
            if(k==1)
            {
                ep = e.Location;
                g = this.CreateGraphics();
                g.DrawLine(p, sp, ep);
            }
            sp = ep;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            this.BackColor = Color.White;
        }
    }
}
