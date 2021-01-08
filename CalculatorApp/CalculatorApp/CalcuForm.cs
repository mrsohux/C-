using CalculatorApp.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalcuForm : Form,ICalcuView
    {
        public event EventHandler Add;
        public event EventHandler Reset;
        public CalcuForm()
        {
            InitializeComponent();
            button1.Click += delegate { Add?.Invoke(this, EventArgs.Empty); };

            button2.Click += delegate
            {
                Reset?.Invoke(this, EventArgs.Empty);
                textBox1.Focus();
            };
        }

     
        string ICalcuView.iValue1 { get => textBox1.Text;
            set => textBox1.Text = value;
        }
        string ICalcuView.iValue2 {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }
        string ICalcuView.iTotal {
            get => textBox3.Text;
            set => textBox3.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
