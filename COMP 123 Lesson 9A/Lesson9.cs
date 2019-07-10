using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_123_Lesson_9A
{
    public partial class Lesson9 : Form
    {
        public Lesson9()
        {
            InitializeComponent();
        }

        private void Lesson9_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void NumberButtonTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Shared event for calculator button click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorNumber_Click(object sender, EventArgs e)
        {
            //Button selectedButton = (Button)sender;//down cast



            Button selectedButton = sender as Button;
            Button selectedButton = sender as Button;
            Button selectedButton = sender as Button;
            Button selectedButton = sender as Button;
            resultLabel.Text = selectedButton.Text;
            switch (selectedButton.Text)
            {
                case "1":
                    resultLabel.Text = "1";
                    break;
                default:
                    break;
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {

        }
    }
}
