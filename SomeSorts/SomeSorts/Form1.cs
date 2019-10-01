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

namespace SomeSorts
{
    public partial class Form1 : Form
    {
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(100);
            listBox1.Items.Add(1000);
            listBox1.Items.Add(10000);
            listBox1.Items.Add(10);
            listBox1.SelectedIndex = 3;
            bt_run.Enabled = false;
            BubbleText.Visible = false;
            ShellText.Visible = false;
            QuickText.Visible = false;
        }

        private void bt_gen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            Random rnd = new Random();
            int len = int.Parse(listBox1.SelectedItem.ToString());
            arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = rnd.Next();
            }
            

            bt_run.Enabled = true;

        }

        

        private void bt_run_Click(object sender, EventArgs e)
        {
            Thread threadBubble = new Thread(new ParameterizedThreadStart(bubbleSort));
            Thread threadShell = new Thread(new ParameterizedThreadStart(shellSort));
            Thread threadQuick = new Thread(new ParameterizedThreadStart(quickSort));
            threadBubble.Start(arr);
            threadShell.Start(arr);
            threadQuick.Start(arr);
        }

        private void bubbleSort(object arr)
        {
            var sort = new Bubble();
            var result = sort.BubbleSort((int[])arr);
            BubbleText.Text = "Bubble sort:\n" +
                                    "Iterations: " + sort.iterations +
                                    "\nChanges: " + sort.changes +
                                    "\nTotal ticks: " + sort.timer.ElapsedTicks;
        }

        private void shellSort(object arr)
        {
            var sort = new Shell();
            var result = sort.ShellSort((int[])arr);
            ShellText.Text = "Shell sort:\n" +
                                    "Iterations: " + sort.iterations +
                                    "\nChanges: " + sort.changes +
                                    "\nTotal ticks: " + sort.timer.ElapsedTicks;
        }
        private void quickSort(object arr)
        {
            var sort = new Quick();
            var result = sort.QuickSort((int[])arr);
            QuickText.Text = "Quick sort:\n" +
                                    "Iterations: " + sort.iterations +
                                    "\nChanges: " + sort.changes +
                                    "\nTotal ticks: " + sort.timer.ElapsedTicks;
        }
    }
}
