using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersionA_Task2
{
    public partial class Form1 : Form
    {
        //Name: Matthew Dring   
        //ID: 1264121

        //Width of a hand bag
        const int BAG_WIDTH = 50;
        //Height of a hand bag
        const int BAG_HEIGHT = 50;
        //The number of columns of hand bags to draw
        const int NUM_COLUMNS = 10;
        //The gap between rows and columns
        const int GAP = 10;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method clears the picturebox and textbox then sets the focus back to the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
            rowAmountInput.Clear();
            rowAmountInput.Focus();
        }
        /// <summary>
        /// This is the click even method for the draw hand bags button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            int MINIMUM_ROWS = 2;
            int MAXIMUM_ROWS = 10;
            int numberOfRows = 0;

            //Convert the input text into an integer
            numberOfRows = Convert.ToInt32(rowAmountInput.Text);


            //Check that the number of rows provided is valid otherwise return a error message
            if (numberOfRows < MINIMUM_ROWS || numberOfRows > MAXIMUM_ROWS)
            {
                MessageBox.Show("Please enter a valid number between 2 and 10");
                pictureBoxDisplay.Refresh();
                rowAmountInput.Clear();
                rowAmountInput.Focus();
            }
            

            //Create graphics object
            Graphics g = pictureBoxDisplay.CreateGraphics();
            //Clear the picturebox
            pictureBoxDisplay.Refresh();

            //Delcare variables
            int startX = 10;
            int startY = 10;

            //This is the for loop for the rows
            for (int row = 1; row <= numberOfRows; row++)
            {
                //This is the for loop for the columns
                for (int column = 1; column <= 10; column++)
                {
                    //This sets the x and y position for the hand bags
                    int x = startX + (column - 1) * (BAG_HEIGHT + GAP);
                    int y = startY + (row - 1) * (BAG_HEIGHT + GAP);

                    //This makes every third column a purple bag
                    Color color = (column % 3 == 0) ? Color.Purple : Color.Red;

                    //This draws the solid rectangle
                    using (Brush brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, x, y, BAG_WIDTH, BAG_HEIGHT);
                    }
                    //This draws the black outline
                    using (Pen pen = new Pen(Color.Black))
                    {
                        g.DrawRectangle(pen, x, y, BAG_WIDTH, BAG_HEIGHT);
                    }
                }



            }
        }
    }
}
