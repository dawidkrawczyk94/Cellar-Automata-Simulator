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
        private static int width = 500;
        private static int height = 500;
        private static bool if_inclusion;
        private bool whileFlag;
        private bool step;
        private readonly string inclusion_color_name = "ff000000";
        private readonly string phase_color_name = "ffff1493";
        private Color phase_color = Color.DeepPink;
        private bool GBC = false;
        private List<string> selected_color_list = new List<string>();
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
                    phopt_cbox.Enabled = false;
                    break;

                case "Moore’a":
                    phopt_cbox.Enabled = false;
                    break;
                case "Hexagonal":
                    phopt_cbox.Enabled = true;
                    break;
                case "Pentagonal":
                    phopt_cbox.Enabled = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if_inclusion = false;
            neighboors_cbox.Text = "von Neumanna";
            widthBox.Value = width;
            heightBox.Value = height;
            xPropability.Value = 80;
            phopt_cbox.Items.Add("left");
            phopt_cbox.Items.Add("right");
            phopt_cbox.Items.Add("random");
            phopt_cbox.Text = "random";
            selected_color_list.Add(inclusion_color_name);
            selected_color_list.Add(phase_color_name);
            selected_label.Text = "Selected grain count: " + (selected_color_list.Count() - 2);

        }

        private void width_tbox_TextChanged(object sender, EventArgs e)
        {
            if (widthBox.Value>0)
            {
                width = Decimal.ToInt32(widthBox.Value);
                main_pct.Size = new System.Drawing.Size(width, main_pct.Height);
            }
        }

        private void height_tbox_TextChanged(object sender, EventArgs e)
        {
            if (heightBox.Value>0)
            {
                height = Decimal.ToInt32(heightBox.Value);
                main_pct.Size = new System.Drawing.Size(main_pct.Width, height);
            }
        }


        private void main_pct_Click(object sender, EventArgs e)
        {
            if (select_bt.BackColor == Color.Green)
            {
                Color pixel_color = bmp_now.GetPixel(MousePosition.X - this.Location.X - main_pct.Location.X - 4, MousePosition.Y - this.Location.Y - main_pct.Location.Y - 30);
                if (selected_color_list.Contains(pixel_color.Name))
                {
                    selected_color_list.Remove(pixel_color.Name);
                    selected_label.Text = "Selected grain count: " + selected_color_list.Count();
                }
                else
                {
                    selected_color_list.Add(pixel_color.Name);
                    selected_label.Text = "Selected grain count: " + (selected_color_list.Count() - 2);
                }
               


            }
            else
            {
                if (if_inclusion)
                {
                    if (R.Value > 0)
                    {
                        Rectangle rect = new Rectangle(MousePosition.X - this.Location.X - main_pct.Location.X - 4, MousePosition.Y - this.Location.Y - main_pct.Location.Y - 30, Decimal.ToInt32(R.Value) * 2, Decimal.ToInt32(R.Value) * 2);
                        SolidBrush grayBrush = new SolidBrush(Color.Black);
                        var gph_n = Graphics.FromImage(bmp_now);
                        gph_n.FillEllipse(grayBrush, rect);
                        main_pct.Image = bmp_now;
                    }

                }
                else
                {
                    Random rnd = new Random();
                    Color random_color = Color.FromArgb(255, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    bmp_now.SetPixel(MousePosition.X - this.Location.X - main_pct.Location.X - 4, MousePosition.Y - this.Location.Y - main_pct.Location.Y - 30, random_color);
                    current_color_pct.BackColor = random_color;
                    main_pct.Image = bmp_now;
                }
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
            if (R.Value>0)
            {
                Bitmap bm = new Bitmap(inclusion_pct.Width, inclusion_pct.Height);
                Graphics gr = Graphics.FromImage(bm);
                Rectangle rect = new Rectangle(inclusion_pct.Width / 2 - Decimal.ToInt32(R.Value), inclusion_pct.Height / 2 - Decimal.ToInt32(R.Value), Decimal.ToInt32(R.Value) * 2, Decimal.ToInt32(R.Value) * 2);
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

            if (nbh1_x > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0" &&  selected_color_list.Contains(bitmapValues[nbh1_y][nbh1_x].Name)==false)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && bitmapValues[nbh2_y][nbh2_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh2_y][nbh2_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh3_y][nbh3_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh4_y][nbh4_x].Name) == false)
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


            if (nbh1_x > -1 && nbh1_y > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh1_y][nbh1_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && nbh2_y > -1 && bitmapValues[nbh2_y][nbh2_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh2_y][nbh2_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_x > -1 && nbh3_y < height && bitmapValues[nbh3_y][nbh3_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh3_y][nbh3_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_x < width && nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh4_y][nbh4_x].Name) == false)
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

            if (nbh1_x > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh1_y][nbh1_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && bitmapValues[nbh2_y][nbh2_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh2_y][nbh2_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh3_y][nbh3_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh4_y][nbh4_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (nbh5_x > -1 && nbh5_y > -1 && bitmapValues[nbh5_y][nbh5_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh5_y][nbh5_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh5_y][nbh5_x]); }

            if (nbh6_x < width && nbh6_y < height && bitmapValues[nbh6_y][nbh6_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh6_y][nbh6_x].Name) == false)
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


            if (nbh1_x > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh1_y][nbh1_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && bitmapValues[nbh2_y][nbh2_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh2_y][nbh2_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh3_y][nbh3_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh4_y][nbh4_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (nbh5_x < width && nbh5_y > -1 && bitmapValues[nbh5_y][nbh5_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh5_y][nbh5_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh5_y][nbh5_x]); }

            if (nbh6_x > -1 && nbh6_y < height && bitmapValues[nbh6_y][nbh6_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh6_y][nbh6_x].Name) == false)
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


            if (nbh1_x > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh1_y][nbh1_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x > -1 && nbh2_y > -1 && nbh2_y > -1 && bitmapValues[nbh2_y][nbh2_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh2_y][nbh2_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }


            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh3_y][nbh3_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }
            

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh4_y][nbh4_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (nbh5_x > -1 && nbh5_y < height && bitmapValues[nbh5_y][nbh5_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh5_y][nbh5_x].Name) == false)
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


            if (nbh1_x < width && nbh1_y > -1 && bitmapValues[nbh1_y][nbh1_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh1_y][nbh1_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh1_y][nbh1_x]); }

            if (nbh2_x < width && nbh2_y > -1 && bitmapValues[nbh2_y][nbh2_x].Name != "0"  && selected_color_list.Contains(bitmapValues[nbh2_y][nbh2_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh2_y][nbh2_x]); }

            if (nbh3_y > -1 && bitmapValues[nbh3_y][nbh3_x].Name != "0" &&  selected_color_list.Contains(bitmapValues[nbh3_y][nbh3_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh3_y][nbh3_x]); }

            if (nbh4_y < height && bitmapValues[nbh4_y][nbh4_x].Name != "0" && selected_color_list.Contains(bitmapValues[nbh4_y][nbh4_x].Name) == false)
            { neighboors.Add(bitmapValues[nbh4_y][nbh4_x]); }

            if (nbh5_x < width && nbh5_y < height && bitmapValues[nbh5_y][nbh5_x].Name != "0" &&  selected_color_list.Contains(bitmapValues[nbh5_y][nbh5_x].Name) == false)
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
            if (y - 1 > -1 && bitmapValues[y - 1][x].Name != "0" &&  selected_color_list.Contains(bitmapValues[y - 1][x].Name) == false)
            { moor_neighboors.Add(bitmapValues[y - 1][x]); }

            if (y + 1 < height && bitmapValues[y + 1][x].Name != "0"  && selected_color_list.Contains(bitmapValues[y + 1][x].Name) == false)
            { moor_neighboors.Add(bitmapValues[y + 1][x]); }

            if (x - 1 > -1 && bitmapValues[y][x - 1].Name != "0" && selected_color_list.Contains(bitmapValues[y][x - 1].Name) == false)
            { moor_neighboors.Add(bitmapValues[y][x - 1]); }

            if (x + 1 < width && bitmapValues[y][x + 1].Name != "0" &&  selected_color_list.Contains(bitmapValues[y][x+1].Name) == false)
            { moor_neighboors.Add(bitmapValues[y][x + 1]); }

            if (x - 1 > -1 && y - 1 > -1 && bitmapValues[y - 1][x - 1].Name != "0" && selected_color_list.Contains(bitmapValues[y - 1][x-1].Name) == false)
            { moor_neighboors.Add(bitmapValues[y - 1][x - 1]); }

            if (y - 1 > -1 && x + 1 < width && bitmapValues[y - 1][x + 1].Name != "0" && selected_color_list.Contains(bitmapValues[y - 1][x+1].Name) == false)
            { moor_neighboors.Add(bitmapValues[y - 1][x + 1]); }

            if (x - 1 > -1 && y + 1 < height && bitmapValues[y + 1][x - 1].Name != "0" && selected_color_list.Contains(bitmapValues[y + 1][x-1].Name) == false)
            { moor_neighboors.Add(bitmapValues[y + 1][x - 1]); }

            if (x + 1 < width && y + 1 < height && bitmapValues[y + 1][x + 1].Name != "0" && selected_color_list.Contains(bitmapValues[y + 1][x+1].Name) == false)
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
            if (y - 1 > -1 && bitmapValues[y - 1][x].Name != "0" && selected_color_list.Contains(bitmapValues[y - 1][x].Name) == false)
            { moor_neighboors.Add(bitmapValues[y - 1][x]); }

            if (y + 1 < height && bitmapValues[y + 1][x].Name != "0" && selected_color_list.Contains(bitmapValues[y + 1][x].Name) == false)
            { moor_neighboors.Add(bitmapValues[y + 1][x]); }

            if (x - 1 > -1 && bitmapValues[y][x - 1].Name != "0" && selected_color_list.Contains(bitmapValues[y][x -1].Name) == false)
            { moor_neighboors.Add(bitmapValues[y][x - 1]); }

            if (x + 1 < width && bitmapValues[y][x + 1].Name != "0" && selected_color_list.Contains(bitmapValues[y][x + 1].Name) == false)
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


            if (x - 1 > -1 && y - 1 > -1 && bitmapValues[y - 1][x - 1].Name != "0" &&  selected_color_list.Contains(bitmapValues[y - 1][x - 1].Name) == false)
            { moor_neighboors.Add(bitmapValues[y - 1][x - 1]); }

            if (y - 1 > -1 && x + 1 < width && bitmapValues[y - 1][x + 1].Name != "0" &&  selected_color_list.Contains(bitmapValues[y - 1][x + 1].Name) == false)
            { moor_neighboors.Add(bitmapValues[y - 1][x + 1]); }

            if (x - 1 > -1 && y + 1 < height && bitmapValues[y + 1][x - 1].Name != "0" &&  selected_color_list.Contains(bitmapValues[y + 1][x - 1].Name) == false)
            { moor_neighboors.Add(bitmapValues[y + 1][x - 1]); }

            if (x + 1 < width && y + 1 < height && bitmapValues[y + 1][x + 1].Name != "0" && selected_color_list.Contains(bitmapValues[y + 1][x + 1].Name) == false)
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
            if(random<= xPropability.Value)
            { 
                List<Color> moor_neighboors = new List<Color>();
                if (y - 1 > -1 && bitmapValues[y - 1][x].Name != "0" && selected_color_list.Contains(bitmapValues[y - 1][x].Name) == false)
                { moor_neighboors.Add(bitmapValues[y - 1][x]); }

                if (y + 1 < height && bitmapValues[y + 1][x].Name != "0" && selected_color_list.Contains(bitmapValues[y + 1][x].Name) == false)
                { moor_neighboors.Add(bitmapValues[y + 1][x]); }

                if (x - 1 > -1 && bitmapValues[y][x - 1].Name != "0" && selected_color_list.Contains(bitmapValues[y][x - 1].Name) == false)
                { moor_neighboors.Add(bitmapValues[y][x - 1]); }

                if (x + 1 < width && bitmapValues[y][x + 1].Name != "0" && selected_color_list.Contains(bitmapValues[y][x + 1].Name) == false)
                { moor_neighboors.Add(bitmapValues[y][x + 1]); }

                if (x - 1 > -1 && y - 1 > -1 && bitmapValues[y - 1][x - 1].Name != "0" && selected_color_list.Contains(bitmapValues[y - 1][x - 1].Name) == false)
                { moor_neighboors.Add(bitmapValues[y - 1][x - 1]); }

                if (y - 1 > -1 && x + 1 < width && bitmapValues[y - 1][x + 1].Name != "0"  && selected_color_list.Contains(bitmapValues[y - 1][x + 1].Name) == false)
                { moor_neighboors.Add(bitmapValues[y - 1][x + 1]); }

                if (x - 1 > -1 && y + 1 < height && bitmapValues[y + 1][x - 1].Name != "0"  && selected_color_list.Contains(bitmapValues[y + 1][x - 1].Name) == false)
                { moor_neighboors.Add(bitmapValues[y + 1][x - 1]); }

                if (x + 1 < width && y + 1 < height && bitmapValues[y + 1][x + 1].Name != "0" && selected_color_list.Contains(bitmapValues[y + 1][x + 1].Name) == false)
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
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            if (filePath != "")
            { bmp_now = new Bitmap(filePath); }
            main_pct.Image = bmp_now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean seedswhileflag = true;
            int seed_counter = 0;
            Random rnd = new Random();

            while(seedswhileflag)
            { 
            int random_x = rnd.Next(0, main_pct.Width);
            int random_y = rnd.Next(0, main_pct.Height);
            Color random_color = Color.FromArgb(255, rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

                if (bmp_now.GetPixel(random_x, random_y).Name == "0")
                {
                    bmp_now.SetPixel(random_x, random_y, random_color);
                    seed_counter += 1;
                }

                if(seed_counter>seedsCount.Value)
                {
                    seedswhileflag = false;
                }
            }
            main_pct.Image = bmp_now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < inclusionsCount.Value; i++)
            {
                Random rnd = new Random();
                int random_x = rnd.Next(0, main_pct.Width);
                int random_y = rnd.Next(0, main_pct.Height);
                int random_r = rnd.Next(Decimal.ToInt32(minR.Value), Decimal.ToInt32(maxR.Value));
                Rectangle rect = new Rectangle(random_x, random_y, random_r * 2, random_r * 2);
                SolidBrush grayBrush = new SolidBrush(Color.Black);
                var gph_n = Graphics.FromImage(bmp_now);
                gph_n.FillEllipse(grayBrush, rect);
                
            }
            main_pct.Image = bmp_now;
        }

        private void R_ValueChanged(object sender, EventArgs e)
        {
            if (R.Value > 0)
            {
                Bitmap bm = new Bitmap(inclusion_pct.Width, inclusion_pct.Height);
                Graphics gr = Graphics.FromImage(bm);
                Rectangle rect = new Rectangle(inclusion_pct.Width / 2 - Decimal.ToInt32(R.Value), inclusion_pct.Height / 2 - Decimal.ToInt32(R.Value), Decimal.ToInt32(R.Value) * 2, Decimal.ToInt32(R.Value) * 2);
                SolidBrush grayBrush = new SolidBrush(Color.Black);
                gr.FillEllipse(grayBrush, rect);
                inclusion_pct.Image = bm;
                if_inclusion = true;
            }
        }

        private void widthBox_ValueChanged(object sender, EventArgs e)
        {
            if (widthBox.Value > 0)
            {
                width = Decimal.ToInt32(widthBox.Value);
                main_pct.Size = new System.Drawing.Size(width, main_pct.Height);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (heightBox.Value > 0)
            {
                height = Decimal.ToInt32(heightBox.Value);
                main_pct.Size = new System.Drawing.Size(main_pct.Width, height);
            }
        }

        private void select_bt_Click(object sender, EventArgs e)
        {
            if(select_bt.BackColor == Color.Green)
            {
                select_bt.BackColor = Color.White;
            }
            else
            {
                select_bt.BackColor = Color.Green;
                phase_bt.BackColor = Color.White;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selected_color_list.Clear();
            selected_color_list.Add(inclusion_color_name);
            selected_color_list.Add(phase_color_name);

            selected_label.Text = "Selected grain count: " + (selected_color_list.Count() - 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for(int x=0;x<width;x++)
            {
                for(int y=0;y<height;y++)
                {
                    if (bmp_now.GetPixel(x, y).Name!="0" && selected_color_list.Contains(bmp_now.GetPixel(x, y).Name) ==false)
                    {
                        bmp_now.SetPixel(x, y, Color.FromName("0"));
                    }

                }
            }
            main_pct.Image = bmp_now;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (bmp_now.GetPixel(x, y).Name!="0" && bmp_now.GetPixel(x, y).Name != inclusion_color_name)
                    {
                        bmp_now.SetPixel(x, y, phase_color);
                    }

                }
            }
            main_pct.Image = bmp_now;
        }
    }
  }

