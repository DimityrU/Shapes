using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Course_project
{
    public partial class Scene : Form
    {
        public Bitmap bitmap;
        public Graphics graphics;
        public Regex regen;

        public Rectangles drawRectangle;
        public Squares drawSquare;
        public Triangles drawTriangle;
        public Circles drawCircle;
        public List<Figure> Figures { get; set; }
        public Scene()
        {
            InitializeComponent();
            Figures = new List<Figure>();
        }
        public void ShowBox()
        {
            bitmap = new Bitmap(pictureBox.Height, pictureBox.Width);
            graphics = Graphics.FromImage(bitmap);
            pictureBox.Image = bitmap;
            graphics.Clear(Color.Transparent);
        }
        private bool button1WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            ShowBox();
            button1WasClicked = true;

            if (rectangleBox.Checked == true)
            {
                if (string.IsNullOrEmpty(side_a.Text) || string.IsNullOrEmpty(side_b.Text))
                {
                    instruction2 empty = new instruction2();
                    empty.ShowDialog();
                    Area.Text = "Area:" + " ";
                    Perimeter.Text = "Perimeter:" + " ";
                }
                else if (int.Parse(side_a.Text) <= 0 || int.Parse(side_b.Text) <= 0)
                {
                    MessageBox.Show(
                       "Invalid sides!!!Sides must be positive and greater than zero.",
                       "Invalid sides!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    Area.Text = "Area:" + " ";
                    Perimeter.Text = "Perimeter:" + " ";
                }
                else 
                {
                    var drawRectangle = new Rectangles(140, 70,
                        int.Parse(side_a.Text),
                        int.Parse(side_b.Text));
                    Figures.Add(drawRectangle);
                    Area.Text = "Area:" + " " + int.Parse(side_a.Text) * int.Parse(side_b.Text);
                    Perimeter.Text = "Perimeter:" + " " + (int.Parse(side_a.Text) * 2 + int.Parse(side_b.Text) * 2);
                }
            };
            if (squareBox.Checked == true)
            {
                if (string.IsNullOrEmpty(side_a.Text))
                {
                    instruction2 empty = new instruction2();
                    empty.ShowDialog();
                    Area.Text = "Area:" + " ";
                    Perimeter.Text = "Perimeter:" + " ";
                }
                else if (int.Parse(side_a.Text) <= 0)
                {
                    MessageBox.Show(
                       "Invalid sides!!!Sides must be positive and greater than zero.",
                       "Invalid sides!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    Area.Text = "Area:" + " ";
                    Perimeter.Text = "Perimeter:" + " ";
                }
                else
                {
                    var drawSquare = new Squares(140, 70,
                        int.Parse(side_a.Text),
                        int.Parse(side_a.Text));
                    Figures.Add(drawSquare);
                    Area.Text = "Area:" + " " + int.Parse(side_a.Text) * int.Parse(side_a.Text);
                    Perimeter.Text = "Perimeter:" + " " + (int.Parse(side_a.Text) * 4);
                }
            };
            if (triangleBox.Checked == true)
            {
                if (string.IsNullOrEmpty(side_a.Text) || 
                    string.IsNullOrEmpty(side_b.Text) || 
                    string.IsNullOrEmpty(side_c.Text))
                {
                    instruction2 empty = new instruction2();
                    empty.ShowDialog();
                    Area.Text = "Area:" + " ";
                    Perimeter.Text = "Perimeter:" + " ";
                }
                else if (int.Parse(side_a.Text) <= 0 || int.Parse(side_b.Text) <= 0 || int.Parse(side_c.Text) <= 0)
                {
                    MessageBox.Show(
                       "Invalid sides!!!Sides must be positive and greater than zero.",
                       "Invalid sides!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    Area.Text = "Area:" + " ";
                    Perimeter.Text = "Perimeter:" + " ";
                }
                else if(int.Parse(side_a.Text) + int.Parse(side_b.Text) <= int.Parse(side_c.Text) || 
                    int.Parse(side_a.Text) + int.Parse(side_c.Text) <= int.Parse(side_b.Text) ||
                    int.Parse(side_b.Text) + int.Parse(side_c.Text) <= int.Parse(side_a.Text))
                {
                    MessageBox.Show(
                        "Invalid sides for triangle!!!The length of a side of a triangle is" +
                        " greater or equal than the sum of the lengths of the other two sides.",
                        "Invalid sides!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Area.Text = "Area:" + " ";
                    Perimeter.Text = "Perimeter:" + " ";
                }
                else
                {
                    double p = (
                        double.Parse(side_a.Text) +
                        double.Parse(side_b.Text) +
                        double.Parse(side_c.Text)) / 2;

                    var drawTriangle = new Triangles(
                       175 + int.Parse(side_a.Text),
                       200 + int.Parse(side_b.Text),
                       100 + int.Parse(side_c.Text));
                    Figures.Add(drawTriangle);
                    Area.Text = "Area:" + " " + 
                        Math.Sqrt(p * (p - int.Parse(side_a.Text)) * (p - int.Parse(side_b.Text)) * (p - int.Parse(side_c.Text)));
                    Perimeter.Text = "Perimeter:" + " " + p * 2;
                }
            }
            if (circleBox.Checked == true)
            {
                if (string.IsNullOrEmpty(side_a.Text))
                {
                    instruction2 empty = new instruction2();
                    empty.ShowDialog();
                    Area.Text = "Area:" + " ";
                    Perimeter.Text = "Perimeter:" + " "; ;
                }
                else if (int.Parse(side_a.Text) <= 0)
                {
                    MessageBox.Show(
                       "Invalid sides!!!Sides must be positive and greater than zero.",
                       "Invalid sides!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    Area.Text = "Area:" + " ";
                    Perimeter.Text = "Perimeter:" + " ";
                }
                else
                {
                    var drawCircle = new Circles(200, 190, int.Parse(side_a.Text));
                    Figures.Add(drawCircle);
                    Area.Text = "Area:" + " " + int.Parse(side_a.Text) * int.Parse(side_a.Text) + "π";
                    Perimeter.Text = "Perimeter:" + " " + int.Parse(side_a.Text) * 2 + "π";
                }
            }
            for (int i = 0; i < Figures.Count; i++)
            {
                Figure figure = Figures[i];
                figure.Draw(graphics);
            }
            if(rectangleBox.Checked == false && squareBox.Checked == false && 
                triangleBox.Checked == false && circleBox.Checked == false && 
                !File.Exists("figures"))
            {
                instruction1 sides = new instruction1();
                sides.ShowDialog();
            }
        }
        private void Scene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (button1WasClicked)
                {
                    Figures.Clear();
                    pictureBox.Image = bitmap;
                    graphics.Clear(Color.Transparent);
                    Area.Text = ("Area:" + " ");
                    Perimeter.Text = ("Perimeter:" + " ");
                    File.Delete("figures");
                }
            }
            if(e.KeyCode == Keys.Enter)
                button1.PerformClick();
            if (e.KeyCode == Keys.F1)
                rectangleBox.PerformClick();
            if (e.KeyCode == Keys.F2)
                squareBox.PerformClick();
            if (e.KeyCode == Keys.F3)
                triangleBox.PerformClick();
            if (e.KeyCode == Keys.F4)
                circleBox.PerformClick();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Scene_KeyDown(sender ,new KeyEventArgs(Keys.Delete));
            label5.Text = "A =";
            circleBox.Checked = false;
            triangleBox.Checked = false;
            rectangleBox.Checked = false;
            squareBox.Checked = false;
            side_a.Clear();
            side_b.Clear();
            side_c.Clear();
            side_a.ReadOnly = true;
            side_b.ReadOnly = true;
            side_c.ReadOnly = true;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button1.ClientRectangle,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 4, ButtonBorderStyle.Outset);
        }
        private void button2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, button2.ClientRectangle,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
        }
        private void Scene_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Figures.Count != 0)
            {
                var bin = new BinaryFormatter();
                using (var fileStream = new FileStream("figures", FileMode.Create, FileAccess.Write))
                    bin.Serialize(fileStream, Figures);
            }
        }
        private void Scene_Load(object sender, EventArgs e)
        {
            if (!File.Exists("figures"))
                return;

            var bin = new BinaryFormatter();
            using (var fileStream = new FileStream("figures", FileMode.Open, FileAccess.Read))
                Figures = (List<Figure>)bin.Deserialize(fileStream);

            button1_Click(sender, e);
        }
        private void rectangleBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rectangleBox.Checked)
                label5.Text = "A =";
            side_a.ReadOnly = false;
            side_b.ReadOnly = false;
            side_c.ReadOnly = true;
            side_c.Clear();
        }
        private void squareBox_CheckedChanged(object sender, EventArgs e)
        {
            if (squareBox.Checked)
                label5.Text = "A =";
            side_a.ReadOnly = false;
            side_b.ReadOnly = true;
            side_c.ReadOnly = true;
            side_b.Clear();
            side_c.Clear();
        }
        private void triangleBox_CheckedChanged(object sender, EventArgs e)
        {
            if (triangleBox.Checked)
                label5.Text = "A =";
            side_a.ReadOnly = false;
            side_b.ReadOnly = false;
            side_c.ReadOnly = false;
        }
        private void circleBox_CheckedChanged(object sender, EventArgs e)
        {
            if (circleBox.Checked)
                label5.Text = "R =";                        
            side_a.ReadOnly = false;
            side_b.ReadOnly = true;
            side_c.ReadOnly = true;
            side_b.Clear();
            side_c.Clear();
        }
        private void side_a_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(side_a.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.",
                    "Invalid character!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                side_a.Text = side_a.Text.Remove(side_a.Text.Length - 1);
            }
        }
        private void side_b_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(side_b.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.",
                    "Invalid character!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                side_b.Text = side_b.Text.Remove(side_b.Text.Length - 1);
            }
        }
        private void side_c_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(side_c.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.",
                    "Invalid character!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                side_c.Text = side_c.Text.Remove(side_c.Text.Length - 1);
            }
        }
    }
}