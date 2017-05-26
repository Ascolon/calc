using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        public bool isBin = false;
        bool znak = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = float.Parse(MainWindow.Text);
            MainWindow.Clear();
            count = 1;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MainWindow.Text = MainWindow.Text + ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = float.Parse(MainWindow.Text);
            MainWindow.Clear();
            count = 2;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(MainWindow.Text);
            MainWindow.Clear();
            count = 3;
            label1.Text = a.ToString();
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = float.Parse(MainWindow.Text);
            MainWindow.Clear();
            count = 4;
            label1.Text = a.ToString();
            znak = true;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }
        void calculate()
        {
            if (isBin)
            {
                int Q = Convert.ToInt32(MainWindow.Text, 2);
                int U = Convert.ToInt32(label1.Text, 2);
                int b3 = Q + U;
                MainWindow.Text = Convert.ToString(b3, 2);
                return;
            }
            switch (count)
            {
                case 1:
                    b = a + float.Parse(MainWindow.Text);
                    MainWindow.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(MainWindow.Text);
                    MainWindow.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(MainWindow.Text);
                    MainWindow.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(MainWindow.Text);
                    MainWindow.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (MainWindow.Text.Length == 0)
                return;
            MainWindow.Text = MainWindow.Text.Remove(MainWindow.Text.Length - 1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                MainWindow.Text = "-" + MainWindow.Text;
                znak = false;
            }
            else if (znak == false)
            {
                MainWindow.Text = MainWindow.Text.Replace("-", "");
                znak = true;
            }
        }

        private void SelectSystem(object sender, EventArgs e)
        {
            var item = (RadioButton)sender;
            switch (item.Name)
            {
                case "bin":
                    BinSystem();
                    break;
                case "dex":
                    HexSystem(false);
                    break;
                case "hex":
                    HexSystem(true);
                    break;
                case "oct":
                    HexSystem(false);
                    break;
            }
        }

        private void NewFunction(object sender, EventArgs e)
        {
            double Num;
            var item = (Button)sender;
            switch (item.Name)
            {
                case "sin":
                    Num = Math.Sin(double.Parse(MainWindow.Text));
                    MainWindow.Text = Num.ToString();
                    break;
                case "cos":
                    Num = Math.Cos(double.Parse(MainWindow.Text));
                    MainWindow.Text = Num.ToString();
                    break;
                case "tan":
                    Num = Math.Tan(double.Parse(MainWindow.Text));
                    MainWindow.Text = Num.ToString();
                    break;
                case "sqr":
                    Num = Math.Pow(double.Parse(MainWindow.Text),2);
                    MainWindow.Text = Num.ToString();
                    break;
                case "sqrt":
                    Num = Math.Sqrt(double.Parse(MainWindow.Text));
                    MainWindow.Text = Num.ToString();
                    break;
                case "abs":
                    Num = Math.Abs(double.Parse(MainWindow.Text));
                    MainWindow.Text = Num.ToString();
                    break;
                case "log":
                    Num = Math.Log(double.Parse(MainWindow.Text));
                    MainWindow.Text = Num.ToString();
                    break;
                case "round":
                    Num = Math.Round(double.Parse(MainWindow.Text));
                    MainWindow.Text = Num.ToString();
                    break;
            }
        }

        private void HexLick(object sender, EventArgs e)
        {
            var item = (Button)sender;
            if (hex.Checked)
                MainWindow.Text += item.Text;
        }

        void BinSystem()
        {
            isBin = true;
            for (int i = 0; i < Numbers.Controls.Count; i++)
            {
                if (Numbers.Controls[i].Name == "button1"
                    || Numbers.Controls[i].Name == "button2"
                    || Numbers.Controls[i].Name == "button16"
                    || Numbers.Controls[i].Name == "button17")
                {
                    Numbers.Controls[i].Enabled = true;
                }
                else
                {
                    Numbers.Controls[i].Enabled = false;
                }
            }
        }
        void HexSystem(bool b)
        {
            A16.Enabled = b;
            B16.Enabled = b;
            C16.Enabled = b;
            D16.Enabled = b;
            F16.Enabled = b;
            E16.Enabled = b;
            for (int i = 0; i < Numbers.Controls.Count; i++)
            {
                Numbers.Controls[i].Enabled = true;
            }
        }
    }
}

