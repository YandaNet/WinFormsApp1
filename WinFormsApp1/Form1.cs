namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operationON = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(string digit)
        {
            if (digitText.Text == "0" || operationON)
            {
                digitText.Text = "";
            }
            operationON = false;
            digitText.Text += digit;
        }

        private void one_Click(object sender, EventArgs e)
        {
            button_click("1");
        }
        private void two_Click(object sender, EventArgs e)
        {
            button_click("2");
        }
        private void three_Click(object sender, EventArgs e)
        {
            button_click("3");
        }
        private void four_Click(object sender, EventArgs e)
        {
            button_click("4");
        }
        private void five_Click(object sender, EventArgs e)
        {
            button_click("5");
        }
        private void six_Click(object sender, EventArgs e)
        {
            button_click("6");
        }
        private void seven_Click(object sender, EventArgs e)
        {
            button_click("7");
        }
        private void eight_Click(object sender, EventArgs e)
        {
            button_click("8");
        }
        private void nine_Click(object sender, EventArgs e)
        {
            button_click("9");
        }
        private void zero_Click(object sender, EventArgs e)
        {
            button_click("0");
        }
        private void dot_Click(object sender, EventArgs e)
        {
            char[] znak = { '+', '-', '*', '/' };
            string[] kusok = digitText.Text.Split(znak);
            string ost = kusok[kusok.Length - 1];

            if (ost.Split(',').Length == 1)
            {
                digitText.Text += ",";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            digitText.Text = "0";
            value = 0;
            operation = "";
        }


        private void setOperation(string op)
        {
            value = double.Parse(digitText.Text);
            operation = op;
            operationON = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            setOperation("+");
        }
        private void minus_Click(object sender, EventArgs e)
        {
            setOperation("-");
        }
        private void pomn_Click(object sender, EventArgs e)
        {
            setOperation("*");
        }
        private void podil_Click(object sender, EventArgs e)
        {
            setOperation("/");
        }

    


        private void dorivn_Click(object sender, EventArgs e)
        {
            double second = double.Parse(digitText.Text);
            switch (operation)
            {
                case "+":
                    digitText.Text = (value + second).ToString();
                    break;
                case "-":
                    digitText.Text = (value - second).ToString();
                    break;
                case "*":
                    digitText.Text = (value * second).ToString();
                    break;
                case "/":
                    if (second != 0)
                    {
                        digitText.Text = (value / second).ToString();
                    }
                    else
                    {
                        digitText.Text = "u can`t divide by 0";
                    }
                    break;
            }
            operation = "";
        }
    }
}
