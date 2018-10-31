using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptuneCalculator
{
    public partial class frmTotalInterest : Form
    {
        public frmTotalInterest()
        {
            InitializeComponent();
        }

        private void frmTotalInterest_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIntCalc_Click(object sender, EventArgs e)
        {

                decimal payment = decimal.Parse(txtPaymentAmt.Text, System.Globalization.NumberStyles.Currency);              
                decimal principal = decimal.Parse(txtPrincipal.Text, System.Globalization.NumberStyles.Currency);
                int months = Int16.Parse(txtLength.Text, System.Globalization.NumberStyles.Currency);


                decimal totalPayment = payment * months;
                decimal totalInterest = totalPayment - principal;

                txtTotalInterest.Text = totalInterest.ToString.Form();

                
        }
        
            



        }
        
       

 
   
    }

