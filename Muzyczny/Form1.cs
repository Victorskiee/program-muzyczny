using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Muzyczny
{
    public partial class Form1 : Form
    {
        int number = 1;
        private SoundPlayer dzw = new SoundPlayer("sound1.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dzw.Play();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dzw.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = number + 1;
            if (number == 5)
                number = 1;

            pictureBox1.Image = Image.FromFile("s" + Convert.ToString(number) + ".png");

            dzw = new SoundPlayer("sound" + Convert.ToString(number) + ".wav");
            dzw.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = number - 1;
            if (number == 0)
                number = 4;

            pictureBox1.Image = Image.FromFile("s" + Convert.ToString(number) + ".png");
            dzw = new SoundPlayer("sound" + Convert.ToString(number) + ".wav");
            dzw.Play();
        }
    }
}
