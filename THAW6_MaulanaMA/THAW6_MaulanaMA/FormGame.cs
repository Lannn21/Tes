using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THAW6_MaulanaMA
{
    public partial class FormGame : Form
    {
        
        public FormGame()
        {
            InitializeComponent();
        }
        public static int text = 0;
        static int aa = 0;
        List<string> keyboard = new List<string>() { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Enter", "Z", "X", "C", "V", "B", "N", "M", "Delete" };
        List<Button> btnn1 = new List<Button>();
        List<Button> btnn2 = new List<Button>();
        int cnt = 0;
        int pencet = 0;
        private void FormGame_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            int keyx = 240;
            int keyy = 50;
            for (int i = 0; i < text; i++)
            {
                for (int m = 0; m < 5 ; m++)
                {
                    Button btn1 = new Button();
                    btn1.Size = new System.Drawing.Size(40, 40);
                    btn1.Location = new Point(x, y);
                    btn1.Tag = cnt;
                    cnt++;
                    x += 40;
                    btn1.Click += Buttonclick;
                    btnn1.Add(btn1);
                    Controls.Add(btn1);
                }
                x = 10;
                y += 40;
            }
            cnt = 0;
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    keyx = 240;
                    keyy = 50;
                    for (int m = 0; m < 10; m++)
                    {
                        Button btn2 = new Button();
                        btn2.Size = new System.Drawing.Size(35, 35);
                        btn2.Location = new Point(keyx, keyy);
                        btn2.Tag = keyboard[cnt].ToString();
                        btn2.Text = keyboard[cnt].ToString();
                        keyx += 35;
                        cnt++;
                        btn2.Click += Buttonclick;
                        btnn2.Add(btn2);
                        Controls.Add(btn2);
                    }
                }
                else
                {
                    keyx = 260;
                    keyy += 35;
                    for (int m = 0; m < 9; m++)
                    {
                        Button btn3 = new Button();
                        btn3.Size = new System.Drawing.Size(35, 35);
                        btn3.Location = new Point(keyx, keyy);
                        btn3.Tag = keyboard[cnt].ToString();
                        btn3.Text = keyboard[cnt].ToString();
                        if (keyboard[cnt].ToString() == "Enter")
                        {
                            btn3.Location = new Point(keyx - 35, keyy);
                            btn3.Size = new Size(70, 30);
                            btn3.Click += Buttonenter;
                        }
                        else if (keyboard[cnt].ToString() == "Delete")
                        {
                            btn3.Location = new Point(keyx, keyy);
                            btn3.Size = new Size(70, 30);
                            btn3.Click += Buttondelete;
                        }
                        else
                        {
                            btn3.Click += Buttonclick;
                        }
                        keyx += 35;
                        cnt++;
                        btnn2.Add(btn3);
                        Controls.Add(btn3);
                    }
                }
            }
        }

        private void Buttonclick (object sender, EventArgs e)
        {
            Button klik = sender as Button;
            if (pencet < 5)
            {
                btnn1[pencet].Text = klik.Tag.ToString();
                pencet++;
            }
        }
        private void Buttonenter(object sender, EventArgs e)
        {

        }
        private void Buttondelete(object sender, EventArgs e)
        {
            if(pencet > aa)
            {
                btnn1[pencet - 1].Text = "";
                pencet--;
            }
        }
    }
}
