using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Globalization;

namespace MethodProblems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * 1. Design a method to calculate the volume of a box when the length, width and height of
         * the box are passed to the function.
         */
        private void BtnVolume_Click(object sender, EventArgs e)
        {
            float length = float.Parse(Interaction.InputBox("Enter in Length", "Volume Calculator", ""), CultureInfo.InvariantCulture);
            float width = float.Parse(Interaction.InputBox("Enter in Width", "Volume Calculator", ""), CultureInfo.InvariantCulture);
            float height = float.Parse(Interaction.InputBox("Enter in Height", "Volume Calculator", ""), CultureInfo.InvariantCulture);

            float answer = Volume(length, width, height);

            MessageBox.Show("The Volume of " + length.ToString() + ", " + width.ToString() + " and " + height.ToString() + " is " + answer.ToString());

        }

        private float Volume(float _x, float _y, float _z)
        {
            return _x * _y * _z;
        }

        /*
         * 2. Design a method that will determine whether a number passed to it is even or odd. Eg.
         * EvenOdd(15) should return the word ‘odd’ .
         */
        private void BtnEvenOrOdd_Click(object sender, EventArgs e)
        {
            float number = float.Parse(Interaction.InputBox("Enter in a number", "Even or Odd Calculator", ""), CultureInfo.InvariantCulture);
            
            MessageBox.Show(EvenOdd(number));

        }

        private string EvenOdd(float _number)
        {
            if (_number % 2 == 0)
            {
                return "This number is even";
            }
            else
            {
                return "This number is odd";
            }
        }

        /*
         * 3. Design a method that will determine the remainder of two numbers. 
         * Eg. Remainder(12,7) should return the number 5. Note: The first number passed is always larger than second.
         */
        private void BtnRemainder_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(Interaction.InputBox("Enter in a number", "Remainder Calculator", ""), CultureInfo.InvariantCulture);
            float number2 = float.Parse(Interaction.InputBox("Enter in a number", "Remainder Calculator", ""), CultureInfo.InvariantCulture);

            MessageBox.Show("The Remainder of " + number1 + " and " + number2 + " is " + Remainder(number1, number2).ToString());
        }

        private float Remainder(float _x, float _y)
        {
            return _x % _y;
        }

        /*
         * 4. Design a method that will determine the cube root of a number passed to it. Hint: C# has
         * the a square root method but does not have a built in cube root method. You will have to
         * remember some math. Does fractional exponents ring a bell?
         */
        private void BtnCubeRoot_Click(object sender, EventArgs e)
        {
            double number = float.Parse(Interaction.InputBox("Enter in a number", "Cube Root Calculator", ""), CultureInfo.InvariantCulture);

            MessageBox.Show("The Cube root of " + number + " is " + CubeRoot(number).ToString());
        }

        private double CubeRoot(double _number)
        {
            return Math.Round(Math.Pow(_number, (double)1 / 3), 2);
        }

        /*
         * 5. Design a function to determine the cost of mailing a package. Your function should
         * expect the weight of the package to be passed as a parameter. Using this weight will
         * permit the function to return a value that will reflect the cost of the mailing. You must 
         * the following to determine the cost.
         * Packages weighing less than 8 grams will cost .32
         * Packages weighing more than 8 grams and less than or equal to 12 will cost .47
         * Packages weighing more than 12 grams and less than or equal to 16 will cost .62
         * Packages weighing more than 16 grams and less than or equal to 20 will cost .77
         * Packages weighing more than 20 grams and less than or equal to 24 will cost .92
         * Packages weighing more than 24 -> Display message “too heavy” and cost 0
         */
        private void BtnMailCostCalculator_Click(object sender, EventArgs e)
        {
            float weight = float.Parse(Interaction.InputBox("Enter in the Weight of the Package", "Package Calculator", ""), CultureInfo.InvariantCulture);

            if (weight >= 24)
                MessageBox.Show("Too heavy, must be 24 grams or under.");

                MessageBox.Show("The price for a package weighing " + weight + " grams is $" + CalculatePrice(weight).ToString());
        }

        private float CalculatePrice(float _weight)
        {
            if (_weight <= 8)
                return 0.32f;
            else if (_weight > 8 && _weight <= 12)
                return 0.47f;
            else if (_weight > 12 && _weight <= 16)
                return 0.62f;
            else if (_weight > 16 && _weight <= 20)
                return 0.77f;
            else if (_weight > 20 && _weight <= 24)
                return 0.92f;
            else
                return 0f;
        }

        /*
         * Make a program that rolls dice  
         */
        private void BtnDiceRoll_Click(object sender, EventArgs e)
        {
            Random rng1 = new Random();
            Random rng2 = new Random();
            int winnings = 5;

            while (true)
            {
                MessageBox.Show("You have " + winnings + " credits left");
                string input = Interaction.InputBox(@"Do you want to roll the die?
y/n.", "Dice roll game", "");

                if (input != "y")
                {
                    MessageBox.Show("Thank you for playing.");
                    break;
                }

                int sum = rng1.Next(1, 7) + rng2.Next(1, 7);

                if (sum == 2 || sum == 12)
                {
                    winnings += 1;
                    MessageBox.Show("You rolled a total of " + sum + ". You win! You have " + winnings + " credits." );
                }
                else if (sum != 7)
                {
                    MessageBox.Show("You rolled a total of " + sum + ". You break even! You have " + winnings + " credits.");
                }
                else
                {
                    winnings -= 2;
                    MessageBox.Show("You rolled a total of " + sum + ". You break lose! You have " + winnings + " credits.");
                    if (winnings <= 0)
                    {
                        MessageBox.Show("You lost all your credits, you lose.");
                        break;
                    }
                }
            }

        }

    }
}
