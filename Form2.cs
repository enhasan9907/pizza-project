using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void UpdateToPrice()
        {
            double total = 0;
            //price by size
            if (rbSmall.Checked) total += 5;
            else if (rbMeduim.Checked) total += 7;
            else if (rbLarg.Checked) total += 10;
            //price by crust
            if (rbThinCrust.Checked) total += 2;
            else if (rbThinkCrust.Checked) total += 5;
            //price by place
            if (rbEatIn.Checked) total += 3;
            else if (rbTakeOut.Checked) total += 0;
            //price by 
            if (ckbExtraChees.Checked)total += 2;
            if (ckbGreenPeppers.Checked) total += 2;
            if (ckbMushrooms.Checked) total += 2;
            if (ckbOlives.Checked) total += 2;
            if (ckbOnion.Checked) total += 2;
            if (ckbTomatoes.Checked) total += 2;



            laPrice.Text = total.ToString();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gbSize.BackColor = Color.Transparent;
            gbType.BackColor = Color.Transparent;
            gbPlace.BackColor = Color.Transparent;
            gbToppings.BackColor = Color.Transparent;
            laTitel.BackColor = Color.Transparent;
            laTotalPrice.BackColor = Color.Transparent;
            laPrice.BackColor = Color.Transparent;
            laDolar.BackColor = Color.Transparent;
            UIHelper.StyleOrangeRoundedButton(btnOrderFinish);
            rbLarg.Checked = true;


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void btnOrderFinish_Click(object sender, EventArgs e)
        {
            PizzaOrder order = new PizzaOrder();

            // Size
            if (rbSmall.Checked) order.Size = "Small";
            else if (rbMeduim.Checked) order.Size = "Medium";
            else if (rbLarg.Checked) order.Size = "Large";

            // Crust
            if (rbThinCrust.Checked) order.Crust = "Thin";
            else if (rbThinkCrust.Checked) order.Crust = "Thick";

            // Place
            if (rbEatIn.Checked) order.Place = "Eat In";
            else if (rbTakeOut.Checked) order.Place = "Take Out";

            // Toppings
            if (ckbExtraChees.Checked) order.Toppings.Add("Extra Cheese");
            if (ckbGreenPeppers.Checked) order.Toppings.Add("Green Peppers");
            if (ckbMushrooms.Checked) order.Toppings.Add("Mushrooms");
            if (ckbOlives.Checked) order.Toppings.Add("Olives");
            if (ckbOnion.Checked) order.Toppings.Add("Onion");
            if (ckbTomatoes.Checked) order.Toppings.Add("Tomatoes");

            // Price
            order.TotalPrice = Convert.ToDouble(laPrice.Text);

            // Show summary form
            Form3 summaryForm = new Form3(order);
            summaryForm.ShowDialog();
        }

        private void laPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void gbToppings_Enter(object sender, EventArgs e)
        {
            
        }

        private void ckbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void ckbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void ckbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void ckbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }

        private void ckbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToPrice();
        }
    }
}
