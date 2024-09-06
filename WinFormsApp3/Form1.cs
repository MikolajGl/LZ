using System.Diagnostics;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addnewrow();
        }

        private void addnewrow()
        {
            Panel rowpanel = new Panel();
            rowpanel.AutoSize = true;



            TextBox t = new TextBox();
            t.Width = 100;
            rowpanel.Controls.Add(t);
            NumericUpDown numer = new NumericUpDown();
            numer.Width = 100;
            numer.Left = t.Right + 10;
            numer.DecimalPlaces = 2;
            rowpanel.Controls.Add(numer);
            NumericUpDown numer1 = new NumericUpDown();
            numer1.Width = 100;
            numer1.Left = numer.Right + 10;
            numer.DecimalPlaces = 2;
            rowpanel.Controls.Add(numer1);
            TextBox price1 = new TextBox();
            price1.Width = 100;
            price1.Left = numer1.Right + 10;
            rowpanel.Controls.Add(price1);
            Button deleterow = new Button();
            deleterow.Width = 100;
            deleterow.Text = " jebac";
            deleterow.Left = price1.Right + 10;
            deleterow.Click += (s, args) =>
            {
                flowLayoutPanel1.Controls.Remove(rowpanel);
            };
            numer.ValueChanged += (s, args) => urt(numer, numer1, price1);
            numer1.ValueChanged += (s, args) => urt(numer, numer1, price1);
            rowpanel.Controls.Add(deleterow);
            flowLayoutPanel1.Controls.Add(rowpanel);
        }

        private void urt(NumericUpDown numer,NumericUpDown numer1,TextBox price1)
        {
            double sum = (double)(numer.Value * numer1.Value);
            price1.Text = sum.ToString();
            utss();
        }

        
       private void utss()
        {
            double totalsum = 0;
            foreach (Panel panel in flowLayoutPanel1.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is TextBox price1 && double.TryParse(price1.Text, out double pri))
                    {
                        totalsum += pri;

                    }

                }

            }
            textBox1.Text = totalsum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}