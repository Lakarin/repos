using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

namespace LineChartApp
{
    public partial class Form1 : Form
    {
        List<double>[,] IC = new List<double>[8,6];
        Button[] ICbtn;

        private void Chart_Load()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    IC[i, j] = new List<double>();
                }
            }

            ICbtn = new Button[8]{
                button_ic0 , button_ic1 , button_ic2 , button_ic3 ,
                button_ic4 , button_ic5 , button_ic6 , button_ic7 };

            chart1.ChartAreas[0].AxisX.Title = "Distance (M)";

            for (int i = 0; i < 8; i++)
            {
                chart1.Series["IC" + i].Points.AddXY(1, 1);
                chart1.Series["IC" + i].BorderWidth = 3;
                chart1.Series["IC" + i].Enabled = (i == 0);
                chart1.Series["IC" + i].Points.Clear();
            }

            //chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart1.ChartAreas[0].AxisX.Interval = 0.3;
        }

        private void button_ic0_Click(object sender, EventArgs e)
        {
            CurrentSeries(0);
        }

        private void button_ic1_Click(object sender, EventArgs e)
        {
            CurrentSeries(1);
        }

        private void button_ic2_Click(object sender, EventArgs e)
        {
            CurrentSeries(2);
        }

        private void button_ic3_Click(object sender, EventArgs e)
        {
            CurrentSeries(3);
        }

        private void button_ic4_Click(object sender, EventArgs e)
        {
            CurrentSeries(4);
        }

        private void button_ic5_Click(object sender, EventArgs e)
        {
            CurrentSeries(5);
        }

        private void button_ic6_Click(object sender, EventArgs e)
        {
            CurrentSeries(6);
        }

        private void button_ic7_Click(object sender, EventArgs e)
        {
            CurrentSeries(7);
        }

        private void CurrentSeries(short num)
        {
            for (int i = 0; i < 8; i++)
            {
                if (Ports_Aval[i])
                {
                    ICbtn[i].Enabled = (i != num);
                    chart1.Series["IC" + i].Enabled = (i == num);
                }           
            }
            SelectedColorSeries(num);
        }

        private void SelectedColorSeries(short num)
        {
            for (int i = 0; i < 8; i++)
            {
                if (Ports_Aval[i])
                    ICbtn[i].BackColor = (i == num) ? Color.FromArgb(0,150,136) : Color.FromArgb(51, 51, 76);
            } 
        }

        private void NoSeries()
        {
            for (int i = 0; i < 8; i++)
            {
                ICbtn[i].Enabled = false;
                chart1.Series["IC" + i].Enabled = false;
            }
        }
    }
}
