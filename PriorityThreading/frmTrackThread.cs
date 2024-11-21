using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityThreading
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }
        Thread threadA = new Thread(MyThreadClass.Thread1);
        Thread threadB = new Thread(MyThreadClass.Thread2);
        Thread threadC = new Thread(MyThreadClass.Thread1);
        Thread threadD = new Thread(MyThreadClass.Thread2);
        private void Form1_Load(object sender, EventArgs e)
        {
            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            ThreadLabel.Text = "- Thread Starts -";
            Console.WriteLine("- Thread Starts -");

            threadA.Start();
            threadC.Start();
            threadB.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            ThreadLabel.Text = "- End of Thread -";
            Console.WriteLine("- End of Thread -");
        }
    }
    //
    public class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;
            for (int a = 0; a <= 2; a++)
            {               
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + a);
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            
            for (int a = 0; a <= 5 ; a++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + a);
                Thread.Sleep(1500);
            }
        }
    }

}
