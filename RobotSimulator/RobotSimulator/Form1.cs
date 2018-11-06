using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotSimulator
{
    public partial class Form1 : Form
    {
        Robot machine = new Robot();
        Robot machine2 = new Robot();
        Brush machineColour = Brushes.Red;

        public bool IsRunning;
        public char[] x;
        public List<char> input = new List<char>();
        public bool validation;
        public int coordinates;

        public Form1()
        {
            InitializeComponent();

            StartGame();

            gameTimer.Interval = 1000 / Settings.Speed;

        }

        public void StartGame()
        {
            Robot machine = new Robot();
            Robot machine2 = new Robot();
            new Settings();

            gameTimer.Enabled = false;
            btnStart.Enabled = true;
            validation = true;
            lblValidation.Visible = false;

            lblXpos.Text = machine.Xpos.ToString();
            lblYpos.Text = machine.Ypos.ToString();
            lblFacing.Text = Settings.Facing.ToString();
            lblCommands.Text = input.Count.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Pen forward = new Pen(Color.LightGreen);
            Pen turn = new Pen(Color.LightCyan);

            canvas.FillRectangle(machineColour, machine.Xpos * Settings.Width, machine.Ypos * Settings.Height, Settings.Width, Settings.Height);

            string p = getFacePoint();
            string[] p2 = p.Split('.');

            List<int> r = new List<int>();

            for (int i = 0; i < p2.Length; i++)
            {
                int.TryParse(p2[i], out coordinates);
                r.Add(coordinates);
            }
            canvas.FillEllipse(Brushes.SkyBlue, r[0], r[1], Settings.Width / 2, Settings.Height / 2);
            canvas.DrawRectangle(forward, new Rectangle(0, 0, Settings.Width, Settings.Height));
        }

        public string getFacePoint()
        {
            int facePointX = (machine.Xpos * Settings.Width + Settings.Width / 2) - (Settings.Width / 4);
            int facePointY = (machine.Ypos * Settings.Height + Settings.Height / 2) -(Settings.Height / 4);

            if (Settings.Facing == Direction.north)
            {
                facePointY -= 15;
                return facePointX.ToString() + "." + facePointY.ToString();
            }
            else if (Settings.Facing == Direction.east)
            { 
                facePointX += 15;
                return facePointX.ToString() + "." + facePointY.ToString();
            }
            else if (Settings.Facing == Direction.south)
            {
                facePointY += 15;
                return facePointX.ToString() + "." + facePointY.ToString();
            }
            else
            {
                facePointX -= 15;
                return facePointX.ToString() + "." + facePointY.ToString();
            }
        }

        public void move(char letter)
        {
            if (letter == 'r')
            {
                if (Settings.Facing == Direction.west)
                {
                    Settings.Facing = Direction.north;
                }
                else
                {
                    Settings.Facing++;
                }
            }
            if (letter == 'l')
            {
                if (Settings.Facing == Direction.north)
                {
                    Settings.Facing = Direction.west;
                }
                else
                {
                    Settings.Facing--;
                }
            }
            if (letter == 'a')
            {
                switch (Settings.Facing)
                {
                    case Direction.north:
                        machine.Ypos--;
                        break;
                    case Direction.east:
                        machine.Xpos++;
                        break;
                    case Direction.south:
                        machine.Ypos++;
                        break;
                    case Direction.west:
                        machine.Xpos--;
                        break;
                }
            }
        }

        public void move2(char letter)
        {
            if (letter == 'r')
            {
                if (Settings.Facing == Direction.west)
                {
                    Settings.Facing = Direction.north;
                }
                else
                {
                    Settings.Facing++;
                }
            }
            if (letter == 'l')
            {
                if (Settings.Facing == Direction.north)
                {
                    Settings.Facing = Direction.west;
                }
                else
                {
                    Settings.Facing--;
                }
            }
            if (letter == 'a')
            {
                switch (Settings.Facing)
                {
                    case Direction.north:
                        machine2.Ypos--;
                        break;
                    case Direction.east:
                        machine2.Xpos++;
                        break;
                    case Direction.south:
                        machine2.Ypos++;
                        break;
                    case Direction.west:
                        machine2.Xpos--;
                        break;
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (input.Count > 0)
            {
                move(input[0]);
                input.RemoveAt(0);
                lblXpos.Text = machine.Xpos.ToString();
                lblYpos.Text = machine.Ypos.ToString();
                lblCommands.Text = input.Count.ToString();
                lblFacing.Text = Settings.Facing.ToString();
                Invalidate();
                pictureBox1.Invalidate();
            }
            else
            {
                Input.Clear();
                gameTimer.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            x = Input.Text.ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                input.Add(x[i]);
            }
            gameTimer.Enabled = true;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            string g = Input.Text.ToString();
            x = g.ToCharArray();
            lblCommands.Text = x.Length.ToString();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != 'a' && x[i] != 'r' && x[i] != 'l')
                {
                    validation = false;
                }
            }
            if (validation == false)
            {
                lblValidation.Text = "Please enter a valid command\nclick on label to try again\na(dvance), r(ight), l(eft)";
                lblValidation.Visible = true;
                btnStart.Enabled = false;
                Input.Clear();
            }
        }

        private void lblValidation_Click(object sender, EventArgs e)
        {
            lblValidation.Visible = false;
            btnStart.Enabled = true;
        }
    }
}
