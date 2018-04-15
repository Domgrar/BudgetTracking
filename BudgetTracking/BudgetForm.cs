using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetTracking
{
    public partial class BudgetForm : Form
    {
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = new Excel.Application(); 
        
        private static Excel.Worksheet MySheet = null;
        public BudgetForm()
        {
            InitializeComponent();
        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            // var logoimage = Path.Combine(outPutDirectory);
            string relLogo = new Uri(outPutDirectory).LocalPath;

            object misValue = System.Reflection.Missing.Value;

            MyBook = MyApp.Workbooks.Open(relLogo + "\\PriceTracking.xlsx");
            MySheet = MyBook.Sheets[1];


            Excel.ChartObjects xlCharts = (Excel.ChartObjects)MySheet.ChartObjects(Type.Missing);

            
           
            foreach (Excel.ChartObject co in xlCharts)
            {
                co.Select();
                Excel.Chart chart = (Excel.Chart)co.Chart;
                chart.Export(relLogo + @"\" + chart.Name + ".bmp", "BMP", false);
            }

            //Set bitmap images
            Bitmap img = new Bitmap(relLogo + "\\Sheet1 Total Chart.bmp");
            this.pictureBoxLargestItem.Image = img;
            
        }

        private void buttonSubmitInfo_Click(object sender, EventArgs e)
        {
            object misValue = System.Reflection.Missing.Value;

            MyBook = MyApp.Workbooks.Open("C:\\Users\\Jeremy\\Documents\\GitHub\\BudgetTracking\\BudgetTracking\\PriceTracking.xlsx");
            MySheet = MyBook.Sheets[1];
            

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)MySheet.ChartObjects(Type.Missing);
            //Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            
            //Excel.Chart chartPage = myChart.Chart;

            //chartRange = MySheet.get_Range("V2", "W9");
            //chartPage.SetSourceData(chartRange, misValue);
            //chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

          foreach (Excel.ChartObject co in xlCharts)
            {
                co.Select();
                Excel.Chart chart = (Excel.Chart)co.Chart;
                chart.Export("C:\\Users\\Jeremy\\Documents\\GitHub\\BudgetTracking\\BudgetTracking\\" + @"\" + chart.Name + ".bmp", "BMP", false);
            }
        }
}
}
