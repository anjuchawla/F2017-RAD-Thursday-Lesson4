/*
 * Name : Anju Chawla
 * Date: Sep. 28, 2017
 * Purpose:This application allows the user to select multiple coffee type
 * in various quantities.
 * The amount due is displayed.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Sales
{
    public partial class frmCoffeeShop : Form
    {
        //module level variables - numbers default to 0; objects to null
        private decimal subTotalAmount, totalAmount, grandTotal;
        private RadioButton selectedRadioButton = null;

        //module level constants
        const decimal TaxRate = 0.13m;
        const decimal CappuccinoPrice = 2m;
        const decimal EspressoPrice = 2.25m;
        const decimal LattePrice = 1.75m;
        const decimal Icedprice = 2.50m;


       
        public frmCoffeeShop()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculates the amount for a selected coffee and accumulates
            //the subtotal too since customer can order more than 
            //one coffee in different quantities

            //local variables-do not have a default value
            int quantity = 0;
            decimal price, tax, itemAmount;

            //change settings 
            chkTakeout.Enabled = false;
            btnClear.Enabled = true;
            btnNewOrder.Enabled = true;

            try
            {
                //convert quantity value to int
                quantity = int.Parse(txtQuantity.Text);
              //  quantity = Convert.ToInt32(txtQuantity.Text);

                //number of coffees provided
                if(quantity > 0)
                {
                    //coffee selected - use switch or if/else - not independent if's
                    if(selectedRadioButton != null)
                    {
                        switch(selectedRadioButton.Name)
                        {
                            case "rdoCappuccino":
                                price = CappuccinoPrice;
                                break;
                            case "rdoEspresso":
                                price = EspressoPrice;
                                break;
                            case "rdoLatte":
                                price = LattePrice;
                                break;

                            case "rdoIcedCappuccino":
                            case "rdoIcedLatte":
                                price = Icedprice;
                                break;

                            default:
                                price = 0;
                                break;
                        }


                        //calculations
                        itemAmount = price * quantity;
                        subTotalAmount += itemAmount;
                        if (chkTakeout.Checked)
                        {
                            tax = TaxRate * subTotalAmount;
                        }
                        else
                            tax = 0;

                        totalAmount = subTotalAmount + tax;

                        //display the results
                        txtItemAmount.Text = itemAmount.ToString("c");
                        txtSubtotal.Text = subTotalAmount.ToString("c");
                        txtTax.Text = tax.ToString("c");
                        txtTotalDue.Text = totalAmount.ToString("c");
                        


                    }
                    else
                    {
                        MessageBox.Show("Please select a coffee type.",
                      "Coffee Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else
                {
                    MessageBox.Show("Enter the number of coffees must be a whole positive number.",
                      "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.SelectAll();
                    txtQuantity.Focus();

                }



            }
            catch(FormatException quantityFE)
            {
                if(txtQuantity.Text == string.Empty)
                {
                    MessageBox.Show("Quantity cannot be left blank. Please enter the number of coffees needed.",
                        "Quantity Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                else
                {
                    MessageBox.Show("Enter the number of coffees needed, must be a whole number.",
                       "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                txtQuantity.SelectAll();
                txtQuantity.Focus();

            }
            catch(OverflowException quantityOE)
            {
                MessageBox.Show("The number of coffees cannot be more than " + Int32.MaxValue,
                        "Quantity Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();


            }
            catch (Exception quantityE)
            {
                MessageBox.Show(quantityE.Message ,
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }







        }
        /// <summary>
        /// Default settings when the form is loaded
        /// </summary>
        /// <param name="sender">The control that calles the event handler </param>
        /// <param name="e">The event arguments </param>
        private void frmCoffeeShop_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            btnNewOrder.Enabled = false;

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //save the coffee selection made
            selectedRadioButton = (RadioButton)sender;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the user input and get back to start default state
            ClearInput();

        }

        private void ClearInput()
        {
            txtQuantity.Clear();
            txtItemAmount.Clear();
            if(selectedRadioButton != null)
            {
                selectedRadioButton.Checked = false;
                selectedRadioButton = null;
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            DialogResult confirm;

            confirm = MessageBox.Show("Are you sure you want to place a new order?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (confirm == DialogResult.Yes)
            {
                ClearInput();
                btnClear.Enabled = false;
                btnNewOrder.Enabled = false;
                txtItemAmount.Clear();
                txtTax.Clear();
                txtSubtotal.Clear();
                txtTotalDue.Clear();
                chkTakeout.Enabled = true;
                chkTakeout.Checked = false;
                txtQuantity.Focus();

                //reset the order totals
                subTotalAmount = 0;
                totalAmount = 0;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
           
        }
    }
}
