using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calcaulator_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CurrentResult = 0;
        private string CurrentOperation = "";
        private bool EndCurrentOperation = false;
       
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (EndCurrentOperation && textBox.Text.Length > 0 && IsOperator(textBox.Text[textBox.Text.Length - 1]))
            {
                // If the last character is an operator and EndCurrentOperation is true,
                // append the number instead of replacing the text
                textBox.Text += ((Button)sender).Text;
            }

            else if (textBox.Text == "0" || (EndCurrentOperation && textBox.Text.Length > 0 && !IsOperator(textBox.Text[textBox.Text.Length - 1])))
            {
                // If the current operation is "=", clear the text box and set the text to the button's text
                textBox.Text = ((Button)sender).Text;
                EndCurrentOperation = false;
            }
            else
            {
                // Otherwise, replace the text with the number
                textBox.Text += ((Button)sender).Text;
                EndCurrentOperation = false;
            }
        }
        bool HandleOperatorsCasesMistakes()
        {
            // Check if the TextBox text contains any operators
            if ((!textBox.Text.Contains("+") && !textBox.Text.Contains("-") && !textBox.Text.Contains("×") && !textBox.Text.Contains("÷"))||(
                textBox.Text.EndsWith("+") || textBox.Text.EndsWith("-") || textBox.Text.EndsWith("×") || textBox.Text.EndsWith("÷"))
                ||(textBox.Text.StartsWith("÷") || textBox.Text.StartsWith("×")))
                return true;
            
            return false;
        }
        void CalculateResult()
        {
            if (HandleOperatorsCasesMistakes())
                return;
            

            // Split the expression into operands and operators
            string[] operands = textBox.Text.Split(new char[] { '+', '-', '×', '÷' }, StringSplitOptions.RemoveEmptyEntries);
            string[] operators = textBox.Text.Split(operands, StringSplitOptions.RemoveEmptyEntries);

            // Convert the operands from string to double
            List<double> numbers = operands.Select(double.Parse).ToList();


            CurrentResult = numbers[0];

            if (textBox.Text.StartsWith("-"))
            {
                CurrentResult = -CurrentResult;
                numbers[0] = -numbers[0];
                operators = operators.Skip(1).ToArray();
            }
            if (textBox.Text.StartsWith("+"))
            {
                CurrentResult = +CurrentResult;
                numbers[0] = +numbers[0];
                operators = operators.Skip(1).ToArray();
            }

            for (int i = 0; i < operators.Length; i++)
            {
                if (operators[i] == "×" || operators[i] == "÷")
                {
                    if (operators[i] == "×")
                    {
                        numbers[i + 1] *= numbers[i]; // Perform multiplication
                    }
                    else
                    {
                        if (numbers[i + 1] != 0)
                        {
                            numbers[i + 1] = numbers[i] / numbers[i + 1]; // Perform division
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // Remove processed operator and operand
                    operators = operators.Where((val, idx) => idx != i).ToArray();
                    numbers.RemoveAt(i);
                    i--; // Adjust the index for the removed elements
                }
            }
            // Initialize CurrentResult with the first operand
            CurrentResult = numbers[0];
            numbers.RemoveAt(0);

            for (int i = 0; i < operators.Length; i++)
            {
                switch (operators[i])
                {
                    case "+":
                        CurrentResult += numbers[i];
                        break;
                    case "-":
                        CurrentResult -= numbers[i];
                        break;
                }
            }

            // Check if the result is not a whole number and format it accordingly
            if (CurrentResult % 1 != 0)
            {
                textBox.Text = CurrentResult.ToString("0.00");
            }
            else
            {
                textBox.Text = CurrentResult.ToString();
            }
        }

        private void btnEqualation_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Contains("+^") || textBox.Text.Contains("+√") ||
                    textBox.Text.Contains("-^") || textBox.Text.Contains("-√") ||
                    textBox.Text.Contains("×^") || textBox.Text.Contains("×√") ||
                      textBox.Text.Contains("÷^") || textBox.Text.Contains("÷√"))
            {
                
                // Remove the incomplete exponent expression
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 2);
            }

            
            CalculateResult();
            //EndCurrentOperation = true;
           
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == "0")
            {
                textBox.Text = ((Button)sender).Text;
               // return;
            }

            // Check if the last character in the textbox is an operator
            if (IsOperator(textBox.Text[textBox.Text.Length - 1]))
            {
                // Remove the last operator
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }

            textBox.Text += ((Button)sender).Text;
            CurrentOperation = ((Button)sender).Text;
            CalculateResult();
        }
        private void btnResetOrClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0)
                return;
            
            textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
        }
        private void btndotforfloat_Click(object sender, EventArgs e)
        {
            textBox.Text += btndotforfloat.Text;
        }

        private bool IsOperator(char character)
        {
            return character == '+' || character == '-' || character == '×' || character == '÷';
        }

        private void btnexponentoperator_Click(object sender, EventArgs e)
        {
            textBox.Text += btnexponentoperator.Text;

            int caretIndex = textBox.Text.IndexOf("^");
            //char character = textBox.Text[caretIndex - 1];

            if (caretIndex == -1 || (caretIndex > 0 && IsOperator(textBox.Text[caretIndex - 1])))
            {
                //EndCurrentOperation = true;
                return;
            }


            int baseStartIndex = caretIndex - 1;
            while (baseStartIndex >= 0 && (char.IsDigit(textBox.Text[baseStartIndex]) || textBox.Text[baseStartIndex] == '.'))
            {
                baseStartIndex--;
            }
            baseStartIndex++; // Adjust to the start of the base number

            // Extract the base number from the text box text
            string baseNumber = textBox.Text.Substring(baseStartIndex, caretIndex - baseStartIndex);
            double basevalue = double.Parse(baseNumber);

            double result = Math.Pow(basevalue, 2);

            textBox.Text = textBox.Text.Replace(baseNumber+ "^", result.ToString());
            //EndCurrentOperation = true;
        }

        private void btnsqrtoperator_Click(object sender, EventArgs e)
        {
            textBox.Text += btnsqrtoperator.Text; // Add the square root symbol to the textbox

            int squareRootIndex = textBox.Text.IndexOf("√"); // Find the last occurrence of the square root symbol

            if (squareRootIndex == -1 || (squareRootIndex > 0 && IsOperator(textBox.Text[squareRootIndex - 1])))
            {
                //EndCurrentOperation = true;
                return;
            }

            // Find the start index of the number to be square rooted
            int baseStartIndex = squareRootIndex - 1;
            while (baseStartIndex >= 0 && (char.IsDigit(textBox.Text[baseStartIndex]) || textBox.Text[baseStartIndex] == '.'))
            {
                baseStartIndex--;
            }
            baseStartIndex++;

            // Extract the number to be square rooted from the textbox text
            string baseNumber = textBox.Text.Substring(baseStartIndex, squareRootIndex - baseStartIndex);
            double baseValue = double.Parse(baseNumber);

            // Calculate the square root
            double result = Math.Sqrt(baseValue);

            // Replace the number to be square rooted and the square root symbol with the calculated result
            textBox.Text = textBox.Text.Replace(baseNumber + "√", result.ToString());
        }

        
    }
}       
