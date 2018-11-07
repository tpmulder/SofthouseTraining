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
        List<Rectangle> machinePath = new List<Rectangle>();
        List<Rectangle> machineTurn = new List<Rectangle>();
        Brush machineColour = Brushes.Red;
        Robot pathHead = new Robot();

        public bool IsRunning = true;
        public char[] x;
        public List<char> input = new List<char>();
        public bool validation;
        public int coordinates;
        public bool turn = false;

        public Form1()
        {
            InitializeComponent();

            StartGame();

            gameTimer.Interval = 1000 / Settings.Speed;

        }

        public void StartGame()
        {
            Robot machine = new Robot();
            List<Rectangle> machinePath = new List<Rectangle>();
            List<Rectangle> machineTurn = new List<Rectangle>();
            new Settings();
            Robot pathHead = new Robot();

            gameTimer.Enabled = false;
            IsRunning = true;
            btnStart.Enabled = true;
            validation = true;
            lblValidation.Visible = false;
            turn = false;
            machinePath.Clear();
            machineTurn.Clear();

            lblXpos.Text = machine.Xpos.ToString();
            lblYpos.Text = machine.Ypos.ToString();
            lblFacing.Text = machine.Facing.ToString();
            lblCommands.Text = input.Count.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Pen forwardColor = new Pen(Color.LightGreen);
            Pen turnColor = new Pen(Color.Purple);

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


            for (int i = 0; i < machinePath.Count; i++)
            {
                canvas.DrawRectangle(forwardColor, machinePath[i]);
            }
            for (int i = 0; i < machineTurn.Count; i++)
            {
                canvas.DrawRectangle(turnColor, machineTurn[i]);
            }

            if (!IsRunning)
            {
                canvas.Clear(Color.White);
            }
        }

        public string getFacePoint()
        {
            int facePointX = (machine.Xpos * Settings.Width + Settings.Width / 2) - (Settings.Width / 4);
            int facePointY = (machine.Ypos * Settings.Height + Settings.Height / 2) -(Settings.Height / 4);

            if (machine.Facing == Robot.Direction.north)
            {
                facePointY -= 15;
                return facePointX.ToString() + "." + facePointY.ToString();
            }
            else if (machine.Facing == Robot.Direction.east)
            { 
                facePointX += 15;
                return facePointX.ToString() + "." + facePointY.ToString();
            }
            else if (machine.Facing == Robot.Direction.south)
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
                if (machine.Facing == Robot.Direction.west)
                {
                    machine.Facing = Robot.Direction.north;
                }
                else
                {
                    machine.Facing++;
                }
            }
            if (letter == 'l')
            {
                if (machine.Facing == Robot.Direction.north)
                {
                    machine.Facing = Robot.Direction.west;
                }
                else
                {
                    machine.Facing--;
                }
            }
            if (letter == 'a')
            {
                switch (machine.Facing)
                {
                    case Robot.Direction.north:
                        machine.Ypos--;
                        break;
                    case Robot.Direction.east:
                        machine.Xpos++;
                        break;
                    case Robot.Direction.south:
                        machine.Ypos++;
                        break;
                    case Robot.Direction.west:
                        machine.Xpos--;
                        break;
                }
            }
        }

        public void move2(char letter)
        {
            if (letter == 'r')
            {
                turn = true;

                if (pathHead.Facing == Robot.Direction.west)
                {
                    pathHead.Facing = Robot.Direction.north;
                }
                else
                {
                    pathHead.Facing++;
                }
            }
            if (letter == 'l')
            {
                turn = true;

                if (pathHead.Facing == Robot.Direction.north)
                {
                    pathHead.Facing = Robot.Direction.west;
                }
                else
                {
                    pathHead.Facing--;
                }
            }
            if (letter == 'a')
            {
                turn = false;

                switch (pathHead.Facing)
                {
                    case Robot.Direction.north:
                        pathHead.Ypos -= Settings.Height;
                        break;
                    case Robot.Direction.east:
                        pathHead.Xpos += Settings.Width;
                        break;
                    case Robot.Direction.south:
                        pathHead.Ypos += Settings.Height;
                        break;
                    case Robot.Direction.west:
                        pathHead.Xpos -= Settings.Width;
                        break;
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                if (input.Count > 0)
                {
                    move(input[0]);
                    input.RemoveAt(0);
                    if (machineTurn.Count > 0 && machinePath[0] == machineTurn[0])
                    {
                        machineTurn.RemoveAt(0);
                    }
                    machinePath.RemoveAt(0);
                    lblXpos.Text = machine.Xpos.ToString();
                    lblYpos.Text = machine.Ypos.ToString();
                    lblCommands.Text = input.Count.ToString();
                    lblFacing.Text = machine.Facing.ToString();
                    Invalidate();
                    pictureBox1.Invalidate();
                }
                else
                {
                    Input.Clear();
                    gameTimer.Enabled = false;
                }
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
            if (x.Count() > 0)
            {
                char y = x.Last();
                move2(y);
                if (y == 'r' || y == 'l')
                {
                    machineTurn.Add(new Rectangle(pathHead.Xpos, pathHead.Ypos, Settings.Width, Settings.Height));
                }
                machinePath.Add(new Rectangle(pathHead.Xpos, pathHead.Ypos, Settings.Width, Settings.Height));
                pictureBox1.Invalidate();
            }
        }

        private void lblValidation_Click(object sender, EventArgs e)
        {
            IsRunning = false;
            StartGame();
        }
    }
}
