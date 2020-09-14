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

namespace Main_Window
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            //SidePanel.Height = button1.Height;
            //SidePanel.Top = button1.Top;
            frontControl2.BringToFront();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            registrationUCcs1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            attendance1.BringToFront();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frontControl2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            report1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            changePass1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            deleteUserUC1.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
