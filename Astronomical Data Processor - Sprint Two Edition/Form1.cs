using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Caiden Bowers 30128222, Sprint One
    Date: 25/09/2025
    Version: 1.0
    Astronomical Data Processor
    Generates 20 data values between 1-100 and allows the values to be sorted, searched and rewritten by the user
*/

namespace Astronomical_Data_Processor
{
    public partial class AstroDataProcess : Form
    {
        public AstroDataProcess()
        {
            InitializeComponent();
        }
        
        static int max = 20; //sets amount of values to be placed in the array
        int[] myArray = new int[max];

        private void btnSort_Click(object sender, EventArgs e) //When the Sort button is clicked
        {
            if (lstElementDisplay.Items.Count == 0) //Checks if the values are loaded before sorting
            {
                MessageBox.Show("Please load items before attempting to sort."); //Denies sorting if no values loaded
            }
            else 
            { 
                int temp = 0;
                for (int outer = 0; outer < max - 1; outer++)
                {
                    for (int inner = 0; inner < max - 1; inner++)
                    {
                        if (myArray[inner] > myArray[inner + 1])
                        {
                            temp = myArray[inner + 1];
                            myArray[inner + 1] = myArray[inner];
                            myArray[inner] = temp;
                        }
                        //Sorts array from lowest to highest
                        ShowArray();
                        Application.DoEvents();
                    }
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e) //When Change button is clicked
        {
            int mid;
            int lowBound = 0;
            int highBound = max;
            int target;
            int searchFor;
            int changeTo;
            Int32.TryParse(txtChange.Text, out changeTo); //Sets value to the user's input to be changed to
            if (!(Int32.TryParse(txtSearchEdit.Text, out searchFor))) //Denies if user did not input an integer
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            
            while (lowBound <= highBound)
            {
                if (!(Int32.TryParse(txtChange.Text, out target))) //Denies if user did not input an integer
                {
                    MessageBox.Show("You must enter an integer");
                    return;
                }
                else
                {
                    mid = (lowBound + highBound) / 2;
                    if (myArray[mid] == searchFor)
                    {
                        lstElementDisplay.Items.Remove(myArray[mid]);
                        lstElementDisplay.Items.Add(myArray[mid] = changeTo);
                        txtSearchEdit.Clear();
                        lstIndex.Items.Clear();
                        txtChange.Clear();
                        txtSearch.Clear();
                        return;
                        //Searches for and replaces desired integer with new input
                    }
                    else if (myArray[mid] >= searchFor) //Continues search if search failed
                    {
                        highBound = mid - 1;
                    }
                    else
                    {
                        lowBound = mid + 1;
                    }
                }
            }
            
        }
        private void btnSearch_Click(object sender, EventArgs e) //When Search button clicked
        {
            txtSearchEdit.Clear();
            lstIndex.Items.Clear();
            int mid;
            int lowBound = 0;
            int highBound = max;
            int target;
            if (!(Int32.TryParse(txtSearch.Text, out target))) //Denies search if no integer input
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            while (lowBound <= highBound)
            {
                mid = (lowBound + highBound) / 2;
                if (myArray[mid] == target) //Search was successful
                {
                    lstIndex.Items.Add("Found at index " + (mid + 1));
                    txtSearchEdit.Text = target.ToString();
                    return;
                }
                else if (myArray[mid] >= target) //Search is continuing
                {
                    highBound = mid - 1;
                }
                else
                {
                    lowBound = mid + 1;
                }
            }
            MessageBox.Show("Not found, try again."); //Informs user the search failed
        }

        private void btnLoad_Click(object sender, EventArgs e) //When Load button clicked
        {
            FillArray(); //Generates values
            ShowArray(); //Displays values
        }
        private void btnClear_Click(object sender, EventArgs e) //When Clear button clicked
        {
            lstElementDisplay.Items.Clear();
            txtSearchEdit.Clear();
            txtSearch.Clear();
            txtChange.Clear();
            lstIndex.Items.Clear();
            //Clears all values
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstElementDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtSearchEdit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lstIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ShowArray()
        {
            lstElementDisplay.Items.Clear();
            for (int i = 0; i < max; i++)
            {
                lstElementDisplay.Items.Add(myArray[i]); //Displays values in array
            }
        }

        private void FillArray()
        {
            Random rand = new Random();
            for (int i = 0; i < max; i++)
            {
                myArray[i] = rand.Next(100); //Generates values from 1-100
            }
        }
    }
}
//BETTER WORK
