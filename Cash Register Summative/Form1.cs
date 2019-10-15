using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register_Summative
{
    //Paige Chaisson
    public partial class PokeMart : Form
    {

       const double POKEBALL = 100;
       const double GREATBALL = 300;
       const double ULTRABALL = 800;
       const double tax = 0.13;

        int numberOfpBalls;
        int numberOfgBalls;
        int numberOfuBalls;

        double subTotal;
        double taxTotal;
        double total;

        public static double GREATBALL1 => GREATBALL;

        public PokeMart()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            //on screen
            g.FillRectangle(whiteBrush, 300, 30, 200, 400);
        }

        private void CalculateTotalsButton_Click(object sender, EventArgs e)
        {
            numberOfuBalls =  Convert.ToInt32(ultraInput.Text);
            numberOfgBalls = Convert.ToInt32(greatInput.Text); 
            numberOfpBalls  = Convert.ToInt32(pokeInput.Text);

            subTotal = POKEBALL * numberOfpBalls  + GREATBALL *numberOfgBalls + ULTRABALL * numberOfuBalls ;
            subOutput.Text = subTotal.ToString("C");

            taxTotal = numberOfpBalls * tax + numberOfgBalls * tax + numberOfuBalls * tax;
            taxOutput.Text = taxTotal.ToString("C");


            total = subTotal + taxTotal; 
            totalOutput.Text = total.ToString("C");

        }

        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            Thread.Sleep(1000);

            g.DrawString("PokeMart inc.", drawFont, drawBrush, 362,29);

            Thread.Sleep(1000);

            g.DrawString("October,31,2019.", drawFont, drawBrush, 362, 52);

            Thread.Sleep(1000);

            g.DrawString("Pokeballs  X " + numberOfpBalls, drawFont, drawBrush, 300, 92);

            Thread.Sleep(1000);

            g.DrawString("Greatballs X" + numberOfgBalls, drawFont, drawBrush, 300, 107);

            Thread.Sleep(1000);

            g.DrawString("Ultraballs X" + numberOfuBalls, drawFont, drawBrush, 300, 122);

            Thread.Sleep(1000);

            g.DrawString("sub         " + subTotal.ToString("C"), drawFont, drawBrush, 300, 152);

            Thread.Sleep(1000);

            g.DrawString("Tax         " +  taxTotal.ToString("C"), drawFont, drawBrush, 300, 167);

            Thread.Sleep(1000);

            g.DrawString("Total       " +  total.ToString("C"), drawFont, drawBrush, 300, 182);

            Thread.Sleep(1000);

            g.DrawString(" Have A day!!! " , drawFont, drawBrush, 362, 210);




        }
    }
}
