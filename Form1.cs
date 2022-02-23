using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.025;
        int days = 1;
        bool checker = true;
        double rateEuro1;
        double rateDollar1;

        Random random = new Random();

        void checkTraceRate()
        {
            checker = false;

            rateEuro1 = (double)numberRateEuro.Value;
            rateDollar1 = (double)numberRateDollar.Value;

            chartCurrency.Series[0].Points.Clear();
            chartCurrency.Series[1].Points.Clear();

            chartCurrency.Series[0].Points.AddXY(0, rateEuro1);
            chartCurrency.Series[1].Points.AddXY(0, rateDollar1);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (checker) checkTraceRate();

            if (timer1.Enabled) timer1.Stop(); else timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rateEuro1 = rateEuro1 * (1 + k * (random.NextDouble() - 0.5));
            rateDollar1 = rateDollar1 * (1 + k * (random.NextDouble() - 0.5));

            chartCurrency.Series[0].Points.AddXY(days, rateEuro1);
            chartCurrency.Series[1].Points.AddXY(days, rateDollar1);

            days += 1;
        }
    }
}
