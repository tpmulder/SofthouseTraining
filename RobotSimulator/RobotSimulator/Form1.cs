using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotSimulator
{
    public partial class Form1 : Form
    {
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();
            canvas = pictureBox1.CreateGraphics();
            new Settings();
            Robot robot = new Robot();
            Brush colour = Brushes.Beige;

            canvas.FillRectangle(colour, robot.Xpos * Settings.Width, robot.Ypos * Settings.Height, Settings.Width, Settings.Height);


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
