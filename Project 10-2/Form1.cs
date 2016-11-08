using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double tax = 0.0775;
        double add1 = 0.75;
        double add2 = 0.50;
        double add3 = 0.25;
        double subtotal = 0;
        double totatcost = 0;
        double ntax = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             if (radioButton1.Checked)
            {
                clearCBox();
                groupBox2.Text = ("Add-on Items [$.75/each]");
                checkBox1.Text = ("Lettuce, tomato, and onions");
                checkBox2.Text = ("Mayonnaise and mustard");
                checkBox3.Text = ("French fries");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                clearCBox();
                groupBox2.Text = ("Add-on Items [$.50/each]");
                checkBox1.Text = ("Pepperoni");
                checkBox2.Text = ("Sausage");
                checkBox3.Text = ("Olives");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                clearCBox();
                groupBox2.Text = ("Add-on Items [$.25/each]");
                checkBox1.Text = ("Croutons");
                checkBox2.Text = ("Bacon bits");
                checkBox3.Text = ("Bread sticks");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           if (radioButton1.Checked)
            {
                subtotal = 6.95;

                if (checkBox1.Checked)
                    subtotal += add1;
                if (checkBox2.Checked)
                    subtotal += add1;
                if (checkBox3.Checked)
                    subtotal += add1;
            }
            if (radioButton2.Checked)
            {
                subtotal = 5.95;

                if (checkBox1.Checked)
                    subtotal += add2;
                if (checkBox2.Checked)
                    subtotal += add2;
                if (checkBox3.Checked)
                    subtotal += add2;
            }
            if (radioButton3.Checked)
            {
                subtotal = 4.95;

                if (checkBox1.Checked)
                    subtotal += add3;
                if (checkBox2.Checked)
                    subtotal += add3;
                if (checkBox3.Checked)
                    subtotal += add3;
            }
            textBox1.Text = subtotal.ToString("c2");
            ntax = (subtotal * tax);
            textBox2.Text = ntax.ToString("c2");
            totatcost = (subtotal + ntax);
            textBox3.Text = totatcost.ToString("c2");


        }
        private void clearCBox()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
