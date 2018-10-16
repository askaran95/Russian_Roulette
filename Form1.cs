using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PlayGame : Form
    {
        int ld, st;
        public static int Sn;
        int t = 2;
        public PlayGame()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1 .Visible = true;
            Image img = Image.FromFile(@"C:\Users\SS077\Desktop\WindowsFormsApp1\WindowsFormsApp2\sounds\2.gif");
            pictureBox1.Image = img;
           

            play ran = new play();
            Sn = ran.random_number();
          

            button4.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // below code helps to show the picbox
            pictureBox1.Visible = true;
            Image img = Image.FromFile(@"C:\Users\SS077\Desktop\WindowsFormsApp1\WindowsFormsApp2\sounds\1.gif");
            pictureBox1.Image = img;
            
            //below code is for uploading sound affect

            // below code is helps to load only 1 bullet.
            ld = 1;

            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new PlayGame()).Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // below code helps to show the picbox
            pictureBox1.Visible = true;
            //below code is for uploading the image
            Image img = Image.FromFile(@"C:\Users\SS077\Desktop\WindowsFormsApp1\WindowsFormsApp2\sounds\3.gif");
            pictureBox1.Image = img;
            // below code is for uploading the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\SS077\Desktop\WindowsFormsApp1\WindowsFormsApp2\sounds\3.wav");
            player.Play();
            do
            {
                if (st == 0 && ld == Sn)
                {
                    MessageBox.Show("you won and your score is 10");
                    st = 3; 
                     button4.Enabled = false;
                }
                else if (st == 1 && ld == Sn)
                {
                    MessageBox.Show("you won and your score is 5");
                    st = 3;
                    t = t - 1;

                }
                else if (st == 2)
                {
                    MessageBox.Show("you loose");
                    st = 3;
                    t = t - 1;

                }
                else
                {
                    st++;
                    play spinobj = new play();
                    Sn = spinobj.spin_chamber(Sn);
                                       
                }
            }
            while (st <= 2);

            if (t == 0)
            {
                button4.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                t = 2;
            }



        }


       
    }
 }

