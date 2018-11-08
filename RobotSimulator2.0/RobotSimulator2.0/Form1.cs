using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotSimulator2
{
    public partial class Form1 : Form
    {
        // Instances
        Robot robot = new Robot();
        Robot robotPlacer = new Robot();
        List<Rectangle> robotPath = new List<Rectangle>();
        List<Rectangle> robotRotate = new List<Rectangle>();
        List<char> charListInput;

        // Colors
        Brush robotColor = Brushes.Red;
        Brush facePointerColor = Brushes.Cyan;
        Pen PathColorFw = new Pen(Color.LightGreen);
        Pen PathColorRot = new Pen(Color.LightCoral);
        Pen outlines = new Pen(Color.Gray);

        public Form1()
        {
            InitializeComponent();

            StartGame();

            gameTimer.Interval = 1000 / Settings.Speed;
        }

        public void StartGame()
            // Set begin values
        {
            Robot robot = new Robot();
            List<Rectangle> robotPath = new List<Rectangle>();

            new Settings();

            lblXpos.Text = robot.Xpos.ToString();
            lblYpos.Text = robot.Ypos.ToString();
            lblDirection.Text = robot.Facing.ToString();
            lblCmd.Text = textBox1.Text.ToCharArray().Count().ToString();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
            // draws canvas
        {

            // background
            Graphics canvas = e.Graphics;

            int y1 = 0;
            int y2 = 0;

            canvas.DrawRectangle(outlines, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
            for (int i = 0; i < pictureBox.Height; i = i + robot.Height)
            {
                int x1 = 0;
                int x2 = pictureBox.Width;

                y1 = y1 + robot.Height;
                y2 = y2 + robot.Height;

                canvas.DrawLine(outlines, x1, y1, x2, y2);
            }

            int x3 = 0;
            int x4 = 0;

            for (int i = 0; i < pictureBox.Width; i = i + robot.Width)
            {
                int y3 = 0;
                int y4 = pictureBox.Height;

                x3 = x3 + robot.Width;
                x4 = x4 + robot.Width;

                canvas.DrawLine(outlines, x3, y3, x4, y4);
            }

            pictureBox.BackColor = Color.DarkBlue;

            // robot
            canvas.FillRectangle(robotColor, robot.Xpos * robot.Width, robot.Ypos * robot.Height, robot.Width, robot.Height);
            canvas.FillEllipse(facePointerColor, getFacePoint());

            for (int i = 0; i < robotPath.Count; i++)
            {
                canvas.DrawRectangle(PathColorFw, robotPath[i]);
            }
            for (int i = 0; i < robotRotate.Count; i++)
            {
                canvas.DrawRectangle(PathColorRot, robotRotate[i]);
            }
        }

        public Rectangle getFacePoint()
            // Locates and indicates direction of robot
        {
            int facePointX = (robot.Xpos * robot.Width + robot.Width / 2) - (robot.Width / 4);
            int facePointY = (robot.Ypos * robot.Height + robot.Height / 2) - (robot.Height / 4);

            if (robot.Facing == Robot.Direction.north)
            {
                facePointY -= 15;
                return new Rectangle(facePointX, facePointY, robot.Width / 2, robot.Height / 2);
            }
            else if (robot.Facing == Robot.Direction.east)
            {
                facePointX += 15;
                return new Rectangle(facePointX, facePointY, robot.Width / 2, robot.Height / 2);
            }
            else if (robot.Facing == Robot.Direction.south)
            {
                facePointY += 15;
                return new Rectangle(facePointX, facePointY, robot.Width / 2, robot.Height / 2);
            }
            else
            {
                facePointX -= 15;
                return new Rectangle(facePointX, facePointY, robot.Width / 2, robot.Height / 2);
            }
        }

        public void move(Robot r, char letter)
            // movement robot at commands
        {
            if (letter == 'r')
            {
                if (r.Facing == Robot.Direction.west)
                {
                    r.Facing = Robot.Direction.north;
                }
                else
                {
                    r.Facing++;
                }
            }
            if (letter == 'l')
            {
                if (r.Facing == Robot.Direction.north)
                {
                    r.Facing = Robot.Direction.west;
                }
                else
                {
                    r.Facing--;
                }
            }
            if (letter == 'a')
            {
                if (r == robot)
                {
                    switch (r.Facing)
                    {
                        case Robot.Direction.north:
                            r.Ypos--;
                            break;
                        case Robot.Direction.east:
                            r.Xpos++;
                            break;
                        case Robot.Direction.south:
                            r.Ypos++;
                            break;
                        case Robot.Direction.west:
                            r.Xpos--;
                            break;
                    }
                }
                else
                {
                    switch (r.Facing)
                    {
                        case Robot.Direction.north:
                            r.Ypos -= robot.Height;
                            break;
                        case Robot.Direction.east:
                            r.Xpos += robot.Width;
                            break;
                        case Robot.Direction.south:
                            r.Ypos += robot.Height;
                            break;
                        case Robot.Direction.west:
                            r.Xpos -= robot.Width;
                            break;
                    }
                }
            }
        }

        public void updateStats()
            // updates labels
        {
            lblXpos.Text = robot.Xpos.ToString();
            lblYpos.Text = robot.Ypos.ToString();
            lblDirection.Text = robot.Facing.ToString();
            lblCmd.Text = textBox1.Text.ToCharArray().Count().ToString();
        }

        public bool Validation(List<char> input)
            // checks if input is valid
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != 'a' && input[i] != 'r' && input[i] != 'l')
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
            // updates at input
        {
            charListInput = textBox1.Text.ToCharArray().ToList();

            if (Validation(charListInput))
            {
                if (charListInput.Count > 0)
                {
                    char y = charListInput.Last();
                    move(robotPlacer, y);
                    if (y == 'r' || y == 'l')
                    {
                        robotRotate.Add(new Rectangle(robotPlacer.Xpos, robotPlacer.Ypos, robot.Width, robot.Height));
                    }
                    robotPath.Add(new Rectangle(robotPlacer.Xpos, robotPlacer.Ypos, robot.Width, robot.Height));
                    pictureBox.Invalidate();
                }
            }
            lblCmd.Text = textBox1.Text.ToCharArray().Count().ToString();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (charListInput.Count > 0)
            {
                move(robot, charListInput[0]);
                charListInput.RemoveAt(0);
                robotPath.RemoveAt(0);

                if (robotRotate.Count > 0 && robotPath[0] == robotRotate[0])
                {
                    robotRotate.RemoveAt(0);
                }
                updateStats();

                pictureBox.Invalidate();
            }
            else
            {
                textBox1.Clear();
                gameTimer.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
        }
    }
}
