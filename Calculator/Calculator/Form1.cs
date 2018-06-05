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
        public Form1()
        {
            InitializeComponent();
        }
        string Number1,Number2;
        char ActionFlag = ' ';

        private void bDivision_Click(object sender, EventArgs e)
        {
            ActionFlag = '/';
            tbResoult.Text = "";
        }

        private void bMultiplication_Click(object sender, EventArgs e)
        {
            ActionFlag = '*';
            tbResoult.Text = "";
        }

        private void bSubstraction_Click(object sender, EventArgs e)
        {
            ActionFlag = '-';
            tbResoult.Text = "";
        }

        private void bAdition_Click(object sender, EventArgs e)
        {
            ActionFlag = '+';
            tbResoult.Text = "";
        }

        private void bResoult_Click(object sender, EventArgs e)
        {
            switch(ActionFlag)
            {
                case('+'):
                    tbResoult.Text = (int.Parse(Number1) + int.Parse(Number2)).ToString();
                    break;
                case ('-'):
                    tbResoult.Text = (int.Parse(Number1) - int.Parse(Number2)).ToString();
                    break;

                case ('/'):
                    tbResoult.Text = (int.Parse(Number1) * int.Parse(Number2)).ToString();
                    break;

                case ('*'):
                    tbResoult.Text = (int.Parse(Number1) / int.Parse(Number2)).ToString();
                    break;
                              
            }
            Number1 = "1";
            Number2 = "2";
            ActionFlag = ' ';
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Action(9);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Action(6);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Action(3);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Action(2);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Action(5);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Action(8);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Action(7);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Action(4);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Action(1);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Action(0);
        }
        private void Action (int Number)
        {
            if (ActionFlag == ' ')
            {
                Number1 += Number;
                tbResoult.Text = Number1;

            }
            else
            {
                Number2 += Number;
                tbResoult.Text = Number2;
            }
        }
    }
}
