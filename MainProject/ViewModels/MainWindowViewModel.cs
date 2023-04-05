using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;

namespace MainProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            #region LineDiagram
            // ����������� ������ ��� �������
            var timeMax = new DateTime(2023, 4, 3, 21, 0, 0);
            var timeMin = new DateTime(2023, 4, 3, 6, 0, 0);
            var timeRange = timeMax - timeMin;

            // ����������� ������ ��� ��������
            var valueMin = 0;
            var valueMax = 200;
            var valueRange = valueMax - valueMin;
            var valueStep = 50;

            // �������� ����
            var xAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = DateTimeAxis.ToDouble(timeMin),
                Maximum = DateTimeAxis.ToDouble(timeMax),
                IntervalType = DateTimeIntervalType.Hours,
                StringFormat = "HH"
            };
            var yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = valueMin,
                Maximum = valueMax,
                MajorStep = valueStep
            };
            

            // �������� ������ �������
            this.MyPlotModel = new PlotModel { Title = "������� ���" };
            this.MyPlotModel.Axes.Add(xAxis);
            this.MyPlotModel.Axes.Add(yAxis);

            // �������� ����� ������ ��� �������
            var series = new LineSeries { Title = "������� ���" };
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTimeAxis.ToDouble(timeMin)), 0));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 7, 0, 0)), 40));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 8, 0, 0)), 100));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 9, 0, 0)), 150));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 10, 0, 0)), 100));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 11, 0, 0)), 50));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 12, 0, 0)), 100));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 13, 0, 0)), 150));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 14, 0, 0)), 100));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 15, 0, 0)), 50));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 16, 0, 0)), 50));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 17, 0, 0)), 100));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 18, 0, 0)), 150));



            // ���������� ����� ������ � ������ �������
            this.MyPlotModel.Series.Add(series);
            #endregion

            // ������� ����� ������ ��� �������� ���������
            var circleSeries = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 0
            };

            // ��������� �������
            circleSeries.Slices.Add(new PieSlice("������", 75) { IsExploded = false, Fill = OxyColors.Green });
            circleSeries.Slices.Add(new PieSlice("������", 25) { IsExploded = false, Fill = OxyColors.Red});

            // ������� ������ ������� � ��������� � ��� ����� ������
            this.CircleModel = new PlotModel {};
            CircleModel.Series.Add(circleSeries);
            
        }

        public PlotModel MyPlotModel { get; private set; }
        public PlotModel CircleModel { get; private set; }
    }
}


