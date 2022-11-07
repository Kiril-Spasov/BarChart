using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace BarChart
{
    public partial class FormBarChart : Form
    {
        public FormBarChart()
        {
            InitializeComponent();
        }

        Graphics g;
        
        private void BtnHorizontal_Click(object sender, EventArgs e)
        {
            string[] year = new string[20];
            double[] sales = new double[20];
            int counter = 0;

            LoadData(year, sales, ref counter);
            DisplayHorizontalBarGraph(year, sales, counter);
            
        }

        private void LoadData(string[] y, double[] s, ref int c)
        {
            string path = Application.StartupPath + @"\sales.txt";
            StreamReader streamReader = new StreamReader(path);

            string line1, line2;
            bool flag = false;

            while (!flag)
            {               
                line1 = streamReader.ReadLine();
                line2 = streamReader.ReadLine();

                if (line1 == null || line2 == null)
                {
                    flag = true;
                }
                else
                {
                    c++;
                    y[c] = line1;
                    s[c] = Convert.ToDouble(line2);
                }
            }
            streamReader.Close();
        }

        private double FindScalingFactor(double[] s, int c)
        {
            double biggest = s[1];

            for (int i = 1; i <= c; i++)
            {
                if (s[i] > biggest)
                    biggest = s[i];
            }

            double scalingFactor = biggest / (panel1.Width - 200);

            return scalingFactor;
        }

        private void DisplayHorizontalBarGraph(string[] y, double[] s, int c)
        {
            Random r = new Random();

            double sf = FindScalingFactor(s, c);

            g.Clear(panel1.BackColor);
            Font font = new Font("Verdana", 8);
            SolidBrush brush = new SolidBrush(Color.Blue);

            g.DrawString("Sales Bar Chart", font, brush, panel1.Width / 2, 10);
            g.DrawString("Year", font, brush, 10, 45);
            g.DrawString("Sales", font, brush, 50, 45);

            for (int i = 1; i <= c; i++)
            {
                g.DrawString(y[i], font, brush, 10, 48 + i * 30);
                g.DrawString(s[i].ToString("c"), font, brush, 50, 48 + i * 30);

                int x = (int)(s[i] / sf);
                Color randomColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                SolidBrush newBrush = new SolidBrush(randomColor);
                g.FillRectangle(newBrush, 120, 50 + i * 30, x, 10);
            }
        }

        private void FormBarChart_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVertical_Click(object sender, EventArgs e)
        {
            string[] year = new string[20];
            double[] sales = new double[20];
            int counter = 0;

            LoadData(year, sales, ref counter);
            DisplayVerticalBarGraph(year, sales, counter);
        }

        private void DisplayVerticalBarGraph(string[] y, double[] s, int c)
        {
            Random r = new Random();

            double sf = FindVerticalScalingFactor(s, c);

            g.Clear(panel1.BackColor);
            Font font = new Font("Verdana", 8);
            SolidBrush brush = new SolidBrush(Color.Blue);

            g.DrawString("Sales Bar Chart", font, brush, panel1.Width / 2, 10);

            for (int i = 1; i <= c; i++)
            {
                g.DrawString(y[i], font, brush, 10 + i * 50, panel1.Height - 50);
                
                int yHeight = (int)(s[i] / sf);
                Color randomColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                SolidBrush newBrush = new SolidBrush(randomColor);
                g.FillRectangle(newBrush, 20 + i * 50, panel1.Height - 50 - yHeight, 10, yHeight);

                g.DrawString(s[i].ToString("c"), font, brush, i * 50 - 5, panel1.Height - 50 - yHeight - 20);
            }
        }

        private double FindVerticalScalingFactor(double[] s, int c)
        {
            double biggest = s[1];

            for (int i = 1; i <= c; i++)
            {
                if (s[i] > biggest)
                    biggest = s[i];
            }

            double scalingFactor = biggest / (panel1.Height - 200);

            return scalingFactor;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
