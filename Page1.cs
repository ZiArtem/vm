using System;
using System.Collections.Generic;
using System.IO;

namespace vm_lab_1 {
  class vm_metod {
	static double func(double x, double y, double delta) {
	  return -delta * y - Math.Sin(x);
	}

	public static void build(double h, double x0, double y0, double delta, int right, List<double> res_x, List<double> res_y, StreamWriter sw) { 
	  res_x.Add(x0);
	  res_y.Add(y0);
	  int i = 0;
	  double k = 0;
	  while (k < right) {
		double k1_x = h * res_y[i];
		double k1_y = h * func(res_x[i], res_y[i], delta);
		double k2_x = h * (res_y[i] + k1_x / 2);
		double k2_y = h * func(res_x[i] + k1_x / 2, res_y[i] + k1_y / 2, delta);
		double k3_x = h * (res_y[i] + k2_x / 2);
		double k3_y = h * func(res_x[i] + k2_x / 2, res_y[i] + k2_y / 2, delta);
		double k4_x = h * (res_y[i] + k3_x);
		double k4_y = h * func(res_x[i] + k3_x, res_y[i] + k3_y, delta);

		double xt = res_x[i] + (k1_x + 2 * k2_x + 2 * k3_x + k4_x) / 6;
		res_x.Add(xt);

		double yt = res_y[i] + (k1_y + 2 * k2_y + 2 * k3_y + k4_y) / 6;
		res_y.Add(yt);

		sw.WriteLine($"N = {i}, x = {xt}, y = {yt}");
		++i;
		k += h;
	  }
	}

	public static void extend(double h, double delta, int n, List<double> res_x, List<double> res_y, StreamWriter sw) {
	  int i = res_x.Count - 1;
	  double k = 0;
	  while (k < 10) {
		double k1_x = h * res_y[i];
		double k1_y = h * func(res_x[i], res_y[i], delta);
		double k2_x = h * (res_y[i] + k1_x / 2);
		double k2_y = h * func(res_x[i] + k1_x / 2, res_y[i] + k1_y / 2, delta);
		double k3_x = h * (res_y[i] + k2_x / 2);
		double k3_y = h * func(res_x[i] + k2_x / 2, res_y[i] + k2_y / 2, delta);
		double k4_x = h * (res_y[i] + k3_x);
		double k4_y = h * func(res_x[i] + k3_x, res_y[i] + k3_y, delta);

		double xt = res_x[i] + (k1_x + 2 * k2_x + 2 * k3_x + k4_x) / 6;
		res_x.Add(xt);

		double yt = res_y[i] + (k1_y + 2 * k2_y + 2 * k3_y + k4_y) / 6;
		res_y.Add(yt);

		sw.WriteLine($"N = {i}, x = {xt}, y = {yt}");
		++i;
		k += h;
	  }
	}
  }
}