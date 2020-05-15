using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace vm_lab_1{
  public partial class Form1 : Form {
	public Form1() {
	  InitializeComponent();
	}
	List<double> res_x;
	List<double> res_y;
	int num_of_series = 0;
	StreamWriter sw = new StreamWriter("data.txt", false, System.Text.Encoding.Default);

	private void button1_Click(object sender, EventArgs e) {
	  double h = Convert.ToDouble(this.h.Text);
	  int right = Convert.ToInt32(this.right.Text);
	  int left = Convert.ToInt32(this.left.Text);
	  double delta = Convert.ToDouble(this.delta.Text);
	  double x0 = Convert.ToDouble(this.x0.Text);
	  double dx = Convert.ToDouble(this.dx.Text);

	  Random random = new Random();
	  this.chart1.Series.Add(Convert.ToString(++num_of_series));
	  this.chart1.Series[num_of_series].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
	  this.chart1.Series[num_of_series].Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
	  if (num_of_series == 1) {
		res_x = new List<double>();
		res_y = new List<double>();
	  } else {
		res_x.Clear();
		res_y.Clear();
	  }

	  sw.WriteLine($" ");
	  sw.WriteLine($"num_of_series = {num_of_series}");
	  vm_metod.build(h, x0, dx, delta, right, res_x, res_y, sw);
	  int size = (int)(left / h);
	  for (int i = size; i < res_x.Count; i++) {
		this.chart1.Series[num_of_series].Points.AddXY(res_x[i], res_y[i]);
	  }
	}

	private void button2_Click(object sender, EventArgs e) {
	  for (int i = 0; i < num_of_series + 1; ++i) {
		this.chart1.Series[i].Points.Clear();
	  }
	  sw.Close();
	  sw = new StreamWriter("data.txt", false, System.Text.Encoding.Default);
	}

	private void button3_Click(object sender, EventArgs e) {
	  double h = Convert.ToDouble(this.h.Text);
	  int n = Convert.ToInt32(this.left.Text);
	  double delta = Convert.ToDouble(this.delta.Text);
	  int size = res_x.Count - 1;
	  vm_metod.extend(h, delta, n, res_x, res_y, sw);

	  for (int i = size; i < res_x.Count; i++) {
		this.chart1.Series[num_of_series].Points.AddXY(res_x[i], res_y[i]);
	  }
	}
  }
}

