using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ミニSCADAプロジェクト
{

    public partial class SACADA : Form
    {
        //変数
        Random rand = new Random();
        int time = 0;
        string logFile = "DataLog.csv";

        public SACADA()
        {
            InitializeComponent();

        }
        private void SACADA_Load(object sender, EventArgs e)
        {
            // チャートの設定
            chart1.Series.Clear();
            Series tempSeries = new Series("Temp");
            tempSeries.ChartType = SeriesChartType.Line;
            chart1.Series.Add(tempSeries);
            Series pressureSeries = new Series("Pressure");
            pressureSeries.ChartType = SeriesChartType.Line;
            chart1.Series.Add(pressureSeries);


            // CSV初期化

            if (!File.Exists(logFile))
            {
                File.WriteAllText(logFile, "Time,Temperature,Pressure,State\n", Encoding.UTF8);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int temperature = rand.Next(20, 40);
            int pressure = rand.Next(1, 10);

            bool running = rand.Next(0, 2) == 1;
            string stateText = running ? "稼働" : "停止";

            // ラベル更新
            Degrees.Text = "温度：" + temperature + "℃";
            Pressure.Text = "圧力：" + pressure + "MPa";
            State.Text = "状態：" + stateText;
            State.ForeColor = running ? Color.Green : Color.Gray;

            // グラフ更新
            chart1.Series["Temp"].Points.AddXY(time, temperature);
            chart1.Series["Pressure"].Points.AddXY(time, pressure);
            if (chart1.Series["Temp"].Points.Count > 30) chart1.Series["Temp"].Points.RemoveAt(0);
            if (chart1.Series["Pressure"].Points.Count > 30) chart1.Series["Pressure"].Points.RemoveAt(0);
            time++;

            // CSVに追記
            string line = $"{DateTime.Now},{temperature},{pressure},{stateText}\n";
            File.AppendAllText(logFile, line, Encoding.UTF8);

        }
    }
}
