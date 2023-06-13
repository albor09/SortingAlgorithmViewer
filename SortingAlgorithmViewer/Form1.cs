using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortingAlgorithmViewer.Src;
using SortingAlgorithmViewer.Src.Algs;

namespace SortingAlgorithmViewer
{
    public partial class Form1 : Form
    {
        private bool done = false;

        private int arrayLength;
        private int savedDelay;

        private SortingArray sortingArray;
        private SortingViewer sortingViewer;
        private SortingSyncContoller syncContoller;
        private Algorithm al;

        private Thread t;

        public Form1()
        {
            InitializeComponent();

            arrayLength = arrLengthTrBar.Value;

            syncContoller = new SortingSyncContoller();
            sortingViewer = new SortingViewer(pictureBox1, syncContoller, Color.Red);
            sortingArray = new SortingArray(arrayLength, ArrayGenerationType.ShuffleIncrease, sortingViewer);

            sortingViewer.SetArray(sortingArray.GetUnwrappedArray());
            sortingViewer.SetDelay(delayTrBar.Value * delayTrBar.Value);

            delayV.Text = sortingViewer.Delay.ToString();
            arrLengthV.Text = arrLengthTrBar.Value.ToString();

            t = new Thread(Wrapper);

            al = new BubbleSort();
            comboBox1.SelectedIndex = 0;
        }

        private void Wrapper()
        {
            al.Sorting(sortingArray);
            done = true;
            sortingArray.CheckArray();
        }


        private void delayTrBar_Scroll(object sender, EventArgs e)
        {
            int delay = delayTrBar.Value * delayTrBar.Value;
            delayV.Text = delay.ToString();
            sortingViewer.SetDelay(delay);
        }

        private void arrLengthTrBar_Scroll(object sender, EventArgs e)
        {
            arrLengthV.Text = arrLengthTrBar.Value.ToString();
            arrayLength = arrLengthTrBar.Value;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            sortingViewer.CalculateDrawSize();
            pictureBox1.Invalidate();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            t.Abort();

            sortingArray = new SortingArray(arrayLength, ArrayGenerationType.ShuffleIncrease, sortingViewer);
            sortingViewer.SetArray(sortingArray.GetUnwrappedArray());
            pictureBox1.Invalidate();

            al = Helper.AlgByIndex(comboBox1.SelectedIndex);

            t = new Thread(Wrapper);
            done = false;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (done)
                refreshBtn_Click(0, new EventArgs());

            if (!t.IsAlive)
            {
                t.Start();
                return;
            }

            if (syncContoller.IsPaused)
            {
                sortingViewer.SetDelay(savedDelay);
                syncContoller.Tcs.SetResult(true);
                syncContoller.IsPaused = false;
            }
            else
            {
                savedDelay = sortingViewer.Delay;
                sortingViewer.SetDelay(0);
                syncContoller.IsPaused = true;
            }
        }

        private void stepBtn_Click(object sender, EventArgs e)
        {
            if (done)
                return;
            if (syncContoller.IsPaused)
                syncContoller.Tcs.SetResult(true);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/albor09");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t.IsAlive)
                return;
            al = Helper.AlgByIndex(comboBox1.SelectedIndex);
            t = new Thread(Wrapper);

        }
    }
}
