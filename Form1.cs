using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BItMyName
{

    

    public partial class Form1 : Form
    {
        private Panel panel1 = new Panel();
        private Panel panel3 = new Panel();

        public Form1()
        {
            InitializeComponent();
            Focused_color_button.BackColor = Focused_Color;
            Default_color_button.BackColor = Default_Color;

            Controls.Add(panel1);
            panel1.BackColor = Color.LightGray;
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 720);
            panel1.Top = 0;
            panel1.Left = 0;


            Controls.Add(panel3);
            panel3.Name = "panel3";
            panel3.Size = new Size(60, 720);
            panel3.Top = 0;
            panel3.Left = 720;


        }
        
        private Button[,] panel;
        private TextBox[] textbox;
        private Color Default_Color = Color.SkyBlue;
        private Color Focused_Color = Color.Red;
        private bool Write_Mode = true, Animator_Mode = false;
        private int Matryca = 12, Interval = 500, x = 0, Człony = 1;
        private string Filename = "";


        private string[] animacja;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Stream s = sender as Stream;
            
            List<string> cordy = new List<string>();
            using (StreamReader sr = new StreamReader(s))
            {
                string wiersz;
                while ((wiersz = sr.ReadLine()) != null)
                {
                    if (wiersz != "")
                        cordy.Add(wiersz);

                }
            }
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel != null)
                button3_Click(this, new EventArgs());


            Size size;
            int AddToPos;
            int LimitLicznika;
            int Panele;
            int TextBoxLocY;

            if (radioButton1.Checked == true)
            {
                size = new Size(30, 30);
                AddToPos = 30;
                LimitLicznika = 24;
                Panele = 24;
                TextBoxLocY = 5;
            }
            else if(radioButton2.Checked == true)
            {
                size = new Size(60, 60);
                AddToPos = 60;
                LimitLicznika = 12;
                Panele = 12;
                TextBoxLocY = 20;
            }else
            {
                size = new Size(90, 90);
                AddToPos = 90;
                LimitLicznika = 8;
                Panele = 8;
                TextBoxLocY = 40;
            }


            panel = new Button[Panele,Panele];

            int pos_x = 0;
            int pos_y = 0;
            int licznik_petli = 0;
            textbox = new TextBox[Panele];

            for (int i = 0; i < Panele; i++)
            {
                for (int j = 0; j < Panele; j++)
                {
                    panel[i,j] = new Button();
                    panel[i,j].Size = size;


                    panel[i,j].Left = pos_x;
                    pos_x += AddToPos;
                    panel[i,j].Top = pos_y;
                    panel[i,j].BackColor = Default_Color;
                    panel[i,j].Parent = panel1;
                    panel[i,j].Click += new EventHandler(ButtonAction);
                    

                    licznik_petli++;

                    if (licznik_petli == LimitLicznika)
                    {
                       
                        TextBox t = new TextBox();

                        textbox[i] = t;

                        t.Name = "t" + i.ToString();
                        t.Top = pos_y + TextBoxLocY;                      
                        t.Size = new Size(60,30);
                        t.Parent = panel3;
                        t.TextChanged += new EventHandler(_TextChanged);
                        

                        licznik_petli = 0;
                        pos_x = 0;
                        pos_y += AddToPos;

                    }
                }
            }


            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                radioButton3.Checked = false;
                Matryca = 12;

            }
            else if (radioButton1.Checked == true)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                Matryca = 24;

            }else if(radioButton3.Checked == true)
            {

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = true;
                Matryca = 8;


            }
        }

        protected void ButtonAction(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (Write_Mode)
            {
                

                if (button.BackColor == Focused_Color)
                {
                    button.BackColor = Default_Color;

                }
                else button.BackColor = Focused_Color;
            }

            Pozycja_Label.Text = "Position: " + button.Cordinates().ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l = Matryca;
           
            if (textbox != null)
            {
                if (Write_Mode)
                {


                    int dlugosc = l - 1;

                    double s = 0;

                    for (int i = 0; i < l; i++)
                    {
                        for (int j = 0; j < l; j++)
                        {

                            if (panel[i, j].BackColor != Default_Color)
                            {

                                s += Math.Pow(2, dlugosc);
                                dlugosc--;
                            }
                            else dlugosc--;

                        }

                        textbox[i].Text = s.ToString();
                        s = 0;
                        dlugosc = l - 1;
                    }
                }
                else
                {

                    for (int i = 0; i < l; i++)
                    {

                        string s = "",o = "";
                        
                        int liczba;

                        if (textbox[i].Text != "")
                            liczba = int.Parse(textbox[i].Text.ToString());
                        else continue;

                        do
                        {
                            if (liczba != 1)
                            {
                                if (liczba % 2 == 1)
                                {
                                    o += "1";
                                    liczba--;
                                    liczba /= 2;
                                }
                                else
                                {
                                    o += "0";
                                    liczba /= 2;
                                }
                            }
                            else { s += "1"; break; }

                        } while (liczba != 0);

                        for (int w = o.Length - 1 ; w >= 0; w--)
                            s += o[w];

                        //----------------------------------------------------------------
                        if (s.Length != l)
                        {
                            int ile = l - s.Length;
                            if (ile > 0)
                            for (int k = 0; k < ile; k++)
                                s = s.Insert(0, "0");
                        }

                        for (int j = 0; j < l; j++)
                        {
                            if (s[j] == '1')
                                panel[i, j].BackColor = Focused_Color;
                            else panel[i, j].BackColor = Default_Color;
                        }


                    }


                }
            }
        }

        private void Default_color_button_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Default_Color = colorDialog1.Color;
                Default_color_button.BackColor = Default_Color;
            }
        }

        private void Focused_color_button_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Focused_Color = colorDialog1.Color;
                Focused_color_button.BackColor = Focused_Color;
            }
        }

        private void WriteModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WriteModeCheck.Checked == true)
            {
                Write_Mode = true;
                ReadMode_Check.Checked = false;
                WriteModeCheck.Checked = true;
                MultiButton.Text = "Calculate";
                

            }else if(WriteModeCheck.Checked == false)
            {

                Write_Mode = false;
                ReadMode_Check.Checked = true;
                WriteModeCheck.Checked = false;
                MultiButton.Text = "Read";
            }
            
            
        }

        private void ReadMode_Check_CheckedChanged(object sender, EventArgs e)
        {

            if (ReadMode_Check.Checked == true)
            {
                Write_Mode = false;
                ReadMode_Check.Checked = true;
                WriteModeCheck.Checked = false;
                
            }
            else if (ReadMode_Check.Checked == false)
            {

                Write_Mode = true;
                ReadMode_Check.Checked = false;
                WriteModeCheck.Checked = true;

            }


        }

        private void _TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            int i;
            if(t.Text.Length != 0)
            if(int.TryParse(t.Text,out i) == false)
            {
                string text = t.Text;
                text = text.Remove(text.Length-1 );
                t.Text = text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(panel1);
            panel1 = new Panel();
            Controls.Add(panel1);
            panel1.BackColor = Color.LightGray;
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 720);
            panel1.Top = 0;
            panel1.Left = 0;

            textbox = null;
            panel = null;

            Controls.Remove(panel3);
            panel3 = new Panel();
            Controls.Add(panel3);
            panel3.Name = "panel3";
            panel3.Size = new Size(60, 720);
            panel3.Location = new Point(720, 0);


        }

        #region Files
        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (textbox != null)
            {
                saveFileDialog1.Filter = "BitMyName Files (*.BitMyName) | *.BitMyName";
                Cooridnates Save = new Cooridnates();

                WriteModeCheck.Checked = true;
                button1_Click(this,new EventArgs());

                int matryca = Matryca;
               

                string[] cordy = new string[matryca];

                

                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    for (int i = 0; i < matryca; i++)
                    {
                        cordy[i] = textbox[i].Text;
                    }

                    string filename = saveFileDialog1.FileName;
                    Save.Save_To_File(filename, cordy);

                }
            }

        }

        private void Read_Button_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                timer1.Enabled = false;
                Play_Anim_Button.Text = "Start";
                Cooridnates Read = new Cooridnates();
                string[] cordy = new string[1];
                if (openFileDialog1.FileName.EndsWith(".BitMyName") == true)
                {
                    cordy = Read.Read_From_File(openFileDialog1.FileName);


                    Filename = openFileDialog1.FileName;


                    button3_Click(this, new EventArgs());
                    if (cordy.Length == 24)
                    {
                        radioButton1.Checked = true;
                        

                    }
                    else if (cordy.Length == 12)
                    {
                        radioButton2.Checked = true;
                        

                    }else
                    {
                        radioButton3.Checked = true;
                    }

                    button2_Click(this, new EventArgs());

                    int i = 0;
                    foreach (string c in cordy)
                    {
                        textbox[i].Text = c;
                        i++;
                    }

                    ReadMode_Check.Checked = true;
                    button1_Click(this, new EventArgs());
                }
                else
                {
                    int m = Read.Matrix_Check(Filename);
                    Filename = openFileDialog1.FileName;
                    if (m == 12)
                    {
                        radioButton2.Checked = true;
                        button2_Click(this, new EventArgs());
                    }
                    else if(m == 24)
                    {
                        radioButton1.Checked = true;
                        button2_Click(this, new EventArgs());
                    }else
                    {
                        radioButton3.Checked = true;
                        button2_Click(this, new EventArgs());

                    }


                }
            }
        }
        #endregion

        private void Create_Animation_Button_Click(object sender, EventArgs e)
        {
            if (!Animator_Mode)
            {
                saveFileDialog1.Filter = "Animation files (*.BitMyAnim)|*.BitMyAnim";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (panel == null)
                        button2_Click(this, new EventArgs());
                    Add_Frame_Button.Enabled = true;
                    Next_frame_button.Enabled = true;
                    previous_frame_button.Enabled = true;
                    Save_frame_button.Enabled = true;
                    Delete_frame_button.Enabled = true;

                    Filename = saveFileDialog1.FileName;
                    Cooridnates save = new Cooridnates();
                    save.Save_To_File(saveFileDialog1.FileName, new string[0]);

                    button2.Enabled = false;
                    button3.Enabled = false;
                    Create_Animation_Button.Text = "Save";
                    Animator_Mode = true;
                    groupBox1.Enabled = false;
                    Save_Button.Enabled = false;
                    Read_Button.Enabled = false;
                }
                
            }else
            {
                Animator_Mode = false;
                Create_Animation_Button.Text = "Create";
                button2.Enabled = true;
                button3.Enabled = true;
                Filename = "";
                button3_Click(this, new EventArgs());
                Add_Frame_Button.Enabled = false;
                Next_frame_button.Enabled = false;
                previous_frame_button.Enabled = false;
                Save_frame_button.Enabled = false;
                Delete_frame_button.Enabled = false;
                groupBox1.Enabled = true;
                Save_Button.Enabled = true;
                Read_Button.Enabled = true;
            }
        }

        private void Add_Frame_Button_Click(object sender, EventArgs e)
        {
            
            button2_Click(this, new EventArgs());
        }


        private void Play_Anim_Button_Click(object sender, EventArgs e)
        {
            if (Filename != null)
            {
                if (timer1.Enabled == false)
                {
                    Cooridnates animator = new Cooridnates();

                    string[] anim = animator.Read_From_File_Anim(Filename);
                    Interval = int.Parse(textBox1.Text);
                    animacja = new string[anim.Length];
                    for (int i = 0; i < anim.Length; i++)
                    {

                        string s = "", o = "";

                        int liczba;

                        if (anim[i] != "")
                            liczba = int.Parse(anim[i]);
                        else continue;

                        do
                        {
                            if (liczba != 1)
                            {
                                if (liczba % 2 == 1)
                                {
                                    o += "1";
                                    liczba--;
                                    liczba /= 2;
                                }
                                else
                                {
                                    o += "0";
                                    liczba /= 2;
                                }
                            }
                            else { s += "1"; break; }

                        } while (liczba != 0);

                        for (int w = o.Length - 1; w >= 0; w--)
                            s += o[w];

                        //----------------------------------------------------------------
                        if (s.Length != Matryca)
                        {
                            int ile = Matryca - s.Length;
                            if (ile > 0)
                                for (int k = 0; k < ile; k++)
                                    s = s.Insert(0, "0");
                        }
                        animacja[i] = s;
                        Człony = animacja.Length / Matryca;
                    }

                    timer1.Interval = Interval;
                    timer1.Enabled = true;
                    Play_Anim_Button.Text = "Stop";
                }
                else { timer1.Enabled = false; Play_Anim_Button.Text = "Play"; }
            }
            }

        private void Save_frame_button_Click(object sender, EventArgs e)
        {
            button1_Click(this, new EventArgs());
            string[] cordy = new string[Matryca+1];

            for (int i = 0; i < Matryca; i++)
            {
                cordy[i] = textbox[i].Text;
            }
            


            Cooridnates Save = new Cooridnates();
            Save.Save_To_File_Anim(saveFileDialog1.FileName, cordy);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (x < Człony-1) x++;
            else x = 0;
            
            for (int i = 0; i < Matryca; i++)
            {
                        string s = animacja[i + (Matryca * x)];
                for (int j = 0; j < Matryca ; j++)
                {
                    if (s[j] == '1')
                        panel[i, j].BackColor = Focused_Color;
                    else panel[i, j].BackColor = Default_Color;

                }
            }
            

           
        }



        
    }



    struct Position
    {
        public Position(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public int X;
        public int Y;

        public override string ToString()
        {
            string result = "X=" + X.ToString() + " Y=" + Y.ToString();
            return result;
        }
    }

    static class Extensions
    {


        public static Position Cordinates(this Button panel)
        {
            if (panel.Height == 30)
            {

                return new Position(panel.Location.X / 30, panel.Location.Y / 30);

            }
            else if (panel.Height == 60)
            {
                return new Position(panel.Location.X / 60, panel.Location.Y / 60);


            }
            else
            {
                return new Position(panel.Location.X / 90, panel.Location.Y / 90);

            }

       }
    }
}
