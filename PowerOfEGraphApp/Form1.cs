using System;
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
      fillChart();
    }

    private void fillChart()
    {
      for (double i = 4; i <= 5; i+=.1)
      {
        chart.Series[0].Points.AddXY(i, Math.Pow(Math.E, i));
      }
    }
  }
}
