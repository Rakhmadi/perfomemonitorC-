using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Cpsusg
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {

            InitializeComponent();
          
        }
       

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            double j=performanceCounter2.NextValue();
            int u = Convert.ToInt32(j);
            double s = performanceCounter1.NextValue();
            int d = Convert.ToInt32(s);
            metroLabel1.Text = d.ToString()+" %";
            metroProgressSpinner1.Value = d;
            chart1.Series["CPU"].Points.AddY(d);
            chart1.Series["RAM"].Points.AddY(u);
        }

        private void MetroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
