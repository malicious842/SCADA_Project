
namespace ミニSCADAプロジェクト
{
    partial class SACADA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            timer1 = new System.Windows.Forms.Timer(components);
            Title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Pressure = new Label();
            Degrees = new Label();
            State = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Title
            // 
            Title.BackColor = Color.FromArgb(40, 52, 70);
            tableLayoutPanel1.SetColumnSpan(Title, 4);
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("メイリオ", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Title.ForeColor = Color.White;
            Title.Location = new Point(0, 0);
            Title.Margin = new Padding(0);
            Title.Name = "Title";
            Title.Size = new Size(800, 45);
            Title.TabIndex = 0;
            Title.Text = "ライン監視";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(Pressure, 0, 3);
            tableLayoutPanel1.Controls.Add(Title, 0, 0);
            tableLayoutPanel1.Controls.Add(Degrees, 0, 2);
            tableLayoutPanel1.Controls.Add(State, 0, 1);
            tableLayoutPanel1.Controls.Add(chart1, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Pressure
            // 
            Pressure.AutoSize = true;
            Pressure.BackColor = Color.White;
            Pressure.Dock = DockStyle.Fill;
            Pressure.ForeColor = Color.Black;
            Pressure.Location = new Point(10, 145);
            Pressure.Margin = new Padding(10);
            Pressure.Name = "Pressure";
            Pressure.Size = new Size(180, 25);
            Pressure.TabIndex = 3;
            Pressure.Text = "圧力：";
            Pressure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Degrees
            // 
            Degrees.AutoSize = true;
            Degrees.BackColor = Color.White;
            Degrees.Dock = DockStyle.Fill;
            Degrees.ForeColor = Color.Black;
            Degrees.Location = new Point(10, 100);
            Degrees.Margin = new Padding(10);
            Degrees.Name = "Degrees";
            Degrees.Size = new Size(180, 25);
            Degrees.TabIndex = 2;
            Degrees.Text = "温度：";
            Degrees.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // State
            // 
            State.AutoSize = true;
            State.BackColor = Color.White;
            State.Dock = DockStyle.Fill;
            State.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            State.ForeColor = Color.Black;
            State.ImageAlign = ContentAlignment.MiddleLeft;
            State.Location = new Point(10, 55);
            State.Margin = new Padding(10);
            State.Name = "State";
            State.Size = new Size(180, 25);
            State.TabIndex = 1;
            State.Text = "状態：";
            State.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            tableLayoutPanel1.SetColumnSpan(chart1, 4);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(5, 185);
            chart1.Margin = new Padding(5);
            chart1.Name = "chart1";
            tableLayoutPanel1.SetRowSpan(chart1, 5);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(790, 215);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            // 
            // SACADA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "SACADA";
            Load += SACADA_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label Title;
        private TableLayoutPanel tableLayoutPanel1;
        private Label State;
        private Label Degrees;
        private Label Pressure;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
