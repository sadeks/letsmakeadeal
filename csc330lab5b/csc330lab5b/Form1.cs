using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csc330lab5b
{
    public partial class Form1 : Form
    {
        bool choice = true;
        string[] prizes = { "a Pair of socks!!", "an iPad mini!" ,"a Car!" };
        int randNum;
        Random ranNumberGenerator = new Random();        

        public Form1()
        {
            
            InitializeComponent();
            randNum = ranNumberGenerator.Next(0, 3);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {     
     
            //the random number is assigned to this button
            if (choice)
            {
                //randomly assign prizes 
                button1.Tag = randNum;
                if (randNum == 0)
                {
                    button2.Tag = 1;
                    button3.Tag = 2;
                }
                else if (randNum == 1)
                {
                    button2.Tag = 0;
                    button3.Tag = 2;
                }
                else
                {
                    button2.Tag = 0;
                    button3.Tag = 1;
                }

                if (Convert.ToInt32(button2.Tag) < Convert.ToInt32(button3.Tag))
                    textBox1.Text = "Door 2 has " + prizes[Convert.ToInt32(button2.Tag)] + ". You can change doors now!";
                else
                    textBox1.Text = "Door 3 has " + prizes[Convert.ToInt32(button3.Tag)] + ". You can change doors now!";
                choice = false;
            }
            else
            {
                textBox1.Text = "Congratulations you've won " + prizes[Convert.ToInt32(button1.Tag)];
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (choice)
            {
                //randomly assign prizes 
                button2.Tag = randNum;
                if (randNum == 0)
                {
                    button1.Tag = 1;
                    button3.Tag = 2;
                }
                else if (randNum == 1)
                {
                    button1.Tag = 0;
                    button3.Tag = 2;
                }
                else
                {
                    button1.Tag = 0;
                    button3.Tag = 1;
                }

                if (Convert.ToInt32(button1.Tag) < Convert.ToInt32(button3.Tag))
                    textBox1.Text = "Door 1 has " + prizes[Convert.ToInt32(button1.Tag)] + ". You can change doors now!";
                else
                    textBox1.Text = "Door 3 has " + prizes[Convert.ToInt32(button3.Tag)] + ". You can change doors now!";
                choice = false;
            }
            else
            {
                textBox1.Text = "Congratulations you've won " + prizes[Convert.ToInt32(button2.Tag)];
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (choice)
            {
                //randomly assign prizes 
                button3.Tag = randNum;
                if (randNum == 0)
                {
                    button1.Tag = 1;
                    button2.Tag = 2;
                }
                else if (randNum == 1)
                {
                    button1.Tag = 0;
                    button2.Tag = 2;
                }
                else
                {
                    button1.Tag = 0;
                    button2.Tag = 1;
                }
                if (Convert.ToInt32(button1.Tag) < Convert.ToInt32(button2.Tag))
                    textBox1.Text = "Door 1 has " + prizes[Convert.ToInt32(button1.Tag)]+ ". You can change doors now!";
                else
                    textBox1.Text = "Door 2 has " + prizes[Convert.ToInt32(button2.Tag)] + ". You can change doors now!";
                choice = false;
            }
            else
            {
                textBox1.Text = "Congratulations you've won " + prizes[Convert.ToInt32(button3.Tag)];
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
