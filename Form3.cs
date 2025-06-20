using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_project
{
    public partial class Form3 : Form
    {
        private PizzaOrder _order;

        public Form3(PizzaOrder order)
        {
            InitializeComponent();
            _order = order;
        }

        

        private void laFishTaitel_Click(object sender, EventArgs e)
        {
            laFishTaitel.BackColor = Color.Transparent;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            laPizzaSize.BackColor = Color.Transparent;
            laCeustType.BackColor = Color.Transparent;
            laPlace.BackColor = Color.Transparent;
            laTotal3.BackColor = Color.Transparent;
            laToppings3.BackColor = Color.Transparent;


            laPizzaSize.Text = "Size: " + _order.Size;
            laCeustType.Text = "Crust: " + _order.Crust;
            laPlace.Text = "Place: " + _order.Place;
            laTotal3.Text = "Total: $" + _order.TotalPrice.ToString("0.00");

            if (_order.Toppings.Any())
                laToppings3.Text = "Toppings: " + string.Join(", ", _order.Toppings);
            else
                laToppings3.Text = "No extra toppings";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void laPizzaSize_Click(object sender, EventArgs e)
        {

        }

        private void laCeustType_Click(object sender, EventArgs e)
        {

        }

        private void laPlace_Click(object sender, EventArgs e)
        {

        }

        private void laTotal3_Click(object sender, EventArgs e)
        {

        }
    }
}
