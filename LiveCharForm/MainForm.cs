using LiveCharts.Wpf.Charts.Base;
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

namespace LiveCharForm
{
    public partial class MainForm : Form
    {
        double x=0;
        double z=0;
        double u=0;
        double v=0;
        Timer time = new Timer();
        Timer time1 = new Timer();
        
        public MainForm()
        {
            InitializeComponent();
        }


        public void charLine(object b, EventArgs e)
        {
         
            //chart1.ChartAreas[1].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            //chart1.ChartAreas[1].AxisX.Maximum = z;
            z = z + 1;
        }
        private void btnclick_Click(object sender, EventArgs e)
        {


           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
