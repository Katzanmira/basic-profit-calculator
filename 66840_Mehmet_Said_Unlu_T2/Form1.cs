using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _66840_Mehmet_Said_Unlu_T2
{
    public partial class Form1 : Form
    {
        private Company company;

        public Form1()
        {
            InitializeComponent();
            company = new Company();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text;
            int quantity = int.Parse(textBox2.Text);
            double price = double.Parse(textBox3.Text);
            double profitPercentage = double.Parse(textBox4.Text);

            string id = company.GenerateID(productName);
            label6.Text = id;

            double sumOfAll = company.CalculateSumOfAll(quantity, price);
            label8.Text = sumOfAll.ToString();

            double totalProfit = company.CalculateTotalProfit(sumOfAll, profitPercentage);
            label10.Text = totalProfit.ToString();
        }
    }
}
