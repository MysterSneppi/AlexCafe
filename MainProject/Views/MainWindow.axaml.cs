using Avalonia.Controls;
using OxyPlot;
using System.Collections.Generic;
using System;

namespace MainProject.Views
{
    public partial class MainWindow : Window
    {
        public IList<DataPoint> MyData { get; }
        public MainWindow()
        {
            var points = new List<DataPoint>();
            for (double x = 0; x < 2 * Math.PI; x += 0.1)
            {
                double y = Math.Sin(x);
                points.Add(new DataPoint(x, y));
            }

            MyData = points;

            InitializeComponent();
            this.DataContext = this;   
        }
    }
}
