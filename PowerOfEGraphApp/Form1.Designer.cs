namespace PowerOfEGraphApp
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.intervalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.to5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.to47ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.to20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // chart
      // 
      chartArea1.AxisX.Maximum = 5D;
      chartArea1.AxisX.Minimum = 4D;
      chartArea1.Name = "ChartArea1";
      this.chart.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart.Legends.Add(legend1);
      this.chart.Location = new System.Drawing.Point(12, 27);
      this.chart.Name = "chart";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series1.Legend = "Legend1";
      series1.Name = "e^x";
      this.chart.Series.Add(series1);
      this.chart.Size = new System.Drawing.Size(776, 411);
      this.chart.TabIndex = 0;
      this.chart.Text = "chart1";
      title1.Name = "Title1";
      title1.Text = "Graph of e^x";
      this.chart.Titles.Add(title1);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem,
            this.intervalsToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // colorsToolStripMenuItem
      // 
      this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem});
      this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
      this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
      this.colorsToolStripMenuItem.Text = "Colors";
      // 
      // intervalsToolStripMenuItem
      // 
      this.intervalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.to5ToolStripMenuItem,
            this.to47ToolStripMenuItem,
            this.to20ToolStripMenuItem});
      this.intervalsToolStripMenuItem.Name = "intervalsToolStripMenuItem";
      this.intervalsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
      this.intervalsToolStripMenuItem.Text = "Intervals";
      // 
      // greenToolStripMenuItem
      // 
      this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
      this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.greenToolStripMenuItem.Text = "Green";
      this.greenToolStripMenuItem.Click += new System.EventHandler(this.onGreenClick);
      // 
      // blueToolStripMenuItem
      // 
      this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
      this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.blueToolStripMenuItem.Text = "Blue";
      this.blueToolStripMenuItem.Click += new System.EventHandler(this.onBlueClick);
      // 
      // redToolStripMenuItem
      // 
      this.redToolStripMenuItem.Name = "redToolStripMenuItem";
      this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.redToolStripMenuItem.Text = "Red";
      this.redToolStripMenuItem.Click += new System.EventHandler(this.onRedClick);
      // 
      // to5ToolStripMenuItem
      // 
      this.to5ToolStripMenuItem.Name = "to5ToolStripMenuItem";
      this.to5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.to5ToolStripMenuItem.Text = "4 to 5";
      this.to5ToolStripMenuItem.Click += new System.EventHandler(this.on4to5Click);
      // 
      // to47ToolStripMenuItem
      // 
      this.to47ToolStripMenuItem.Name = "to47ToolStripMenuItem";
      this.to47ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.to47ToolStripMenuItem.Text = "2.3 to 4.7";
      this.to47ToolStripMenuItem.Click += new System.EventHandler(this.on2pt3to4pt7Click);
      // 
      // to20ToolStripMenuItem
      // 
      this.to20ToolStripMenuItem.Name = "to20ToolStripMenuItem";
      this.to20ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.to20ToolStripMenuItem.Text = "0 to 20";
      this.to20ToolStripMenuItem.Click += new System.EventHandler(this.on0to20Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.chart);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Graph of e^x";
      this.Load += new System.EventHandler(this.onLoad);
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem intervalsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem to5ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem to47ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem to20ToolStripMenuItem;
  }
}

