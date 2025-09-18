using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasingThreading;
using System.Threading;
    


namespace WindowsFormsApp2
{


public partial class Form1 : Form

{
        private Thread ThreadA, ThreadB;
    public Form1()
    {
        InitializeComponent();
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Before starting thread");

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();


            Console.WriteLine("-End Of thread-");
            label2.Text = "Threading Complete";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BasicThreading_Load(object sender, EventArgs e)
    {
        


          







        }

    }
}

