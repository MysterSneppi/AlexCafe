using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.ObjectModel;

namespace MainProject.ViewModels
{
    internal class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            #region LineDiagram
            // Определение границ оси времени
            var timeMax = new DateTime(2023, 4, 3, 21, 0, 0);
            var timeMin = new DateTime(2023, 4, 3, 6, 0, 0);
            var timeRange = timeMax - timeMin;

            // Определение границ оси значений
            var valueMin = 0;
            var valueMax = 200;
            var valueRange = valueMax - valueMin;
            var valueStep = 50;

            // Создание осей
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

            this.MyPlotModel = new PlotModel { Title = "Середінй чек" };
            this.MyPlotModel.Axes.Add(xAxis);
            this.MyPlotModel.Axes.Add(yAxis);

            // Создание серии данных для графика
            var series = new LineSeries { Title = "Средний чек" };
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


            // Добавление серии данных в модель графика

            this.MyPlotModel.Series.Add(series);

            #endregion



            #region LineDiagram2

            Diagram = new PlotModel { Title = "Відвідуваність" };
            var xAxis2 = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = DateTimeAxis.ToDouble(timeMin),
                Maximum = DateTimeAxis.ToDouble(timeMax),
                IntervalType = DateTimeIntervalType.Hours,
                StringFormat = "HH"
            };

            var yAxis2 = new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = 0,
                Maximum = 50,
                MajorStep = 10
            };

            Diagram.Axes.Add(xAxis2);
            Diagram.Axes.Add(yAxis2);

            var series2 = new LineSeries { Title = "Средний чек" };
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTimeAxis.ToDouble(timeMin)), 0));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 7, 0, 0)), 10));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 8, 0, 0)), 30));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 9, 0, 0)), 22));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 10, 0, 0)), 15));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 11, 0, 0)), 13));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 12, 0, 0)), 16));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 13, 0, 0)), 24));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 14, 0, 0)), 11));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 15, 0, 0)), 15));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 16, 0, 0)), 18));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 17, 0, 0)), 10));
            series2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(new DateTime(2023, 4, 3, 18, 0, 0)), 8));

            Diagram.Series.Add(series2);
            #endregion
            #region Круговая Диаграма
            // Создаем серию данных для круговой диаграммы
            var circleSeries = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 0
            };

            // Добавляем секторы
            circleSeries.Slices.Add(new PieSlice("Картка", 75) { IsExploded = false, Fill = OxyColors.Green });
            circleSeries.Slices.Add(new PieSlice("Готівка", 25) { IsExploded = false, Fill = OxyColors.Red });

            // Создаем модель графика и добавляем в нее серию данных
            this.CircleModel = new PlotModel { };
            CircleModel.Series.Add(circleSeries);


            People = new ObservableCollection<TopProduct>
            {
                new TopProduct { Name = "Булка з маком", Value = 40 },
                new TopProduct { Name = "Капучіно", Value = 35 },
                new TopProduct { Name = "Еспресо", Value = 32 },
                new TopProduct { Name = "Рістретто", Value = 30 },
                new TopProduct { Name = "Американо", Value = 26 },
                new TopProduct { Name = "Допп", Value = 22 },
                new TopProduct { Name = "Арабіка", Value = 20 },
                new TopProduct { Name = "Латте", Value = 15 },
                new TopProduct { Name = "Гібралтар", Value = 7 }
            };
            #endregion

        }
        public PlotModel MyPlotModel { get; private set; }
        public PlotModel Diagram { get; private set; }
        public PlotModel CircleModel { get; private set; }
        public ObservableCollection<TopProduct> People { get; set; }
    }
    public class TopProduct
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
