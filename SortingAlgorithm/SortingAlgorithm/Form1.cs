using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithm
{
    public partial class Form1 : Form
    {
        #region Variables;
        // A few Variables for the Application
        public Graphics g;
        public Random rnd = new Random();
        public int[] test;
        public int k = -1;
        public int trackArraySize = 5;
        public int speedBubbleSort = 405;
        public SolidBrush brush = new SolidBrush(Color.Red);
        public int highestNumberholderBubble = -1;
        public int holderQuickSort = -1;
        public int num = -1;
        #endregion


        #region Form Loads
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // disables the buttons 
            btnSortAlge.Enabled = false;
            BtnQuickSort.Enabled = false;


            // Sets the Min and Max for the Array
            this.trackBarSizeArray.Maximum = 105;
            this.trackBarSizeArray.Minimum = 5;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void BtnQuickSort_Click(object sender, EventArgs e)
        {
            // Calls Quick Sort Algorithm
            QuickSort(test);
            k = 0;
            pcbShowArray.Refresh();
        }
        private void btnSortAlge_Click(object sender, EventArgs e)
        {
            // Calles Sort Algorithm
            BubbleSort();
            k = 0;
            pcbShowArray.Refresh();
        }
        private void pcbShowArray_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            
            // k said which button you have Pressed and it will call the right Methode for it
            

            if (k == 0)
            {
                // 

                ShowArray();
            }
            else if (k == 1)
            {
            }
            

        }
        private void pcbShowArray_Click(object sender, EventArgs e)
        {
            // Each time you click the pictureBox, it will give you the Location of the Mouse Cursor
            // And will show you the numbers in a MessageBox
            MouseEventArgs me = (MouseEventArgs)e;
            Point mouse = me.Location;
            
            MessageBox.Show(mouse.X + " " + mouse.Y);
        }


        #region Methodes
        private void CreateArray()
        {
            // Creates Array with Size of TrackBar Value and gives each one a random Number
            test = new int[trackArraySize];
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = rnd.Next(5, 350);
            }
        }
        private void ShowArray()
        {
            // Creates the visual Bars in PictureBox
            // Each Bar has the height of the Array number
            
            int x = 0;
            int sizeX = 600 / test.Length;
            int width = (600 / test.Length) / 2;

            for (int i = 0; i < test.Length; i++)
            {
                if (i == highestNumberholderBubble || i == num)
                {
                    brush = new SolidBrush(Color.Blue);
                }
                g.FillRectangle(brush, 5 + x, 0, width, test[i]);
                brush = new SolidBrush(Color.Red);
                x += sizeX;

            }
        }


        #region Sorting Algorithm
        private void BubbleSort()
        {

            // This is the Methode to sort an array

            int i, j;
            int N = test.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (test[i] > test[i + 1])
                    {
                        highestNumberholderBubble = i + 1;
                        exchange(test, i, i + 1);
                        Thread.Sleep(speedBubbleSort);

                        pcbShowArray.Refresh();
                        
                    }
                       
                }
            }
        }


        private void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);

        }

        private void QuickSort(int[] array, int start, int ende)
        {
            if (start >= ende)
            {
                return;
            }

            num = array[start];
            int k = start;
            int l = ende;

            while (k < l)
            {
                while (k < l && array[l] >= num)
                {
                    l--;
                }

                array[k] = array[l];

                while (k < l && array[k] < num)
                {
                    k++;
                }

                array[l] = array[k];  

            }
            
            
            array[k] = num;
            Thread.Sleep(50);
            pcbShowArray.Refresh();
            QuickSort(array, start, k - 1);
            QuickSort(array, k + 1, ende);

        }

        #endregion
        private static void exchange(int[] data, int x , int y)
        {
            int temporary;

            temporary = data[x];
            data[x] = data[y];
            data[y] = temporary;

        }









        #endregion

        private void trackBarSizeArray_Scroll(object sender, EventArgs e)
        {
            // Enables all buttons
            btnSortAlge.Enabled = true;
            BtnQuickSort.Enabled = true;
            // Creates Array with the size of TrackBar Value
            k = 0;
            lblTestTrackBar.Text = "" + trackBarSizeArray.Value;
            trackArraySize = trackBarSizeArray.Value;

            #region Speed Value
            if (trackBarSizeArray.Value <= 15)
            {
                speedBubbleSort = 200;
            }
            else if (trackBarSizeArray.Value >= 15 && trackBarSizeArray.Value < 25)
            {
                speedBubbleSort = 100;
            }
            else if (trackBarSizeArray.Value >= 25 && trackBarSizeArray.Value < 35)
            {
                speedBubbleSort = 60;
            }
            else if (trackBarSizeArray.Value >= 35 && trackBarSizeArray.Value < 45)
            {
                speedBubbleSort = 40;
            }
            else if (trackBarSizeArray.Value >= 45 && trackBarSizeArray.Value < 55)
            {
                speedBubbleSort = 20;
            }
            else if (trackBarSizeArray.Value >= 55 && trackBarSizeArray.Value < 65)
            {
                speedBubbleSort = 17;
            }
            else if (trackBarSizeArray.Value >= 65 && trackBarSizeArray.Value < 75)
            {
                speedBubbleSort = 14;
            }
            else if (trackBarSizeArray.Value >= 75 && trackBarSizeArray.Value < 85)
            {
                speedBubbleSort = 11;
            }
            else if (trackBarSizeArray.Value >= 85 && trackBarSizeArray.Value < 95)
            {
                speedBubbleSort = 8;
            }
            else
            {
                speedBubbleSort = 5;
            }
            #endregion

            CreateArray();
            pcbShowArray.Refresh();
            
        }

        
    }
}
