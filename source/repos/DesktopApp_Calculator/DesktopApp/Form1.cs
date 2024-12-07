using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                if (comboBox1.SelectedItem == null || comboBox1.SelectedIndex == -1)
                {
                    throw new InvalidOperationException("Please select an Operator !");
                }
                string Operator = comboBox1.SelectedItem.ToString();
                double result = 0;
                switch (Operator)
                {
                    case "Addition":
                        result = number1 + number2;
                        break;
                    case "Substraction":
                        result = number1 - number2;
                        break;
                    case "Multiplication":
                        result = number1 * number2;
                        break;
                    case "Division":
                        try
                        {
                            result = number1 / number2;
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Cannot divide by zero");
                            return;
                        }
                        break;
                }
                string resultText = $"Calculated value of {Operator} operation is : {result}";
                Answer resultPage = new Answer(resultText);
                resultPage.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number");
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AllowOnlyDigits(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigits(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyDigits(sender, e);
        }
    }
}
