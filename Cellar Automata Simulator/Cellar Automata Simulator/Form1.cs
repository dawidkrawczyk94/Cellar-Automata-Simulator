using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Cellar_Automata_Simulator
{
    public partial class Form1 : Form
    {
        private static Color current_color;
        private static Bitmap bmp_now = new Bitmap(1000, 1000);
        private static Graphics gph_now = Graphics.FromImage(bmp_now);
        private static int width;
        private static int height;
        private static bool if_inclusion;
        private static int empty_cell_counter;
        private bool whileFlag;
        private bool step;
        private string inclusion_color_name = "ff000000";
        private bool GBC = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void neighboors_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (neighboors_cbox.SelectedItem)
            {
                case "von Neumanna":
                    phopt_cbox.Items.Clear();
                    phopt_cbox.Text = "";
                    break;

                case "Moore’a":
                    phopt_cbox.Items.Clear();
                    phopt_cbox.Text = "";
                    break;
                case "Hexagonal":
                    phopt_cbox.Items.Clear();
                    phopt_cbox.Items.Add("left");
                    phopt_cbox.Items.Add("right");
                    phopt_cbox.Items.Add("random");
                    phopt_cbox.Text = "random";
                    break;
                case "Pentagonal":
                    phopt_cbox.Items.Clear();
                    phopt_cbox.Items.Add("left");
                    phopt_cbox.Items.Add("right");
                    phopt_cbox.Items.Add("random");
                    phopt_cbox.Text = "random";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            green_pct.BackColor = Color.Green;
            blue_pct.BackColor = Color.Blue;
            red_pct.BackColor = Color.Red;
            yellow_pct.BackColor = Color.Yellow;
            pink_pct.BackColor = Color.Pink;
            brown_pct.BackColor = Color.Brown;
            orange_pct.BackColor = Color.Orange;
            gray_pct.BackColor = Color.Gray;
            if_inclusion = false;
            neighboors_cbox.Text = "von Neumanna";

        }

        private void width_tbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(width_tbox.Text))
            {

            }
            else
            {
                width = System.Convert.ToInt32(width_tbox.Text);
                main_pct.Size = new System.Drawing.Size(width, main_pct.Height);
                empty_cell_counter = width * height;
            }
        }

        private void height_tbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(height_tbox.Text))
            {

            }
            else
            {
                height = System.Convert.ToInt32(height_tbox.Text);
                main_pct.Size = new System.Drawing.Size(main_pct.Width, height);
                empty_cell_counter = width * height;
            }
        }

        private void red_pct_Click(object sender, EventArgs e)
        {
            current_color = red_pct.BackColor;
            current_color_pct.BackColor = current_color;
            if_inclusion = false;
        }

        private void green_pct_Click(object sender, EventArgs e)
        {
            current_color = green_pct.BackColor;
            current_color_pct.BackColor = current_color;
            if_inclusion = false;
        }

        private void blue_pct_Click(object sender, EventArgs e)
        {
            current_color = blue_pct.BackColor;
            current_color_pct.BackColor = current_color;
            if_inclusion = false;
        }

        private void yellow_pct_Click(object sender, EventArgs e)
        {
            current_color = yellow_pct.BackColor;
            current_color_pct.BackColor = current_color;
            if_inclusion = false;
        }

        private void brown_pct_Click(object sender, EventArgs e)
        {
            current_color = brown_pct.BackColor;
            current_color_pct.BackColor = current_color;
            if_inclusion = false;
        }

        private void pink_pct_Click(object sender, EventArgs e)
        {
            current_color = pink_pct.BackColor;
            current_color_pct.BackColor = current_color;
            if_inclusion = false;
        }

        private void orange_pct_Click(object sender, EventArgs e)
        {
            current_color = orange_pct.BackColor;
            current_color_pct.BackColor = current_color;
            if_inclusion = false;
        }

        private void black_pct_Click(object sender, EventArgs e)
        {
            current_color = gray_pct.BackColor;
            current_color_pct.BackColor = current_color;
            if_inclusion = false;
        }

        private void main_pct_Click(object sender, EventArgs e)
        {

            if (if_inclusion)
            {
                if (textBox1.Text != "")
                {
                    Rectangle rect = new Rectangle(MousePosition.X - this.Location.X - main_pct.Location.X - 4, MousePosition.Y - this.Location.Y - main_pct.Location.Y - 30, System.Convert.ToInt32(textBox1.Text) * 2, System.Convert.ToInt32(textBox1.Text) * 2);
                    SolidBrush grayBrush = new SolidBrush(Color.Black);
                    var gph_n = Graphics.FromImage(bmp_now);
                    gph_n.FillEllipse(grayBrush, rect);
                    main_pct.Image = bmp_now;
                }

            }
            else
            {
                bmp_now.SetPixel(MousePosition.X - this.Location.X - main_pct.Location.X - 4, MousePosition.Y - this.Location.Y - main_pct.Location.Y - 30, current_color);
                main_pct.Image = bmp_now;
            }


        }

        private async void step_bt_Click(object sender, EventArgs e)
        {

            width = main_pct.Width;
            height = main_pct.Height;
            step = true;
            var NeighboorOpt = neighboors_cbox.Text;
            var PH_Opt = phopt_cbox.Text;
            var bitmapValues = GetBitmapValues(bmp_now);

            await Task.Run(() => MyMethodAsync(bitmapValues, NeighboorOpt, PH_Opt));

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Bitmap bm = new Bitmap(inclusion_pct.Width, inclusion_pct.Height);
                Graphics gr = Graphics.FromImage(bm);
                Rectangle rect = new Rectangle(inclusion_pct.Width / 2 - System.Convert.ToInt32(textBox1.Text), inclusion_pct.Height / 2 - System.Convert.ToInt32(textBox1.Text), System.Convert.ToInt32(textBox1.Text) * 2, System.Convert.ToInt32(textBox1.Text) * 2);
                SolidBrush grayBrush = new SolidBrush(Color.Black);
                gr.FillEllipse(grayBrush, rect);
                inclusion_pct.Image = bm;
                if_inclusion = true;
            }

        }

        private void inclusion_pct_Click(object sender, EventArgs e)
        {
            if_inclusion = true;
        }

        private void current_color_pct_Click(object sender, EventArgs e)
        {
            current_color = current_color_pct.BackColor;
            if_inclusion = false;
        }

        private void MyMethodAsync(List<List<Color>> bitmapValues, string NeighboorOpt, string PH_Opt)
        {


            whileFlag = true;

            while (whileFlag)
            {
                List<List<Color>> bitmapValuesNext = new List<List<Color>>();
                for (int y = 0; y < height; y++)
                {
                    var xValuesListNext = new List<Color>();
                    for (int x = 0; x < width; x++)
                    {
                        if (bitmapValues[y][x].Name == "0")
                        {
                            if(GBC)
                            {
                                if (Rule_1(x, y, bitmapValues).Name == "0")
                                {
                                    if (Rule_2(x, y, bitmapValues).Name == "0")
                                    {
                                        if (Rule_3(x, y, bitmapValues).Name == "0")
                                        {
                                            if (Rule_4(x, y, bitmapValues).Name == "0")
                                            {
                                              xValuesListNext.Add(bitmapValues[y][x]);
                                            }
                                            else
                                            {
                                                xValuesListNext.Add(Rule_4(x, y, bitmapValues));
                                            }

                                        }
                                        else
                                        {
                                            xValuesListNext.Add(Rule_3(x, y, bitmapValues));
                                        }

                                    }
                                    else
                                    {
                                        xValuesListNext.Add(Rule_2(x, y, bitmapValues));
                                    }

                                }
                                else
                                {
                                    xValuesListNext.Add(Rule_1(x, y, bitmapValues));
                                }
                            }
                            else
                            { 
                                switch(NeighboorOpt)
                                {
                                    case "von Neumanna":
                                        xValuesListNext.Add(neumann_function(x, y, bitmapValues));
                                        break;
                                    case "Moore’a":
                                        if (neumann_function(x, y, bitmapValues).Name == "0")
                                        {
                                        xValuesListNext.Add(moor_function(x, y, bitmapValues));
                                        break;
                                        }
                                        else
                                        {
                                        xValuesListNext.Add(neumann_function(x, y, bitmapValues));
                                        break;
                                        }

                                    case "Hexagonal":
                                        if (neumann_function(x, y, bitmapValues).Name == "0")
                                        {
                                            switch (PH_Opt)
                                            {
                                            case "left":
                                                xValuesListNext.Add(hexagonal_function_left(x, y, bitmapValues));
                                                break;

                                            case "right":
                                                xValuesListNext.Add(hexagonal_function_right(x, y, bitmapValues));
                                                break;

                                            case "random":
                                                Random rnd = new Random();
                                                int random = rnd.Next(1, 3);
                                                switch (random)
                                                {
                                                    case 1:
                                                        xValuesListNext.Add(hexagonal_function_left(x, y, bitmapValues));
                                                        break;
                                                    case 2:
                                                        xValuesListNext.Add(hexagonal_function_right(x, y, bitmapValues));
                                                        break;
                                                }
                                                break;

                                            }
                                            break; 
                                        }
                                    else
                                    {
                                        xValuesListNext.Add(neumann_function(x, y, bitmapValues));
                                        break;
                                    }

                                case "Pentagonal":
                                    switch (PH_Opt)
                                    {
                                        case "left":
                                            xValuesListNext.Add(pentagonal_function_left(x, y, bitmapValues));
                                            break;

                                        case "right":
                                            xValuesListNext.Add(pentagonal_function_right(x, y, bitmapValues));
                                            break;

                                        case "random":
                                            Random rnd = new Random();
                                            int random = rnd.Next(1, 3);
                                            switch (random)
                                            {
                                                case 1:
                                                    xValuesListNext.Add(pentagonal_function_left(x, y, bitmapValues));
                                                    break;
                                                case 2:
                                                    xValuesListNext.Add(pentagonal_function_right(x, y, bitmapValues));
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            }
                        }
                        else
                        {
                            xValuesListNext.Add(bitmapValues[y][x]);
                        }
                    }
                    bitmapValuesNext.Add(xValuesListNext);
                }



                Image img = main_pct.Image;
                bmp_now = CreateBitmapFromListValues(bitmapValuesNext);
                bitmapValues = bitmapValuesNext;
                main_pct.Image = bmp_now;
                img?.Dispose();


                if(step)
                {
                    whileFlag = false;
                }

                if (whileFlag)
                {
                 whileFlag = bitmapValues.Any(a => a.Any(value => value.Name == "0"));
                } 
            }
        }


        private Color neumann_function(int x, int y, List<List<Color>> bitmapValues)
        {
            List<Color> neighboors = new List<Color>();
            var nbh1_x = x - 1;
            var nbh1_y = y;
            var nbh2_x = x + 1;
            var nbh2_y = y;
            var nbh3_x = x;
            var nbh3_y = y - 1;
            var nbh4_x = x;
            var nbh4_y = y + 1;
            var inclusion_color = Color.Black;

            if (nbh1_x > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0" && bitmapValues[nbh1_y][nbh1_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && bitmapValues[nbh2_y][nbh2_x].Name != "0" && bitmapValues[nbh2_y][nbh2_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0" && bitmapValues[nbh3_y][nbh3_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && bitmapValues[nbh4_y][nbh4_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (neighboors.Count() == 0)
            {
                return bitmapValues[y][x];
            }
            else
            {
                neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                return neighboors[0];
            }
        }

        public Color moor_function(int x, int y, List<List<Color>> bitmapValues)
        {
            List<Color> neighboors = new List<Color>();
            var nbh1_x = x - 1;
            var nbh1_y = y - 1;
            var nbh2_x = x + 1;
            var nbh2_y = y - 1;
            var nbh3_x = x - 1;
            var nbh3_y = y + 1;
            var nbh4_x = x + 1;
            var nbh4_y = y + 1;


            if (nbh1_x > -1 && nbh1_y > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0" && bitmapValues[nbh1_y][nbh1_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && nbh2_y > -1 && bitmapValues[nbh2_y][nbh2_x].Name != "0" && bitmapValues[nbh2_y][nbh2_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_x > -1 && nbh3_y < height && bitmapValues[nbh3_y][nbh3_x].Name != "0" && bitmapValues[nbh3_y][nbh3_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_x < width && nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && bitmapValues[nbh4_y][nbh4_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (neighboors.Count() == 0)
            {
                return bitmapValues[y][x];
            }
            else
            {
                neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                return neighboors[0];
            }

        }

        public Color hexagonal_function_left(int x, int y, List<List<Color>> bitmapValues)
        {
            List<Color> neighboors = new List<Color>();
            var nbh1_x = x - 1;
            var nbh1_y = y;
            var nbh2_x = x + 1;
            var nbh2_y = y;
            var nbh3_x = x;
            var nbh3_y = y - 1;
            var nbh4_x = x;
            var nbh4_y = y + 1;
            var nbh5_x = x - 1;
            var nbh5_y = y - 1;
            var nbh6_x = x + 1;
            var nbh6_y = y + 1;

            if (nbh1_x > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0" && bitmapValues[nbh1_y][nbh1_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && bitmapValues[nbh2_y][nbh2_x].Name != "0" && bitmapValues[nbh2_y][nbh2_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0" && bitmapValues[nbh3_y][nbh3_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && bitmapValues[nbh4_y][nbh4_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (nbh5_x > -1 && nbh5_y > -1 && bitmapValues[nbh5_y][nbh5_x].Name != "0" && bitmapValues[nbh5_y][nbh5_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh5_y][nbh5_x]); }

            if (nbh6_x < width && nbh6_y < height && bitmapValues[nbh6_y][nbh6_x].Name != "0" && bitmapValues[nbh6_y][nbh6_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh6_y][nbh6_x]); }

            if (neighboors.Count() == 0)
            {
                return bitmapValues[y][x];
            }
            else
            {
                neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                return neighboors[0];
            }

        }

        public Color hexagonal_function_right(int x, int y, List<List<Color>> bitmapValues)
        {
            List<Color> neighboors = new List<Color>();
            var nbh1_x = x - 1;
            var nbh1_y = y;
            var nbh2_x = x + 1;
            var nbh2_y = y;
            var nbh3_x = x;
            var nbh3_y = y - 1;
            var nbh4_x = x;
            var nbh4_y = y + 1;
            var nbh5_x = x + 1;
            var nbh5_y = y - 1;
            var nbh6_x = x - 1;
            var nbh6_y = y + 1;


            if (nbh1_x > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0" && bitmapValues[nbh1_y][nbh1_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && bitmapValues[nbh2_y][nbh2_x].Name != "0" && bitmapValues[nbh2_y][nbh2_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0" && bitmapValues[nbh3_y][nbh3_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && bitmapValues[nbh4_y][nbh4_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (nbh5_x < width && nbh5_y > -1 && bitmapValues[nbh5_y][nbh5_x].Name != "0" && bitmapValues[nbh5_y][nbh5_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh5_y][nbh5_x]); }

            if (nbh6_x > -1 && nbh6_y < height && bitmapValues[nbh6_y][nbh6_x].Name != "0" && bitmapValues[nbh6_y][nbh6_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh6_y][nbh6_x]); }

            if (neighboors.Count() == 0)
            {
                return bitmapValues[y][x];
            }
            else
            {
                neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                return neighboors[0];
            }


        }

        public Color pentagonal_function_left(int x, int y, List<List<Color>> bitmapValues)
        {
            List<Color> neighboors = new List<Color>();
            var nbh1_x = x - 1;
            var nbh1_y = y;
            var nbh2_x = x - 1;
            var nbh2_y = y - 1;
            var nbh3_x = x;
            var nbh3_y = y - 1;
            var nbh4_x = x;
            var nbh4_y = y + 1;
            var nbh5_x = x - 1;
            var nbh5_y = y + 1;


            if (nbh1_x > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0" && bitmapValues[nbh1_y][nbh1_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x > -1 && nbh2_y > -1 && nbh2_y > -1 && bitmapValues[nbh2_y][nbh2_x].Name != "0" && bitmapValues[nbh2_y][nbh2_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }


            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0" && bitmapValues[nbh3_y][nbh3_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }
            

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && bitmapValues[nbh4_y][nbh4_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (nbh5_x > -1 && nbh5_y < height && bitmapValues[nbh5_y][nbh5_x].Name != "0" && bitmapValues[nbh5_y][nbh5_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh5_y][nbh5_x]); }

            if (neighboors.Count() == 0)
            {
                return bitmapValues[y][x];
            }
            else
            {
                neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                return neighboors[0];
            }

        }

        public Color pentagonal_function_right(int x, int y, List<List<Color>> bitmapValues)
        {
            List<Color> neighboors = new List<Color>();
            var nbh1_x = x + 1;
            var nbh1_y = y - 1;
            var nbh2_x = x + 1;
            var nbh2_y = y;
            var nbh3_x = x;
            var nbh3_y = y - 1;
            var nbh4_x = x;
            var nbh4_y = y + 1;
            var nbh5_x = x + 1;
            var nbh5_y = y + 1;


            if (nbh1_x < width && nbh1_y > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0" && bitmapValues[nbh1_y][nbh1_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && nbh2_y > -1 && bitmapValues[nbh2_y][nbh2_x].Name != "0" && bitmapValues[nbh2_y][nbh2_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0" && bitmapValues[nbh3_y][nbh3_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && bitmapValues[nbh4_y][nbh4_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (nbh5_x < width && nbh5_y < height && bitmapValues[nbh5_y][nbh5_x].Name != "0" && bitmapValues[nbh5_y][nbh5_x].Name != inclusion_color_name)
            { neighboors.Add(bitmapValues[nbh5_y][nbh5_x]); }

            if (neighboors.Count() == 0)
            {
                return bitmapValues[y][x];
            }
            else
            {
                neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                return neighboors[0];
            }
        }

        private Color Rule_1(int x, int y, List<List<Color>> bitmapValues)
        {
            List<Color> moor_neighboors = new List<Color>();
            if (y - 1 > -1 && bitmapValues[y - 1][x].Name != "0" && bitmapValues[y - 1][x].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y - 1][x]); }

            if (y + 1 < height && bitmapValues[y + 1][x].Name != "0" && bitmapValues[y + 1][x].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y + 1][x]); }

            if (x - 1 > -1 && bitmapValues[y][x - 1].Name != "0" && bitmapValues[y][x - 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y][x - 1]); }

            if (x + 1 < width && bitmapValues[y][x + 1].Name != "0" && bitmapValues[y][x + 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y][x + 1]); }

            if (x - 1 > -1 && y - 1 > -1 && bitmapValues[y - 1][x - 1].Name != "0" && bitmapValues[y - 1][x - 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y - 1][x - 1]); }

            if (y - 1 > -1 && x + 1 < width && bitmapValues[y - 1][x + 1].Name != "0" && bitmapValues[y - 1][x + 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y - 1][x + 1]); }

            if (x - 1 > -1 && y + 1 < height && bitmapValues[y + 1][x - 1].Name != "0" && bitmapValues[y + 1][x - 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y + 1][x - 1]); }

            if (x + 1 < width && y + 1 < height && bitmapValues[y + 1][x + 1].Name != "0" && bitmapValues[y + 1][x + 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y + 1][x + 1]); }

            if (moor_neighboors.Count() == 0)
            {
                return bitmapValues[y][x];
            }
            else
            { 
                moor_neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                Color mostOftenCol = moor_neighboors[0];
                int mostOften = moor_neighboors.Count(a => a == mostOftenCol);
                if (mostOften > 4)
                {
                    return mostOftenCol;
                }
                else
                {
                return bitmapValues[y][x];
                }
            }
        }

        private Color Rule_2(int x, int y, List<List<Color>> bitmapValues)
        {
            List<Color> moor_neighboors = new List<Color>();
            if (y - 1 > -1 && bitmapValues[y - 1][x].Name != "0" && bitmapValues[y - 1][x].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y - 1][x]); }

            if (y + 1 < height && bitmapValues[y + 1][x].Name != "0" && bitmapValues[y + 1][x].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y + 1][x]); }

            if (x - 1 > -1 && bitmapValues[y][x - 1].Name != "0" && bitmapValues[y][x - 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y][x - 1]); }

            if (x + 1 < width && bitmapValues[y][x + 1].Name != "0" && bitmapValues[y][x + 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y][x + 1]); }

            if (moor_neighboors.Count() == 0)
            {
                return bitmapValues[y][x];
            }
            else
            {
                moor_neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                Color mostOftenCol = moor_neighboors[0];
                int mostOften = moor_neighboors.Count(a => a == mostOftenCol);
                if (mostOften > 2)
                {
                    return mostOftenCol;
                }
                else
                {
                    return bitmapValues[y][x];
                }
            }
        }

        private Color Rule_3(int x, int y, List<List<Color>> bitmapValues)
        {
            List<Color> moor_neighboors = new List<Color>();


            if (x - 1 > -1 && y - 1 > -1 && bitmapValues[y - 1][x - 1].Name != "0" && bitmapValues[y - 1][x - 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y - 1][x - 1]); }

            if (y - 1 > -1 && x + 1 < width && bitmapValues[y - 1][x + 1].Name != "0" && bitmapValues[y - 1][x + 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y - 1][x + 1]); }

            if (x - 1 > -1 && y + 1 < height && bitmapValues[y + 1][x - 1].Name != "0" && bitmapValues[y + 1][x - 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y + 1][x - 1]); }

            if (x + 1 < width && y + 1 < height && bitmapValues[y + 1][x + 1].Name != "0" && bitmapValues[y + 1][x + 1].Name != inclusion_color_name)
            { moor_neighboors.Add(bitmapValues[y + 1][x + 1]); }


            if (moor_neighboors.Count() == 0)
            {
                return bitmapValues[y][x];
            }
            else
            {
                moor_neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                Color mostOftenCol = moor_neighboors[0];
                int mostOften = moor_neighboors.Count(a => a == mostOftenCol);
                if (mostOften > 2)
                {
                    return mostOftenCol;
                }
                else
                {
                    return bitmapValues[y][x];
                }
            }


        }

        private Color Rule_4(int x, int y, List<List<Color>> bitmapValues)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 101);
            if(random<= System.Convert.ToInt32(propability_tbox.Text))
            { 
                List<Color> moor_neighboors = new List<Color>();
                if (y - 1 > -1 && bitmapValues[y - 1][x].Name != "0" && bitmapValues[y - 1][x].Name != inclusion_color_name)
                { moor_neighboors.Add(bitmapValues[y - 1][x]); }

                if (y + 1 < height && bitmapValues[y + 1][x].Name != "0" && bitmapValues[y + 1][x].Name != inclusion_color_name)
                { moor_neighboors.Add(bitmapValues[y + 1][x]); }

                if (x - 1 > -1 && bitmapValues[y][x - 1].Name != "0" && bitmapValues[y][x - 1].Name != inclusion_color_name)
                { moor_neighboors.Add(bitmapValues[y][x - 1]); }

                if (x + 1 < width && bitmapValues[y][x + 1].Name != "0" && bitmapValues[y][x + 1].Name != inclusion_color_name)
                { moor_neighboors.Add(bitmapValues[y][x + 1]); }

                if (x - 1 > -1 && y - 1 > -1 && bitmapValues[y - 1][x - 1].Name != "0" && bitmapValues[y - 1][x - 1].Name != inclusion_color_name)
                { moor_neighboors.Add(bitmapValues[y - 1][x - 1]); }

                if (y - 1 > -1 && x + 1 < width && bitmapValues[y - 1][x + 1].Name != "0" && bitmapValues[y - 1][x + 1].Name != inclusion_color_name)
                { moor_neighboors.Add(bitmapValues[y - 1][x + 1]); }

                if (x - 1 > -1 && y + 1 < height && bitmapValues[y + 1][x - 1].Name != "0" && bitmapValues[y + 1][x - 1].Name != inclusion_color_name)
                { moor_neighboors.Add(bitmapValues[y + 1][x - 1]); }

                if (x + 1 < width && y + 1 < height && bitmapValues[y + 1][x + 1].Name != "0" && bitmapValues[y + 1][x + 1].Name != inclusion_color_name)
                { moor_neighboors.Add(bitmapValues[y + 1][x + 1]); }

                if (moor_neighboors.Count() == 0)
                {
                    return bitmapValues[y][x];
                }
                else
                {
                    moor_neighboors.GroupBy(elem => elem).OrderBy(elem => elem.Count());
                    Color mostOftenCol = moor_neighboors[0];
                    return mostOftenCol;
                }
            }
            else
            {
                return bitmapValues[y][x];
            }
        }

        private List<List<Color>> GetBitmapValues(Bitmap bitmap)
            {

            List<List<Color>> bitmapValues = new List<List<Color>>();

            for (int i = 0; i < height; i++)
            {
                var widthValuesList = new List<Color>();
                for (int j = 0; j < width; j++)
                {
                    widthValuesList.Add(bitmap.GetPixel(j, i));
                }

                bitmapValues.Add(widthValuesList);
            }

            return bitmapValues;
            }

        private Bitmap CreateBitmapFromListValues(List<List<Color>> bitmapValues)
        {

            if (!bitmapValues.Any())
            {
                return null;
            }


            Bitmap bmp_next_step = new Bitmap(width, height);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bmp_next_step.SetPixel(j, i, bitmapValues[i][j]);
                }

            }

            return bmp_next_step;
        }


        private async void start_bt_Click(object sender, EventArgs e)
        {

            step = false;
            width = main_pct.Width;
            height = main_pct.Height;
            var NeighboorOpt = neighboors_cbox.Text;
            var PH_Opt = phopt_cbox.Text;
            var bitmapValues = GetBitmapValues(bmp_now);


            await Task.Run(() => MyMethodAsync(bitmapValues, NeighboorOpt, PH_Opt));
        }

        private void clr_bt_Click(object sender, EventArgs e)
        {
            step = true;
            //Image img = main_pct.Image;
            //img?.Dispose();
            bmp_now = new Bitmap(1000, 1000);
            main_pct.Image = bmp_now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            whileFlag = false;
        }

        private void GBCcheck_box_CheckedChanged(object sender, EventArgs e)
        {
            switch(GBCcheck_box.Checked)
            {
                case true:
                    {
                        GBC = true;
                        neighboors_cbox.Text = "Moore’a";
                        neighboors_cbox.Enabled = false;
                        phopt_cbox.Enabled = false;
                        propability_tbox.Text = "80";
                        break;
                    }
                case false:
                    {
                        GBC = false;
                        neighboors_cbox.Enabled = true;
                        phopt_cbox.Enabled = true;
                        break;
                    }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void exportBt_Click(object sender, EventArgs e)
        {
            string localDate = DateTime.Now.ToString("MM.dd.yyyy HH_mm_ss");

            string path = "C:\\Cellar Automata\\" + localDate + ".png";
            bmp_now.Save(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Cellar Automata\\";
                openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            bmp_now = new Bitmap(filePath);
            main_pct.Image = bmp_now;
        }
    }
}
