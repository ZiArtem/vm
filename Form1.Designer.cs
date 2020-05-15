namespace vm_lab_1
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
	  System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
	  System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
	  System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
	  this.button1 = new System.Windows.Forms.Button();
	  this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
	  this.h = new System.Windows.Forms.TextBox();
	  this.delta = new System.Windows.Forms.TextBox();
	  this.x0 = new System.Windows.Forms.TextBox();
	  this.dx = new System.Windows.Forms.TextBox();
	  this.left = new System.Windows.Forms.TextBox();
	  this.label1 = new System.Windows.Forms.Label();
	  this.label2 = new System.Windows.Forms.Label();
	  this.label3 = new System.Windows.Forms.Label();
	  this.label4 = new System.Windows.Forms.Label();
	  this.label5 = new System.Windows.Forms.Label();
	  this.button2 = new System.Windows.Forms.Button();
	  this.button3 = new System.Windows.Forms.Button();
	  this.right = new System.Windows.Forms.TextBox();
	  this.label6 = new System.Windows.Forms.Label();
	  ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
	  this.SuspendLayout();
	  // 
	  // button1
	  // 
	  this.button1.Location = new System.Drawing.Point(1102, 184);
	  this.button1.Name = "button1";
	  this.button1.Size = new System.Drawing.Size(134, 49);
	  this.button1.TabIndex = 1;
	  this.button1.Text = "Построить ";
	  this.button1.UseVisualStyleBackColor = true;
	  this.button1.Click += new System.EventHandler(this.button1_Click);
	  // 
	  // chart1
	  // 
	  chartArea1.Name = "ChartArea1";
	  this.chart1.ChartAreas.Add(chartArea1);
	  legend1.Name = "Legend1";
	  this.chart1.Legends.Add(legend1);
	  this.chart1.Location = new System.Drawing.Point(0, 0);
	  this.chart1.Name = "chart1";
	  this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
	  series1.ChartArea = "ChartArea1";
	  series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
	  series1.IsXValueIndexed = true;
	  series1.Legend = "Legend1";
	  series1.Name = "Series1";
	  series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
	  this.chart1.Series.Add(series1);
	  this.chart1.Size = new System.Drawing.Size(1048, 607);
	  this.chart1.TabIndex = 2;
	  this.chart1.Text = "chart1";
	  // 
	  // h
	  // 
	  this.h.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.h.Location = new System.Drawing.Point(1136, 11);
	  this.h.Name = "h";
	  this.h.Size = new System.Drawing.Size(100, 22);
	  this.h.TabIndex = 3;
	  this.h.Text = "0,01";
	  // 
	  // delta
	  // 
	  this.delta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.delta.Location = new System.Drawing.Point(1136, 39);
	  this.delta.Name = "delta";
	  this.delta.Size = new System.Drawing.Size(100, 22);
	  this.delta.TabIndex = 4;
	  this.delta.Text = "1";
	  // 
	  // x0
	  // 
	  this.x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.x0.Location = new System.Drawing.Point(1136, 67);
	  this.x0.Name = "x0";
	  this.x0.Size = new System.Drawing.Size(100, 22);
	  this.x0.TabIndex = 5;
	  this.x0.Text = "5";
	  // 
	  // dx
	  // 
	  this.dx.Location = new System.Drawing.Point(1136, 95);
	  this.dx.Name = "dx";
	  this.dx.Size = new System.Drawing.Size(100, 20);
	  this.dx.TabIndex = 6;
	  this.dx.Text = "1";
	  // 
	  // left
	  // 
	  this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.left.Location = new System.Drawing.Point(1136, 121);
	  this.left.Name = "left";
	  this.left.Size = new System.Drawing.Size(100, 22);
	  this.left.TabIndex = 7;
	  this.left.Text = "1";
	  // 
	  // label1
	  // 
	  this.label1.AutoSize = true;
	  this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.label1.Location = new System.Drawing.Point(1066, 17);
	  this.label1.Name = "label1";
	  this.label1.Size = new System.Drawing.Size(44, 16);
	  this.label1.TabIndex = 8;
	  this.label1.Text = "шаг = ";
	  // 
	  // label2
	  // 
	  this.label2.AutoSize = true;
	  this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.label2.Location = new System.Drawing.Point(1082, 45);
	  this.label2.Name = "label2";
	  this.label2.Size = new System.Drawing.Size(28, 16);
	  this.label2.TabIndex = 9;
	  this.label2.Text = "δ = ";
	  // 
	  // label3
	  // 
	  this.label3.AutoSize = true;
	  this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.label3.Location = new System.Drawing.Point(1076, 73);
	  this.label3.Name = "label3";
	  this.label3.Size = new System.Drawing.Size(34, 16);
	  this.label3.TabIndex = 10;
	  this.label3.Text = "x0 = ";
	  // 
	  // label4
	  // 
	  this.label4.AutoSize = true;
	  this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.label4.Location = new System.Drawing.Point(1073, 99);
	  this.label4.Name = "label4";
	  this.label4.Size = new System.Drawing.Size(37, 16);
	  this.label4.TabIndex = 11;
	  this.label4.Text = "x0\' = ";
	  // 
	  // label5
	  // 
	  this.label5.AutoSize = true;
	  this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.label5.Location = new System.Drawing.Point(1072, 127);
	  this.label5.Name = "label5";
	  this.label5.Size = new System.Drawing.Size(38, 16);
	  this.label5.TabIndex = 12;
	  this.label5.Text = "left = ";
	  // 
	  // button2
	  // 
	  this.button2.Location = new System.Drawing.Point(1102, 293);
	  this.button2.Name = "button2";
	  this.button2.Size = new System.Drawing.Size(134, 49);
	  this.button2.TabIndex = 13;
	  this.button2.Text = "Очистить";
	  this.button2.UseVisualStyleBackColor = true;
	  this.button2.Click += new System.EventHandler(this.button2_Click);
	  // 
	  // button3
	  // 
	  this.button3.Location = new System.Drawing.Point(1102, 238);
	  this.button3.Name = "button3";
	  this.button3.Size = new System.Drawing.Size(134, 49);
	  this.button3.TabIndex = 14;
	  this.button3.Text = "Продолжить";
	  this.button3.UseVisualStyleBackColor = true;
	  this.button3.Click += new System.EventHandler(this.button3_Click);
	  // 
	  // right
	  // 
	  this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.right.Location = new System.Drawing.Point(1136, 149);
	  this.right.Name = "right";
	  this.right.Size = new System.Drawing.Size(100, 22);
	  this.right.TabIndex = 15;
	  this.right.Text = "10";
	  // 
	  // label6
	  // 
	  this.label6.AutoSize = true;
	  this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
	  this.label6.Location = new System.Drawing.Point(1064, 152);
	  this.label6.Name = "label6";
	  this.label6.Size = new System.Drawing.Size(46, 16);
	  this.label6.TabIndex = 16;
	  this.label6.Text = "right = ";
	  // 
	  // Form1
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(1248, 669);
	  this.Controls.Add(this.label6);
	  this.Controls.Add(this.right);
	  this.Controls.Add(this.button3);
	  this.Controls.Add(this.button2);
	  this.Controls.Add(this.label5);
	  this.Controls.Add(this.label4);
	  this.Controls.Add(this.label3);
	  this.Controls.Add(this.label2);
	  this.Controls.Add(this.label1);
	  this.Controls.Add(this.left);
	  this.Controls.Add(this.dx);
	  this.Controls.Add(this.x0);
	  this.Controls.Add(this.delta);
	  this.Controls.Add(this.h);
	  this.Controls.Add(this.chart1);
	  this.Controls.Add(this.button1);
	  this.Name = "Form1";
	  this.Text = "vm_lab1";
	  ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
	  this.ResumeLayout(false);
	  this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.TextBox h;
		private System.Windows.Forms.TextBox delta;
		private System.Windows.Forms.TextBox x0;
		private System.Windows.Forms.TextBox dx;
		private System.Windows.Forms.TextBox left;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox right;
		private System.Windows.Forms.Label label6;
	}
}

