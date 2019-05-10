using System;
using System.Drawing;
using System.Windows.Forms;

namespace PowerOfEGraphApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

    }

    private void onLoad(object sender, EventArgs e)
    {
      fillChart(4, 5, .1);
    }

    private void fillChart(double min, double max, double step)
    {
      chart.Series[0].Points.Clear();
      for (double i = min; i <= max; i+=step)
      {
        chart.Series[0].Points.AddXY(i, Math.Pow(Math.E, i));
      }
    }

    private void on4to5Click(object sender, EventArgs e)
    {
      chart.ChartAreas[0].AxisX.Minimum = 4;
      chart.ChartAreas[0].AxisX.Maximum = 5;
      chart.ChartAreas[0].AxisX.Interval = .1;
      fillChart(4, 5, .1);
    }

    private void on2pt3to4pt7Click(object sender, EventArgs e)
    {
      chart.ChartAreas[0].AxisX.Minimum = 2.3;
      chart.ChartAreas[0].AxisX.Maximum = 4.7;
      chart.ChartAreas[0].AxisX.Interval = .1;
      fillChart(2.3, 4.7, .1);
    }

    private void on0to20Click(object sender, EventArgs e)
    {
      chart.ChartAreas[0].AxisX.Minimum = 0;
      chart.ChartAreas[0].AxisX.Maximum = 20;
      chart.ChartAreas[0].AxisX.Interval = .5;
      fillChart(0, 20, .5);
    }

    private void onGreenClick(object sender, EventArgs e)
    {
      chart.Series[0].Color = Color.Green;
    }

    private void onBlueClick(object sender, EventArgs e)
    {
      chart.Series[0].Color = Color.Blue;
    }

    private void onRedClick(object sender, EventArgs e)
    {
      chart.Series[0].Color = Color.Red;
    }
  }
}
