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
            Bitmap img = new Bitmap(relLogo + "\\Sheet1 Chart 4.bmp");
            this.pictureBoxLargestItem.Image = img;
            img = new Bitmap(relLogo + "\\Sheet1 Chart 3.bmp");
            this.pictureBoxLargestGroup.Image = img;



            //Close excel objects
            MyBook.Close();
            
            
        }

        private void buttonSubmitInfo_Click(object sender, EventArgs e)
        {
           
        }
}
}
