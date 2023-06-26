using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();

            this.numPad0.Click += GetNumpadHandler(0);
            this.numPad1.Click += GetNumpadHandler(1);
            this.numPad2.Click += GetNumpadHandler(2);
            this.numPad3.Click += GetNumpadHandler(3);
            this.numPad4.Click += GetNumpadHandler(4);
            this.numPad5.Click += GetNumpadHandler(5);
            this.numPad6.Click += GetNumpadHandler(6);
            this.numPad7.Click += GetNumpadHandler(7);
            this.numPad8.Click += GetNumpadHandler(8);
            this.numPad9.Click += GetNumpadHandler(9);
        }

        private EventHandler GetNumpadHandler(int num)
        {
            return new EventHandler((object sender, EventArgs e) =>
            {
                screen.Text += num;
            });
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            screen.Text += ".";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            calculator.Update(double.Parse(screen.Text));
            screen.Text = "";
            calculator.Update(Operator.ADD);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            calculator.Update(double.Parse(screen.Text));
            screen.Text = "";
            calculator.Update(Operator.SUB);
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            calculator.Update(double.Parse(screen.Text));
            screen.Text = "";
            calculator.Update(Operator.MUL);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            calculator.Update(double.Parse(screen.Text));
            screen.Text = "";
            calculator.Update(Operator.DIV);
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            calculator.Update(double.Parse(screen.Text));
            calculator.Execute();
            screen.Text = calculator.GetResult().ToString();
        }
    }
}
