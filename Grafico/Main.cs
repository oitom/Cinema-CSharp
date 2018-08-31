using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Grafico
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MenuCinemaSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            double[] porcentagemA = { 300, 60 };
            double[] porcentagemB = { 270, 90 };
            double[] porcentagemC = { 90, 270 };


            string[] nameA = { "", "16%" };
            string[] nameB = { "", "25%" };
            string[] nameC = { "", "75%" };


            chart1.Series[0].Points.DataBindXY(nameA, porcentagemA);
           // chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            chart1.Legends[0].Enabled = false;


            chart2.Series[0].Points.DataBindXY(nameB, porcentagemB);
            //chart2.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            chart2.Legends[0].Enabled = false;


            chart3.Series[0].Points.DataBindXY(nameC, porcentagemC);
            //chart3.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            chart3.Legends[0].Enabled = false;

      }


    }
}
