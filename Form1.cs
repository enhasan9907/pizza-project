using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace pizza_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            UIHelper.StyleOrangeRoundedButton(btnOrderNow);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form form1 = new Form2();
            form1.ShowDialog();

        }

        
    }
}
