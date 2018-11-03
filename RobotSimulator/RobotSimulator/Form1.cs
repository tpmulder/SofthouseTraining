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
        Robot machine = new Robot();
        Brush colour = Brushes.Red;

        public int machineX;
        public int machineY;
        public bool IsRunning;
        public char[] x;
        public List<char> input = new List<char>();
        public bool validation;

        public Form1()
        {
            InitializeComponent();

            StartGame();

            gameTimer.Interval = 1000 / Settings.Speed;

        }

        public void StartGame()
        {
            new Settings();

            gameTimer.Enabled = false;
            btnStart.Enabled = true;
            validation = true;
            lblValidation.Visible = false;
            machineX = 10;
            machineY = 10;

            lblXpos.Text = machineX.ToString();
            lblYpos.Text = machineY.ToString();
            lblFacing.Text = Settings.Facing.ToString();
            lblCommands.Text = input.Count.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(colour, machineX * Settings.Width, machineY * Settings.Height, Settings.Width, Settings.Height);
        }

        public void update(char letter)
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
                        machineY--;
                        break;
                    case Direction.east:
                        machineX++;
                        break;
                    case Direction.south:
                        machineY++;
                        break;
                    case Direction.west:
                        machineX--;
                        break;
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (input.Count > 0)
            {
                update(input[0]);
                input.RemoveAt(0);
                lblXpos.Text = machineX.ToString();
                lblYpos.Text = machineY.ToString();
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
                lblValidation.Text = "Please enter a valid command\nclick on label to try again";
                lblValidation.Visible = true;
                btnStart.Enabled = false;
            }
        }

        private void lblValidation_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
