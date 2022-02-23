
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.numberRateDollar = new System.Windows.Forms.NumericUpDown();
            this.numberRateEuro = new System.Windows.Forms.NumericUpDown();
            this.rateDollar = new System.Windows.Forms.Label();
            this.rateEuro = new System.Windows.Forms.Label();
            this.chartCurrency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRateDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberRateEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.numberRateDollar);
            this.panel1.Controls.Add(this.numberRateEuro);
            this.panel1.Controls.Add(this.rateDollar);
            this.panel1.Controls.Add(this.rateEuro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(705, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(83, 39);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Прогноз";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numberRateDollar
            // 
            this.numberRateDollar.DecimalPlaces = 2;
            this.numberRateDollar.Location = new System.Drawing.Point(282, 21);
            this.numberRateDollar.Name = "numberRateDollar";
            this.numberRateDollar.Size = new System.Drawing.Size(120, 22);
            this.numberRateDollar.TabIndex = 3;
            this.numberRateDollar.Value = new decimal(new int[] {
            7744,
            0,
            0,
            131072});
            // 
            // numberRateEuro
            // 
            this.numberRateEuro.DecimalPlaces = 2;
            this.numberRateEuro.Location = new System.Drawing.Point(58, 21);
            this.numberRateEuro.Name = "numberRateEuro";
            this.numberRateEuro.Size = new System.Drawing.Size(120, 22);
            this.numberRateEuro.TabIndex = 2;
            this.numberRateEuro.Value = new decimal(new int[] {
            8763,
            0,
            0,
            131072});
            // 
            // rateDollar
            // 
            this.rateDollar.AutoSize = true;
            this.rateDollar.Location = new System.Drawing.Point(217, 23);
            this.rateDollar.Name = "rateDollar";
            this.rateDollar.Size = new System.Drawing.Size(59, 17);
            this.rateDollar.TabIndex = 1;
            this.rateDollar.Text = "Доллар";
            // 
            // rateEuro
            // 
            this.rateEuro.AutoSize = true;
            this.rateEuro.Location = new System.Drawing.Point(12, 23);
            this.rateEuro.Name = "rateEuro";
            this.rateEuro.Size = new System.Drawing.Size(40, 17);
            this.rateEuro.TabIndex = 0;
            this.rateEuro.Text = "Евро";
            // 
            // chartCurrency
            // 
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Minimum = 60D;
            chartArea4.Name = "ChartArea1";
            this.chartCurrency.ChartAreas.Add(chartArea4);
            this.chartCurrency.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend4.Name = "Legend1";
            this.chartCurrency.Legends.Add(legend4);
            this.chartCurrency.Location = new System.Drawing.Point(0, 65);
            this.chartCurrency.Name = "chartCurrency";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.IsValueShownAsLabel = true;
            series7.LabelFormat = "C";
            series7.Legend = "Legend1";
            series7.Name = "Euro";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.IsValueShownAsLabel = true;
            series8.LabelFormat = "C";
            series8.Legend = "Legend1";
            series8.Name = "Dollar";
            this.chartCurrency.Series.Add(series7);
            this.chartCurrency.Series.Add(series8);
            this.chartCurrency.Size = new System.Drawing.Size(800, 385);
            this.chartCurrency.TabIndex = 1;
            this.chartCurrency.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartCurrency);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRateDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberRateEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numberRateDollar;
        private System.Windows.Forms.NumericUpDown numberRateEuro;
        private System.Windows.Forms.Label rateDollar;
        private System.Windows.Forms.Label rateEuro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCurrency;
        private System.Windows.Forms.Timer timer1;
    }
}

