using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SPP12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //создание чарта
        Chart myChart = new Chart();

        //ининциализация серии точек
        Series mySeriesOfPoint = new Series("Task1");

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            myChart.Parent = this;
            //растянть чарт на фул форму
            myChart.Dock = DockStyle.Fill;
            //добавление новой области в чарт
            myChart.ChartAreas.Add(new ChartArea("Sin"));
            //тип чарта - линейная функция
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "Sin";
            //цвет линии
            mySeriesOfPoint.Color = Color.Green;

            //добавление точек
            for (double x = -10; x <= 10; x += 0.01)
            {
                mySeriesOfPoint.Points.AddXY(x, Math.Sin(x));

            }
            //добавление точек в чарт
            myChart.Series.Add(mySeriesOfPoint);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //очистка чартов
            myChart.Series.Clear();
            chart1.Series.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            //названия стобцов
            string[] labels = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            int i = 0;
            //заполение гистограммы
            for (double y = 0.1; y < 1; y += 0.1)
            {
                chart1.Series[0].Points.AddY(y);
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(i, i + 2, labels[i], 0, LabelMarkStyle.LineSideMark));
                i++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.Series.Clear();

            
            chart1.Series.Add(new Series("ColumnSeries")
            {
                ChartType = SeriesChartType.Pie //тип чарта - груговая диаграмма
            });

            //добавление инфы
            double[] yValues = { 2222, 2724, 2720, 3263, 2445 };
            string[] xValues = { "France", "Canada", "Germany", "USA", "Italy" };
            chart1.Series["ColumnSeries"].Points.DataBindXY(xValues, yValues);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            myChart.Parent = this;
            myChart.Dock = DockStyle.Fill;

            myChart.ChartAreas.Add(new ChartArea("Pol"));

            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "Pol";
            mySeriesOfPoint.Color = Color.Green;

            //заполенение графика полинома
            for (double x = -10; x <= 10; x += 4)
            {
                mySeriesOfPoint.Points.AddXY(x, 2*Math.Pow(x,2)+ 3*x+ 10 );

            }
            myChart.Series.Add(mySeriesOfPoint);
        }
    }
}
